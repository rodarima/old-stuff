using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace images
{
    class fn
    {
        public Bitmap pat_fail, pat_corr;
        public double comp(Bitmap _bitmap, Bitmap _patronBitmap, double _ratio)     //Compara dos imagenes por su brillo y devuelve el valor ej 0.323
        {
            pat_corr = null;
            pat_fail = null;
            pat_fail = new Bitmap(_patronBitmap.Width, _patronBitmap.Height);
            pat_corr = new Bitmap(_patronBitmap.Width, _patronBitmap.Height);
            double similitud=0;
            double sem = 0, pix = 0;
            for (int __x = 0; __x < _bitmap.Width; __x++)
            {
                for (int __y = 0; __y < _bitmap.Height; __y++)
                {
                    double bp = _patronBitmap.GetPixel(__x, __y).A;
                    double b2 = _bitmap.GetPixel(__x, __y).A;

                    if (Math.Abs(bp - b2) / 256 < _ratio)
                    {

                        sem++;
                        pat_fail.SetPixel(__x, __y, Color.White);
                        pat_corr.SetPixel(__x, __y, Color.Green);
                    }
                    else
                    {
                        pat_fail.SetPixel(__x, __y, Color.Red);
                        pat_corr.SetPixel(__x, __y, Color.White);
                        //MessageBox.Show("d");
                    }
                    pix++;
                }
            }
            //pat_f.Image = pat_fail;
            //pat_ok.Image = pat_corr;
            similitud = sem / pix;
            return similitud;
            //coinc.Text = similitud.ToString();

        }
        public Bitmap rec(Bitmap _bitmap)                                           //Quita bordes vacíos de un Bitmap y devuelve el bitmap recortado
        {
            

            double brillo = 0;
            double rango_max = 0.5;
            int ini_x = 0, ini_y = 0, fin_x = 0, fin_y = 0;
            for (int x = 0; x < _bitmap.Width; x++)
            {
                for (int y = 0; y < _bitmap.Height; y++)
                {
                    brillo = _bitmap.GetPixel(x, y).GetBrightness();
                    if (brillo < rango_max) //si el pixel esta escrito (negro)
                    {
                        if (ini_x == 0)
                        {
                            ini_x = x; // asigna la primera coincidencia a ini_x
                        }
                        if (x > fin_x)
                        {
                            fin_x = x; // asigna la ultima coincidencia a ini_x
                        }

                    }
                }
            }
            fin_x = fin_x - ini_x + 1;
            for (int y = 0; y < _bitmap.Height; y++)
            {
                for (int x = 0; x < _bitmap.Width; x++)
                {
                    brillo = _bitmap.GetPixel(x, y).GetBrightness();
                    if (brillo < rango_max) //si el pixel esta escrito (negro)
                    {
                        if (ini_y == 0)
                        {
                            ini_y = y; // asigna la primera coincidencia a ini_y
                        }
                        if (y > fin_y)
                        {
                            fin_y = y; // asigna la ultima coincidencia a fin_y
                        }
                    }
                }
            }
            fin_y = fin_y - ini_y + 1;
            //MessageBox.Show(ini_x.ToString() + " " + ini_y.ToString() + " " + img1.GetPixel(ini_x, ini_y).GetBrightness().ToString());

            Bitmap img_temp = new Bitmap(fin_x, fin_y);
            Graphics lienzo = Graphics.FromImage(img_temp);
            Rectangle recorte = new Rectangle(ini_x - 1, ini_y, fin_x, fin_y);
            lienzo.DrawImage(_bitmap, 0, 0, recorte, GraphicsUnit.Pixel);
            return img_temp;

        }
        public Bitmap blur(Bitmap image, int _ratio)                                //Suaviza una imagen, y devuelve el bitmap suavizado
        {
            Int32 blurSize = _ratio;
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            Rectangle rectangle = new Rectangle(0, 0, image.Width, image.Height);
            // look at every pixel in the blur rectangle
            for (Int32 xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (Int32 yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    Int32 avgR = 0, avgG = 0, avgB = 0;
                    Int32 blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (Int32 x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (Int32 y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (Int32 x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                        for (Int32 y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }                                                          
        public Bitmap contrast(Bitmap Image, float Value)                           //Aumenta o reduce el contraste, y devuelve el bitmap resultante
        {
            Value = (100.0f + Value) / 100.0f;
            Value *= Value;
            Bitmap NewBitmap = (Bitmap)Image.Clone();
            BitmapData data = NewBitmap.LockBits(
                new Rectangle(0, 0, NewBitmap.Width, NewBitmap.Height),
                ImageLockMode.ReadWrite,
                NewBitmap.PixelFormat);

            unsafe
            {
                for (int y = 0; y < NewBitmap.Height; ++y)
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for (int x = 0; x < NewBitmap.Width; ++x)
                    {
                        byte B = row[columnOffset];
                        byte G = row[columnOffset + 1];
                        byte R = row[columnOffset + 2];

                        float Red = R / 255.0f;
                        float Green = G / 255.0f;
                        float Blue = B / 255.0f;
                        Red = (((Red - 0.5f) * Value) + 0.5f) * 255.0f;
                        Green = (((Green - 0.5f) * Value) + 0.5f) * 255.0f;
                        Blue = (((Blue - 0.5f) * Value) + 0.5f) * 255.0f;

                        int iR = (int)Red;
                        iR = iR > 255 ? 255 : iR;
                        iR = iR < 0 ? 0 : iR;
                        int iG = (int)Green;
                        iG = iG > 255 ? 255 : iG;
                        iG = iG < 0 ? 0 : iG;
                        int iB = (int)Blue;
                        iB = iB > 255 ? 255 : iB;
                        iB = iB < 0 ? 0 : iB;

                        row[columnOffset] = (byte)iB;
                        row[columnOffset + 1] = (byte)iG;
                        row[columnOffset + 2] = (byte)iR;

                        columnOffset += 4;
                    }
                }
            }

            NewBitmap.UnlockBits(data);

            return NewBitmap;
        }
        public Bitmap sobel_x(Bitmap b)                                             //Aplica el metodo Sobel para calcular la derivada horizontal
        {
            int[,] gx = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };   //  The matrix Gx
            //Bitmap b2 = new Bitmap(b);
            Bitmap b1 = new Bitmap(b);
            Graphics gImage = Graphics.FromImage(b1);
            gImage.DrawRectangle(Pens.Gray, 0, 0, b1.Width-1, b1.Height-1);
            for (int i = 1; i < b.Height - 1; i++)   // loop for the image pixels height
            {
                for (int j = 1; j < b.Width - 1; j++) // loop for image pixels width    
                {
                    float new_x = 0;
                    float c;
                    for (int hw = -1; hw < 2; hw++)  //loop for cov matrix
                    {
                        for (int wi = -1; wi < 2; wi++)
                        {
                            float cc = b.GetPixel(j + wi, i + hw).GetBrightness();
                            c = (b.GetPixel(j + wi, i + hw).A);
                            new_x += gx[hw + 1, wi + 1] * c;
                        }
                    }
                    if (new_x > 0)
                    {
                        int alfa = 4 * Convert.ToInt32(Math.Pow(new_x, 0.5));
                        b1.SetPixel(j, i, Color.FromArgb(127 + alfa, Color.Black));
                    }
                    else
                    {
                        int alfa = 4 * Convert.ToInt32(Math.Pow(Math.Abs(new_x), 0.5));
                        b1.SetPixel(j, i, Color.FromArgb(128 - alfa, Color.Black));
                    }

                }
            }
            return (Bitmap)b1;
        }
        public Bitmap sobel_y(Bitmap b)
        {
            int[,] gy = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };  //  The matrix Gy
            Bitmap b1 = new Bitmap(b);
            //Graphics gImage = Graphics.FromImage(b1);
            //gImage.DrawRectangle(Pens.Gray, 0, 0, b1.Width, b1.Height);
            /*b1.SetPixel(0, 0, Color.Gray);
            b1.SetPixel(0, b1.Height, Color.Gray);
            b1.SetPixel(b1.Width, 0, Color.Gray);
            b1.SetPixel(b1.Width, b1.Height, Color.Gray);
            */
            for (int i = 1; i < b.Height - 1; i++)   // loop for the image pixels height
            {
                for (int j = 1; j < b.Width - 1; j++) // loop for image pixels width    
                {
                    float new_y = 0;
                    float c;
                    for (int hw = -1; hw < 2; hw++)  //loop for cov matrix
                    {
                        for (int wi = -1; wi < 2; wi++)
                        {
                            c = (b.GetPixel(j + wi, i + hw).A);
                            new_y += gy[hw + 1, wi + 1] * c;
                        }
                    }
                    if (new_y > 0)
                    {
                        int alfa = 4 * Convert.ToInt32(Math.Pow(new_y, 0.5));
                        b1.SetPixel(j, i, Color.FromArgb(127 + alfa, Color.Black));
                    }
                    else
                    {
                        int alfa = 4 * Convert.ToInt32(Math.Pow(Math.Abs(new_y), 0.5));
                        b1.SetPixel(j, i, Color.FromArgb(128 - alfa, Color.Black));
                    }
                }
            }
            return (Bitmap)b1;
        }
        public Bitmap to_bn(Bitmap b)                                               //Convierte el bitmap a tonos de gris
        {
            for (int i = 1; i < b.Height; i++)   // loop for the image pixels height
            {
                for (int j = 1; j < b.Width; j++)  // loop for the image pixels width
                {
                    Color col;
                    col = b.GetPixel(j, i);
                    b.SetPixel(j, i, Color.FromArgb((col.R + col.G + col.B) / 3, (col.R + col.G + col.B) / 3, (col.R + col.G + col.B) / 3));
                }
            }
            return (Bitmap)b;
        }
        public Bitmap resize(Bitmap b, int nWidth, int nHeight)                     //Redimensiona el bitmap segun el tamaño especificado
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            //result.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
            Graphics g = Graphics.FromImage((Image)result);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }
        public Bitmap cmpBitmap(Bitmap a, Bitmap b, double ratio)                   //Compara 2 bitmap y devuelve un bitmap con los pixeles que no coinciden
        {
            Bitmap cmp = new Bitmap(a);
            for (int _x = 0; _x < a.Width; _x++)
            {
                for (int _y = 0; _y < a.Height; _y++)
                {
                    double a_br = a.GetPixel(_x, _y).A;
                    double b_br = b.GetPixel(_x, _y).A;
                    if (Math.Abs(a_br - b_br) / 255 < ratio)
                    {
                        cmp.SetPixel(_x, _y, Color.White);
                    }
                    else
                    {
                        cmp.SetPixel(_x, _y, Color.Red);
                    }
                }
            }
            return cmp;
        }
        public double cmpDouble(Bitmap a, Bitmap b, double ratio)                   //Compara 2 bitmap y devuelve un double con la similitud 
        {
            double cmp = 0;
            for (int _x = 0; _x < a.Width; _x++)
            {
                for (int _y = 0; _y < a.Height; _y++)
                {
                    double a_br = a.GetPixel(_x, _y).A;
                    double b_br = b.GetPixel(_x, _y).A;
                    if (Math.Abs(a_br - b_br) / 255 < ratio)
                    {
                        cmp++;
                    }
                }
            }
            cmp = cmp / (a.Width * a.Height);
            return cmp;
        }
        public Bitmap alisar(Bitmap a, double ratio)                                //Convierte la imagen en funcion de alfa y el color negro
        {
            for (int _x = 0; _x < a.Width; _x++)
            {
                for (int _y = 0; _y < a.Height; _y++)
                {
                    Color c = a.GetPixel(_x, _y);
                    double n = (c.B + c.G + c.R + c.A) / 4;
                        a.SetPixel(_x, _y, Color.FromArgb(255-(int)n,Color.Black));
                }
            }
            return a;
        }

        public Bitmap[] sep(Bitmap a, int esp)                                      //Separa las palabras con un espacio de "esp"
        {
            int n_x = 0;
            int[] im_x = new int[a.Width];
            //int[] im_y = new int[a.Width];
            for (int _x = 0; _x < a.Width; _x++)
            {
                int linea = 0;
                for (int _y = 0; _y < a.Height; _y++)
                {
                    Color c = a.GetPixel(_x, _y);
                    int br = (a.GetPixel(_x, _y).R+a.GetPixel(_x, _y).G+a.GetPixel(_x, _y).B)/3;

                    if ( br > 240)
                    {
                        linea++;
                    }
                }
                if (linea >= a.Height )
                {
                    im_x[n_x] = _x;
                    n_x++;
                    
                }
            }
            im_x[n_x] = a.Width;

            int[] ancho = new int[n_x];
            int[] pos_x = new int[n_x];
            int pos =0 , espa = 0;
            for (int _esp = 0; _esp < n_x; _esp++)
            {
                if (espa == esp)
                {
                    pos_x[pos] = -1;
                    ancho[pos] = -1;
                    pos++;
                }
                else if (im_x[_esp] != im_x[_esp + 1] - 1) //si no son correlativos
                {
                    pos_x[pos] = im_x[_esp];
                    ancho[pos] = im_x[_esp + 1] - im_x[_esp];
                    pos++;
                    espa = 0;
                }
                espa++;
            }

            if (pos == 0) //Si solo hay 1 letra la devuelve sin recortar nada
            {
                Bitmap[] f = new Bitmap[1];
                f[0] = a;
                return f;
            }
            Bitmap[] b = new Bitmap[pos]; 
            

            for (int i = 0; i < pos; i++)
            {
                if (ancho[i] == -1 || pos_x[i] == -1)
                {
                    b[i] = null;
                }
                else
                {
                    Bitmap img_temp = new Bitmap(ancho[i], a.Height);
                    Graphics lienzo = Graphics.FromImage(img_temp);
                    Rectangle recorte = new Rectangle(pos_x[i], 0, ancho[i], a.Height);
                    lienzo.DrawImage(a, 0, 0, recorte, GraphicsUnit.Pixel);

                    b[i] = img_temp;
                }
            }
            
            return b; 
        }
        public Bitmap[] letras(Bitmap i)                                            //Devuelve un array con los bitmap de cada letra
        {
            i = rec(i);
            i = contrast(i,400);
            //i = alisar(i,0.1);

            return sep(i,15);
        }
    }
}
