using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using CoinsActivity;
using Emgu.CV;
using Backprop;

namespace ImageProcessing
{
    public partial class Form4 : Form
    {
        Bitmap loaded, processed, imageA, imageB, resultImage;
        NeuralNet nn;

        public Form4()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;

            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
            pictureBox2.Image = processed;
        }

        private void grayscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel, gray;
            int avg;

            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    avg = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    gray = Color.FromArgb(avg, avg, avg);
                    processed.SetPixel(x, y, gray);
                }
            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel, inv;
            int red, green, blue;

            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);

                    red = (255 - pixel.R);
                    green = (255 - pixel.G);
                    blue = (255 - pixel.B);

                    inv = Color.FromArgb(red, green, blue);
                    processed.SetPixel(x, y, inv);
                }
            pictureBox2.Image = processed;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.hist(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel, sepia;
            int red, green, blue;

            for (int x = 0; x < loaded.Width; x++)
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);

                    red = (int)((pixel.R * .393) + (pixel.G * .769) + (pixel.B * .189));
                    green = (int)((pixel.R * .349) + (pixel.G * .686) + (pixel.B * .168)); ;
                    blue = (int)((pixel.R * .272) + (pixel.G * .534) + (pixel.B * .131));

                    if (red > 255) red = 255;
                    if (green > 255) green = 255;
                    if (blue > 255) blue = 255;

                    sepia = Color.FromArgb(red, green, blue);
                    processed.SetPixel(x, y, sepia);
                }
            pictureBox2.Image = processed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog2.FileName);
            pictureBox5.Image = imageB;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog3.FileName);
            pictureBox4.Image = imageA;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(imageB.Width, imageB.Height);

            Color myGreen = Color.FromArgb(0, 0, 255);
            int grayGreen = (myGreen.R + myGreen.G + myGreen.B) / 3;
            int threshold = 5;

            for (int x = 0; x < imageB.Width; x++)
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - grayGreen);
                    if (subtractvalue < threshold)
                        resultImage.SetPixel(x, y, backpixel);
                    else
                        resultImage.SetPixel(x, y, pixel);
                }

            pictureBox3.Image = resultImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            resultImage.Save(saveFileDialog2.FileName);
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.GaussianBlur(processed, 80);
            pictureBox2.Image = processed;
        }

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.Smooth(processed, 1);
            pictureBox2.Image = processed;

        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.MeanRemoval(processed, 9);
            pictureBox2.Image = processed;
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EmbossLaplacian(processed);
            pictureBox2.Image = processed;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.Sharpen(processed, 11);
            pictureBox2.Image = processed;
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EmbossLaplacian(processed);
            pictureBox2.Image = processed;
        }

        private void horizontalVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EmbossHorzVert(processed);
            pictureBox2.Image = processed;
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EmbossAll(processed);
            pictureBox2.Image = processed;
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EmbossLossy(processed);
            pictureBox2.Image = processed;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EmbossHorizontal(processed);
            pictureBox2.Image = processed;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EmbossVertical(processed);
            pictureBox2.Image = processed;
        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.Emboss(processed);
            pictureBox2.Image = processed;
        }

        private void detectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectQuick(processed);
            pictureBox2.Image = processed;
        }

        private void enhanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded);
            BitmapFilter.EdgeEnhance(processed, 30);
            pictureBox2.Image = processed;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var coins = new Coins(
             new("c5", 0.05f), new("c10", 0.1f), new("c25", 0.25f),
             new("p1", 1f), new("p5", 5f), new("p10", 10f)
            );

            int denomination = 0;
            var circles = Circles.Detect(pictureBox6).OrderBy(c => c.Radius).ToList();

            foreach (var circle in circles)
            {
                float radius = circle.Radius;

                if (radius >= 22f && radius <= 23.99f)
                {
                    coins[0].count++; // 5c
                }
                else if (radius >= 24f && radius <= 27f)
                {
                    coins[1].count++; // 10c
                }
                else if (radius >= 28f && radius <= 34.29f)
                {
                    coins[2].count++; // 25c
                }
                else if (radius >= 34.30f && radius <= 37.0f)
                {
                    coins[3].count++; // 1 peso
                }
                else if (radius >= 38.10f && radius <= 50.0f)
                {
                    coins[4].count++; // 5 pesos
                }
            }

            showTotal(coins);
        }
        private void showTotal(Coins coins)
        {
            label10.Text = $"{coins["c5"].count}";
            label11.Text = $"{coins["c10"].count}";
            label12.Text = $"{coins["c25"].count}";
            label13.Text = $"{coins["p1"].count}";
            label14.Text = $"{coins["p5"].count}";
            label15.Text = $"{coins.GetTotal()}";
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public class Coins : List<Coin>
        {
            public Coins(params Coin[] coins) : base(coins) { }
            public Coin this[string k] => this.FirstOrDefault(c => c.Cluster == k) ?? new(k, 0);
            public float GetTotal() => this.Sum(c => c.Total);
        }

        public class Coin
        {
            public string Cluster { get; }
            public float Value { get; }
            public int count;
            public Coin(string c, float v) => (Cluster, Value) = (c, v);
            public float Total => Value * count;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, Convert.ToInt16(textBox6.Text), 1);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            int numEpochs = Convert.ToInt16(textBox7.Text);

            // Define the input combinations and corresponding AND output
            double[,] inputCombinations = new double[,]
            {
            {0, 0, 0, 0},
            {0, 0, 0, 1},
            {0, 0, 1, 0},
            {0, 0, 1, 1},
            {0, 1, 0, 0},
            {0, 1, 0, 1},
            {0, 1, 1, 0},
            {0, 1, 1, 1},
            {1, 0, 0, 0},
            {1, 0, 0, 1},
            {1, 0, 1, 0},
            {1, 0, 1, 1},
            {1, 1, 0, 0},
            {1, 1, 0, 1},
            {1, 1, 1, 0},
            {1, 1, 1, 1}
            };

            // Calculate the corresponding AND output
            double[] andOutputs = new double[inputCombinations.GetLength(0)];
            for (int i = 0; i < inputCombinations.GetLength(0); i++)
            {
                // Convert double to int for logical AND operation
                int result = 1;
                for (int j = 0; j < inputCombinations.GetLength(1); j++)
                {
                    result &= Convert.ToInt32(inputCombinations[i, j]);
                }
                andOutputs[i] = result;
            }

            // Train the neural network
            for (int epoch = 0; epoch < numEpochs; epoch++)
            {
                for (int i = 0; i < inputCombinations.GetLength(0); i++)
                {
                    nn.setInputs(0, inputCombinations[i, 0]);
                    nn.setInputs(1, inputCombinations[i, 1]);
                    nn.setInputs(2, inputCombinations[i, 2]);
                    nn.setInputs(3, inputCombinations[i, 3]);
                    nn.setDesiredOutput(0, andOutputs[i]);
                    nn.learn();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox4.Text));
            nn.setInputs(3, Convert.ToDouble(textBox3.Text));

            nn.run();

            textBox5.Text = "" + nn.getOuputData(0);
        }
    }
}
