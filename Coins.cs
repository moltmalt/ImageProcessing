using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace CoinsActivity
{
    public class Circles
    {
        public class Circle
        {
            public Point CenterPoint { get; set; }
            public float Radius { get; set; }
            public Circle(Point centerPoint, float radius)
            {
                CenterPoint = centerPoint;
                Radius = radius;
            }
        }

        public static List<Circle> Detect(PictureBox pictureBox, double minDist = 30, double param1 = 150, double param2 = 50, int minRadius = 10, int maxRadius = 100)
        {
            Bitmap image = new Bitmap(pictureBox.Image);
            List<Circle> detectedCircles = new List<Circle>();
            using (Mat grayImage = new Mat())
            using (Mat sourceImage = BitmapToMat(image))
            {
                CvInvoke.CvtColor(sourceImage, grayImage, ColorConversion.Bgr2Gray);
                CvInvoke.GaussianBlur(grayImage, grayImage, new Size(5, 5), 1.5);
                CircleF[] circles = CvInvoke.HoughCircles(grayImage, HoughModes.Gradient, 1, minDist, param1, param2, minRadius, maxRadius);

                foreach (CircleF circle in circles)
                {
                    detectedCircles.Add(new Circle(
                        new Point((int)circle.Center.X, (int)circle.Center.Y),
                        circle.Radius
                    ));

                    CvInvoke.Circle(sourceImage, new Point((int)circle.Center.X, (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(255, 165, 0), 4);

                    // draw radius text
                    string radiusValue = circle.Radius.ToString("F1");
                    int[] textOffset = new int[1];
                    Size radiusTextSize = CvInvoke.GetTextSize(radiusValue, FontFace.HersheyTriplex, 1.0, 4, ref textOffset[0]);
                    Point textPosition = new Point((int)(circle.Center.X - radiusTextSize.Width / 2), (int)(circle.Center.Y - radiusTextSize.Height / 2 - 10));
                    CvInvoke.PutText(sourceImage, radiusValue, textPosition, FontFace.HersheyTriplex, 1.0, new MCvScalar(255, 99, 71), 4);


                }

                pictureBox.Image = MatToBitmap(sourceImage);
            }

            return detectedCircles;
        }


        private static Mat BitmapToMat(Bitmap bitmap)
        {
            Mat mat = new Mat();
            using (Bitmap tempBitmap = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb))
            {
                string tempFilePath = Path.GetTempFileName();
                tempBitmap.Save(tempFilePath, ImageFormat.Bmp);
                mat = CvInvoke.Imread(tempFilePath, ImreadModes.Color);
                File.Delete(tempFilePath);
            }
            return mat;
        }

        private static Bitmap MatToBitmap(Mat mat)
        {
            return mat.ToBitmap();
        }
    }
}