using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Editor.Classes
{
    class Operacoes_Booleanas
    {
        public static Bitmap ConverteBoolAND(Image Imagem01, Image Imagem02)
        {
            try
            {
                Bitmap Imagem1 = new Bitmap(Imagem01);
                Bitmap Imagem2 = new Bitmap(Imagem02);

                FastBitmap fastBitmap1 = new FastBitmap(Imagem1);

                Bitmap Imagem01_Temp = new Bitmap(Imagem01);
                Bitmap Imagem02_Temp = new Bitmap(Imagem02);

                Color Cor_Imagem01, Cor_Imagem02, Cor_Final;

                fastBitmap1.Lock();

                for (int x = 0; x < Imagem1.Width; x++)
                {
                    for (int y = 0; y < Imagem1.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        Cor_Imagem02 = Imagem02_Temp.GetPixel(x, y);
                        Cor_Final = Color.FromArgb(Cor_Imagem01.R & Cor_Imagem02.R, Cor_Imagem01.G & Cor_Imagem02.G, Cor_Imagem01.B & Cor_Imagem02.B);

                        fastBitmap1.SetPixel(x, y, Cor_Final);
                    }
                }

                Imagem01_Temp.Dispose();
                fastBitmap1.Unlock();
                return Imagem1;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
