using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Photo_Editor.Classes
{
    class Operacoes_Aritmeticas
    {
        public static Bitmap ConverteCinza(Bitmap Imagem)
        {
            int x, y;
            using (var fastBitmap = Imagem.FastLock())
            {
                for (x = 0; x < Imagem.Width; x++)
                {
                    for (y = 0; y < Imagem.Height; y++)
                    {
                        Color CorPixel = fastBitmap.GetPixel(x, y);
                        Color NovaCor = Color.FromArgb(CorPixel.R, CorPixel.R, CorPixel.R);
                        fastBitmap.SetPixel(x, y, NovaCor);

                    }
                }
            }
            return Imagem;
        }

        public static Bitmap Negativo(Bitmap Imagem)
        {
            int x, y;
            using (var fastBitmap = Imagem.FastLock())
                for (x = 0; x < Imagem.Width; x++)
                {
                    for (y = 0; y < Imagem.Height; y++)
                    {
                        Color CorPixel = fastBitmap.GetPixel(x, y);
                        Color NovaCor = Color.FromArgb(255 - CorPixel.R, 255 - CorPixel.R, 255 - CorPixel.R);
                        fastBitmap.SetPixel(x, y, NovaCor);
                    }

                }
            return Imagem;
        }
       
    }
}
