using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace N2
{
    public partial class Form1 : Form
    {
        List<List<int>> WM;
        List<string> ns = new List<string>();
        Graphics g1;
        Graphics g2;
        int Vsize;
        List<List<int>> samples;
        List<int> samp;
        int[] init;
        int[] dist;
        string cur_fold;
        string fname;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            g1 = Graphics.FromImage(pictureBox1.Image);
            g2 = Graphics.FromImage(pictureBox2.Image);
            g1.Clear(Color.White);
            g2.Clear(Color.White);
        }

        double ham_dist(int[] a, int[] b, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; ++i)
                sum += a[i] * b[i];
            double dist = 1 / 2.0 * (n - sum);
            return dist / n;
        }

        double ham_dist(List<int> a, List<int> b, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; ++i)
                sum += a[i] * b[i];
            double dist = 1 / 2.0 * (n - sum);
            return dist / n;
        }
        
        void hebb(int n, List<List<int>> x)
        {
            WM = new List<List<int>>();
            for (int i = 0; i < Vsize; ++i)
                WM.Add(new List<int>(Vsize));

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    if (i == j)
                        WM[i].Insert(j, 0);
                    else
                    {
                        int sum = 0;
                        int a = 0;
                        int b = 0;
                        for (int k = 0; k < x.Count; ++k)
                        {
                            a = x[k][j];

                            b = x[k][i];
                            sum += a * b;
                        }
                        WM[i].Insert(j, sum);
                    }
                }
        }

        int f_act(int x)
        {
            if (x > 0)
                return 1;
            else return -1;
        }

        void hopf(int[] v, double eps)
        {
            List<int> curr = new List<int>();
            for (int i = 0; i < Vsize; ++i)
                curr.Add(v[i]);
            bool stop = false;
            while (!stop)
            {
                List<int> next_y = new List<int>();
                for (int j = 0; j < Vsize; ++j)
                {
                    int sum = 0;
                    for (int i = 0; i < Vsize; ++i)
                    {
                        sum += WM[i][j] * curr[i];
                    }
                    if (sum <= 0)
                        next_y.Add(-1);
                    else
                        next_y.Add(1);
                }

                double diff = ham_dist(curr, next_y, Vsize);
                if (diff <= eps)
                    stop = true;
                curr = next_y;
            }
            Bitmap bm = new Bitmap(pictureBox2.Image);
            int pictsz = Convert.ToInt32(Math.Sqrt((double)Vsize));
            int l = 0;
            for (int i = 0; i < pictsz; ++i)
                for (int j = 0; j < pictsz; ++j)
                {
                    if (curr[l] == 1)
                        bm.SetPixel(j, i, Color.White);
                    else
                        bm.SetPixel(j, i, Color.Black);
                    ++l;
                }
            
            pictureBox2.Image = bm;

            int samp_ind = 0;
            double min_Hd = double.MaxValue;
            for (int i = 0; i < samples.Count; ++i)
            {
                double cHd = ham_dist(curr, samples[i], Vsize);
                if (cHd < min_Hd)
                {
                    min_Hd = cHd;
                    samp_ind = i;
                }
            }
            class_x.Text = ns[samp_ind];
        }

        private void samples_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            cur_fold = folderBrowserDialog1.SelectedPath;
            DirectoryInfo DI = new DirectoryInfo(cur_fold);
            List<string> files = new List<string>();
            foreach (FileInfo file in DI.GetFiles("*.txt"))
            {
                files.Add(Path.GetFileName(file.FullName));
                ns.Add(Path.GetFileNameWithoutExtension(file.Name));
            }

            samples = new List<List<int>>();
            for (int i = 0; i < files.Count; ++i)
            {
                samp = new List<int>();
                using (StreamReader reader = new StreamReader(File.Open(cur_fold + "\\" + files[i], FileMode.Open)))
                {
                    string text;

                    while ((text = reader.ReadLine()) != null)
                    {
                        string[] bits = text.Split(' ');
                        for (int l = 0; l < bits.Length - 1; ++l)
                        {
                            int s;
                            s = int.Parse(bits[l]);
                            samp.Add(s);
                        }
                    }
                    samples.Add(samp);
                }
            }
            Vsize = samples[0].Count;
            hebb(Vsize, samples);

            MessageBox.Show("Done!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
        private void load_im_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fname = openFileDialog1.FileName;
            init = new int[Vsize];
            dist = new int[Vsize];
            using (StreamReader reader = new StreamReader(File.Open(fname, FileMode.Open)))
            {
                string text;
                int m = 0;
                while ((text = reader.ReadLine()) != null)
                {
                    string[] bits = text.Split(' ');
                    for (int l = 0; l < bits.Length - 1; ++l)
                    {
                        int s;
                        s = int.Parse(bits[l]);
                        init[m] = s;
                        dist[m] = s;
                        ++m;
                    }
                }
            }

            int pictsz = Convert.ToInt32(Math.Sqrt((double)Vsize));
            int k = 0;
            Bitmap bm = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < pictsz; ++i)
                for (int j = 0; j < pictsz; ++j)
                {

                    if (init[k] == 1)
                        bm.SetPixel(j, i, Color.White);
                    else
                        bm.SetPixel(j, i, Color.Black);
                    ++k;
                }
            pictureBox1.Image = bm;
        }

        private void add_noise_Click(object sender, EventArgs e)
        {
            int perc = Convert.ToInt32(numericUpDown1.Value);
            int count = Convert.ToInt32(perc / 100.0 * Vsize);
            Random R = new Random();
            for (int i = 0; i < Vsize; ++i)
                dist[i] = init[i];
            while (count > 0)
            {
                int index = R.Next(0, Vsize);
                if (init[index] == -1)
                    dist[index] = 1;
                else dist[index] = -1;
                count--;
            }
            int pictsz = Convert.ToInt32(Math.Sqrt((double)Vsize));
            int k = 0;
            Bitmap bm = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < pictsz; ++i)
                for (int j = 0; j < pictsz; ++j)
                {
                    if (dist[k] == 1)
                        bm.SetPixel(j, i, Color.White);
                    else
                        bm.SetPixel(j, i, Color.Black);
                    ++k;
                }
            pictureBox1.Image = bm;
        }

        private void determ_Click(object sender, EventArgs e)
        {
            double ep = Convert.ToDouble(numericUpDown2.Value);
            hopf(dist, ep);
        }
    }
}
