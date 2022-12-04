using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace Lab1_kg_
{
    public partial class Form1 : Form
    {
        private Bitmap image, image2, image3, prevImage;
        private BitmapData ImageData, ImageData2;
        private byte[] buffer, buffer2;
        private int b, g, r, r_x, g_x, b_x, r_y, g_y, b_y, grayscale, location, location2;
        private sbyte weight_x, weight_y;
        private sbyte[,] weights_x;
        private sbyte[,] weights_y;

        public int clamp(int value, int min, int max) { return value < min ? min : value > max ? max : value; }

        private bool ImageIsNull()
        {
            if (pictureBox1.Image == null) MessageBox.Show("Загрузите изображение.", "Ошибка!");
            return pictureBox1.Image == null;
        }

        #region other
        //save
        private void save1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
            {
                try
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void gaussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gauss filter = new Gauss();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Opening();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Closing();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Grad();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Dilation();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Erosion();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void binarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (image != null)
            {

                Color curColor;
                int ret;

                for (int iX = 0; iX < image.Width; iX++)
                {

                    for (int iY = 0; iY < image.Height; iY++)
                    {
                        curColor = image.GetPixel(iX, iY);

                        ret = (int)(curColor.R * 0.299 + curColor.G * 0.578 + curColor.B * 0.114);

                        if (ret > 120)
                            ret = 255;
                        else
                            ret = 0;

                        image.SetPixel(iX, iY, Color.FromArgb(ret, ret, ret));
                    }
                }
                Invalidate();
                pictureBox1.Image = image;
            }
        }

        private void inversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void arifmtecsToolStripMenuItem_Click(object sender, EventArgs e)
        {

             Bitmap bmp = new Bitmap(pictureBox1.Image);
             int r = 0;
             int g = 0;
             int b = 0;

             int total = 0;

             for (int x = 0; x < bmp.Width; x++)
             {
                  for (int y = 0; y < bmp.Height; y++)
                  {
                        Color c = bmp.GetPixel(x, y);

                        r += c.R;
                        g += c.G;
                        b += c.B;

                        total++;

                        r /= total;
                        g /= total;
                        b /= total;
                        int avg = (r + g + b) / 3;

                    bmp.SetPixel(255, y, Color.FromArgb(r, g, b));
                    
                }
                //pictureBox1.Image = bmp;
                bmp.SetPixel(x, 255, Color.FromArgb(r, g, b));
                
            }
            pictureBox1.Image = bmp;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

                Bitmap bt = new Bitmap(pictureBox1.Image);
                {
                    for (int y = 0; y < image.Height; y++)
                        for (int x = 0; x < image.Width; x++)
                        {
                            Color c = bt.GetPixel(x, y);

                            // int a = c.A;
                            int r = c.R;
                            int g = c.G;
                            int b = c.B;

                            int avg = (r + g + b) / 3;
                            bt.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                        }
                    pictureBox1.Image = bt;


                }
            }

        private void arifmeticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
        #endregion

        private void histToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[] arr2 = new double[256];
            int avg = image.Width * image.Height / 256;
            const float pi = 3.14f;
            const float exp = 2.71f;
            float mat = 128;
            float disp = 0.03f;
            int count = 0;

            /*foreach (int elem in arr2)
            {
                *//*float z = (count - mat) / disp;
                double tmp = (1.0 / Math.Sqrt(2.0 * pi)) * Math.Pow(exp, (-z * z / 2));*//*
                double tmp = (1.0 / disp * Math.Sqrt(2.0 * pi)) * Math.Pow(exp, (-(count - mat) * (count - mat) / 2*disp*disp));

                chart1.Series[0].Points.AddXY(count, tmp);
                count++;
            }*/

            float[] arr = Uniform(image.Width * image.Height);

            foreach (int elem in arr)
            {
                chart1.Series[0].Points.AddXY(count, elem);
                count++;
            }
        }

        #region gauss_noise
        private void gaussToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap res = (Bitmap)image.Clone();
            var rnd = new Random();
            int noisePower = 80;

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = res.GetPixel(x, y);
                    var noise = (rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() - 2) * noisePower;
                    Color newColor = Color.FromArgb(clamp(color.R + (int)noise, 0, 255),
                                                    clamp(color.G + (int)noise, 0, 255),
                                                    clamp(color.B + (int)noise, 0, 255));
                    res.SetPixel(x, y, newColor);
                }

            prevImage = image;
            image = res;
            pictureBox1.Image = image;
            pictureBox1.Refresh();
            pictureBox2.Image = prevImage;
            pictureBox2.Refresh();
        }
        #endregion

        #region uniform
        public float[] Uniform(int size)
        {
            double a = 20;
            double b = 120;

            var uniform = new float[256];
            float sum = 0f;

            for (int i = 0; i < 256; i++)
            {
                float step = i;
                if (step >= a && step <= b)
                    uniform[i] = (1 / (float)(b - a));
                else
                    uniform[i] = 0;

                sum += uniform[i];
            }

            for (int i = 0; i < 256; i++)
            {
                uniform[i] /= sum;
                uniform[i] *= size;
                uniform[i] = (int)Math.Floor(uniform[i]);
            }

            return uniform;
        }
        protected byte[] ComputeNoise(float[] uniform, int size)
        {
            Random random = new Random();
            int count = 0;
            var noise = new byte[size];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < (int)uniform[i]; j++)
                    noise[j + count] = (byte)i;

                count += (int)uniform[i];
            }

            for (int i = 0; i < size - count; i++)
                noise[count + i] = 0;

            noise = noise.OrderBy(x => random.Next()).ToArray();
            return noise;
        }

        public Bitmap CalculateBitmap(Bitmap sourceImage, float[] uniform)
        {
            int size = sourceImage.Width * sourceImage.Height;

            var noise = ComputeNoise(uniform, size);

            var resImage = new Bitmap(sourceImage);

            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);
                    var newValue = clamp(GetBrightness(color) +
                    noise[sourceImage.Width * y + x], 0, 255);

                    resImage.SetPixel(x, y, Color.FromArgb(newValue, newValue, newValue));
                }
            return resImage;
        }
        private static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
        private void равномерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap result = CalculateBitmap(image, Uniform(image.Width * image.Height));
            prevImage = image;
            image = result;
            pictureBox1.Image = result;
            pictureBox1.Refresh();
            pictureBox2.Image = prevImage;
            pictureBox2.Refresh();
        }
        #endregion

        #region bilateral
        public Bitmap BilaterialExecute(Bitmap source)
        {
            Bitmap resultimage = new Bitmap(source);
            int radius = 1;
            int sigma = 2;
            int size = 2 * radius + 1;
            float[,] kernel = new float[size, size];
            float norm = 0;
            for (int i = -radius; i <= radius; i++)
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i) / 2 * (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;

            for (int y = 0; y < source.Height; y++)
                for (int x = 0; x < source.Width; x++)
                {
                    Color Color = NewPixelColorBilaterial(source, kernel, x, y);
                    resultimage.SetPixel(x, y, Color);
                }
            return resultimage;
        }
        public Color NewPixelColorBilaterial(Bitmap source, float[,] kernel, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float res = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, source.Width - 1);
                    int idY = clamp(y + l, 0, source.Height - 1);
                    Color neighborColor = source.GetPixel(idX, idY);
                    res += neighborColor.R * kernel[k + radiusX, l + radiusY];
                }
            return Color.FromArgb(clamp((int)res, 0, 255),
                                 clamp((int)res, 0, 255),
                                 clamp((int)res, 0, 255));
        }

        private void билатеральныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap result = BilaterialExecute(image);
            image = result;
            pictureBox1.Image = image;
        }

        #endregion

        #region gauss_median
        private void гауссToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Gauss();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Median();
            backgroundWorker1.RunWorkerAsync(filter);
        }
        #endregion

        #region niblack
        int binClamp(int val, int level)
        {
            int resVal = 0;
            int maxVal = 255;
            if (val >= level) return maxVal;
            return resVal;
        }
        private void ниблэкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int m_size = 3;
            int T = 0;
            double k = 0.2;
            double sig = 0;
            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                {
                    int radX = m_size / 2;
                    int radY = m_size / 2;
                    double new_color = 0;

                    for (int a = -radY; a <= radY; a++)
                        for (int b = -radX; b <= radX; b++)
                        {
                            int idX = clamp(i + b, 0, image.Width - 1);
                            int idY = clamp(j + a, 0, image.Height - 1);
                            Color neibCol = image.GetPixel(idX, idY);
                            new_color += neibCol.G;
                        }

                    new_color = new_color / (m_size * m_size);

                    for (int a = -radY; a <= radY; a++)
                        for (int b = -radX; b <= radX; b++)
                        {
                            int idX = clamp(i + b, 0, image.Width - 1);
                            int idY = clamp(j + a, 0, image.Height - 1);
                            Color neibCol = image.GetPixel(idX, idY);
                            sig += (neibCol.G - new_color) * (neibCol.G - new_color);
                        }

                    sig = Math.Sqrt(sig / (m_size * m_size));

                    T = (int)(new_color + k * sig);
                }
            
            Bitmap temp = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                {
                    Color sourceCol2 = image.GetPixel(i, j);
                    Color resultCol = Color.FromArgb((int)(binClamp((int)(0.299 * sourceCol2.R + 0.587 * sourceCol2.G + 0.114 * sourceCol2.B), T)),
                                                     (int)(binClamp((int)(0.299 * sourceCol2.R + 0.587 * sourceCol2.G + 0.114 * sourceCol2.B), T)),
                                                     (int)(binClamp((int)(0.299 * sourceCol2.R + 0.587 * sourceCol2.G + 0.114 * sourceCol2.B), T)));
                    temp.SetPixel(i, j, resultCol);
                }

            pictureBox1.Image = temp;
            pictureBox1.Refresh();
        }
        #endregion

        #region global
        public int[] CalculateHistogram(Bitmap image)
        {
            int[] hist = new int[256];

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);
                    hist[color.R]++;
                }
            return hist;
        }

        public Bitmap GlobalGist(Bitmap sourceImage)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap resImage = new Bitmap(width, height);

            int[] hist = CalculateHistogram(sourceImage);

            int histSum = hist.Sum();
            int cut = (int)(histSum * 0.05);

            for (int i = 0; i < 255; i++)
            {
                if (hist[i] < cut)
                {
                    cut -= hist[i];
                    hist[i] = 0;
                }

                if (cut <= 0) break;
            }

            cut = (int)(histSum * 0.05);

            for (int i = 255; i < 0; i--)
            {
                if (hist[i] < cut)
                {
                    cut -= hist[i];
                    hist[i] = 0;
                }

                if (cut <= 0) break;
            }

            int t = 0;

            int weight = 0;
            for (int i = 0; i < 255; i++)
            {
                if (hist[i] == 0) continue;

                weight += hist[i] * i;
            }

            t = (int)(weight / hist.Sum());

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color color = sourceImage.GetPixel(x, y);
                    if (color.R >= t) resImage.SetPixel(x, y, Color.White);
                    else resImage.SetPixel(x, y, Color.Black);
                }
            return resImage;
        }

        private void глобальнаяПоГистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap result = GlobalGist(image);
            pictureBox1.Image = result;
            pictureBox1.Refresh();
        }
        #endregion

        #region PSNR_SSIM
        private void pSNRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PSNR filter = new PSNR();
            if (ImageIsNull()) return;
            Cursor.Current = Cursors.WaitCursor;
            MessageBox.Show(PSNR.Execute((Bitmap)pictureBox1.Image, (Bitmap)pictureBox2.Image).ToString());
            Cursor.Current = Cursors.Default;
        }

        private void sSIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SSIM filter = new SSIM();
            if (ImageIsNull()) return;
            Cursor.Current = Cursors.WaitCursor;
            MessageBox.Show(SSIM.Execute((Bitmap)pictureBox1.Image, (Bitmap)pictureBox2.Image).ToString());
            Cursor.Current = Cursors.Default;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region other2

        private void grayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(pictureBox1.Image);
            {
                for (int y = 0; y < image.Height; y++)
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color c = bt.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;

                        int avg = (r + g + b) / 3;
                        bt.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    }
                pictureBox1.Image = bt;
            }
        }
        private void autoToolStripMenuItem_Click(object sender, EventArgs e)   
        {
                double rmax = image.GetPixel(0, 0).R;
                double gmax = image.GetPixel(0, 0).G;
                double bmax = image.GetPixel(0, 0).B;

                double rmin = image.GetPixel(0, 0).R;
                double gmin = image.GetPixel(0, 0).G;
                double bmin = image.GetPixel(0, 0).B;

                image3 = new Bitmap(image.Width, image.Height);

                for (int i = 0; i < image.Width; i++)
                    for (int j = 0; j < image.Height; j++)
                    {
                        Color tmp = image.GetPixel(i, j);
                        if (tmp.R > rmax)
                            rmax = tmp.R;
                        if (tmp.G > gmax)
                            gmax = tmp.G;
                        if (tmp.B > bmax)
                            bmax = tmp.B;

                        if (tmp.R < rmin)
                            rmin = tmp.R;
                        if (tmp.G < gmin)
                            gmin = tmp.G;
                        if (tmp.B < bmin)
                            bmin = tmp.B;
                    }

                for (int i = 0; i < image.Width; i++)
                    for (int j = 0; j < image.Height; j++)
                    {
                        Color tmp = image.GetPixel(i, j);
                        image3.SetPixel(i, j, Color.FromArgb((int)((tmp.R - rmin) / (rmax - rmin) * 255.0),
                                                         (int)((tmp.G - gmin) / (gmax - gmin) * 255.0),     
                                                         (int)((tmp.B - bmin) / (bmax - bmin) * 255.0)));                               
                    }
                pictureBox1.Image = image3;
                pictureBox1.Refresh();

        }

        private IntPtr pointer, pointer2;

        public Form1()
        {
            InitializeComponent();
        }

        //dropdown table
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = null;
                // image.Dispose();
                image = new Bitmap(dialog.FileName);
                image2 = new Bitmap(image.Width, image.Height);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }

        }

        //inersion filter
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        //blur filter
        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filter filter = new Median();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        //waves filter
        private void wavesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filter filter = new Waves();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        //download stop 
        private void button1_Click(object sender, EventArgs e) 
        { 
            backgroundWorker1.CancelAsync(); 
        }
        #region background
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filter)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }



        #endregion


        //convert
        private void button2_Click(object sender, EventArgs e)
        {
        }

        //back load
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Gamma filter
        private void button3_Click(object sender, EventArgs e)
        {
        }

        //Sobel filter
        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            ImageData2 = image2.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            buffer = new byte[ImageData.Stride * image.Height];
            buffer2 = new byte[ImageData.Stride * image.Height];
            pointer = ImageData.Scan0;
            pointer2 = ImageData2.Scan0;
            Marshal.Copy(pointer, buffer, 0, buffer.Length);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width * 3; x += 3)
                {
                    r_x = g_x = b_x = 0;
                    r_y = g_y = b_y = 0;
                    location = x + y * ImageData.Stride;
                    for (int yy = -(int)Math.Floor(weights_y.GetLength(0) / 2.0d), yyy = 0; yy <= (int)Math.Floor(weights_y.GetLength(0) / 2.0d); yy++, yyy++)
                    {
                        if (y + yy >= 0 && y + yy < image.Height)
                        {
                            for (int xx = -(int)Math.Floor(weights_x.GetLength(1) / 2.0d) * 3, xxx = 0; xx <= (int)Math.Floor(weights_x.GetLength(1) / 2.0d) * 3; xx += 3, xxx++)
                            {
                                if (x + xx >= 0 && x + xx <= image.Width * 3 - 3)
                                {
                                    location2 = x + xx + (yy + y) * ImageData.Stride;
                                    weight_x = weights_x[yyy, xxx];
                                    weight_y = weights_y[yyy, xxx];

                                    b_x += buffer[location2] * weight_x;
                                    g_x += buffer[location2 + 1] * weight_x;
                                    r_x += buffer[location2 + 2] * weight_x;
                                    b_y += buffer[location2] * weight_y;
                                    g_y += buffer[location2 + 1] * weight_y;
                                    r_y += buffer[location2 + 2] * weight_y;
                                }
                            }
                        }
                    }
                    b = (int)Math.Sqrt(Math.Pow(b_x, 2) + Math.Pow(b_y, 2));
                    g = (int)Math.Sqrt(Math.Pow(g_x, 2) + Math.Pow(g_y, 2));
                    r = (int)Math.Sqrt(Math.Pow(r_x, 2) + Math.Pow(r_y, 2));

                    if (b > 255) b = 255;
                    if (g > 255) g = 255;
                    if (r > 255) r = 255;


                    grayscale = (b + g + r) / 3;


                    buffer2[location] = (byte)grayscale;
                    buffer2[location + 1] = (byte)grayscale;
                    buffer2[location + 2] = (byte)grayscale;
                }
            }
            Marshal.Copy(buffer2, 0, pointer2, buffer.Length);
            image.UnlockBits(ImageData);
            image2.UnlockBits(ImageData2);
            pictureBox1.Image = image2;
        }
        #endregion
    }
}
