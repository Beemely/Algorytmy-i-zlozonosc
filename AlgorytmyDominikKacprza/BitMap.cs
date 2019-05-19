using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorytmyDominikKacprza
{
    class BitMap
    {
        public void KolorujMape(Bitmap Obrazek)
        {

            for (int x = 0; x < Obrazek.Width; x++)
            {

                for (int y = 0; y < Obrazek.Height; y++)
                {

                    Color odczytaniePixel = Obrazek.GetPixel(x, y);

                    if (odczytaniePixel.R < 15)
                    {
                        odczytaniePixel = Color.DarkBlue;
                    }
                    else if (odczytaniePixel.R < 40)
                    {
                        odczytaniePixel = Color.Blue;
                    }
                    else if (odczytaniePixel.R < 80)
                    {
                        odczytaniePixel = Color.Wheat;
                    }
                    else if (odczytaniePixel.R < 100)
                    {
                        odczytaniePixel = Color.Olive;
                    }
                    else if (odczytaniePixel.R < 150)
                    {
                        odczytaniePixel = Color.DarkOliveGreen;
                    }
                    else if (odczytaniePixel.R < 200)
                    {
                        odczytaniePixel = Color.Silver;
                    }
                    else odczytaniePixel = Color.White;

                    Obrazek.SetPixel(x, y, odczytaniePixel);
                }
            }
        }

        public void OdwrocKolory(Bitmap obrazek)
        {
            /*PaintEventArgs e = new PaintEventArgs(obrazek, );
            ImageAttributes imageAttributes = new ImageAttributes();
            int width = obrazek.Width;
            int height = obrazek.Height;
            float degrees = 60f;
            double r = degrees * System.Math.PI / 180; // degrees to radians

            float[][] colorMatrixElements = {
            new float[] {(float)System.Math.Cos(r),  (float)System.Math.Sin(r),  0,  0, 0},
            new float[] {(float)-System.Math.Sin(r),  (float)-System.Math.Cos(r),  0,  0, 0},
            new float[] {0,  0,  2,  0, 0},
            new float[] {0,  0,  0,  1, 0},
            new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
               colorMatrix,
               ColorMatrixFlag.Default,
               ColorAdjustType.Bitmap);

            e.Graphics.DrawImage(obrazek, 10, 10, width, height);

            e.Graphics.DrawImage(
               obrazek,
               new Rectangle(150, 10, width, height),  // destination rectangle 
                0, 0,        // upper-left corner of source rectangle 
                width,       // width of source rectangle
                height,      // height of source rectangle
                GraphicsUnit.Pixel,
               imageAttributes);*/
        }


    }
}


                
            
    

