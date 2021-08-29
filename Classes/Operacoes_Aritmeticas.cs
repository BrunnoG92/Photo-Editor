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
       
        private static void Maior_Menor_Pixel(Bitmap Imagem01, Bitmap Imagem02, int Operacao, ref int Maior, ref int Menor)
        {   // Calculo de pixel em soma entre imagems
            // Valor = 0 Adição entre imagens
            // Valor = N Adição com constantes
            // Operador 1 = Adição entre imagens
            // Operador 2 = Adição com constante
            // Operador 3 = Subtração entre imagens
            Color CorImagem01;
            Color CorImagem02;
            int x, y;
            CorImagem01 = Imagem01.GetPixel(0, 0);
            Maior = CorImagem01.R;
            Menor = CorImagem01.R;
            double r, g, b;
            if (Operacao == 1) // Se adição entre imagems
            {
                using (var fastBitmap01 = Imagem01.FastLock())
                {
                    using (var fastBitmap02 = Imagem02.FastLock())
                    {
                        for (x = 0; x < Imagem01.Width; x++)
                        {
                            for (y = 0; y < Imagem01.Height; y++)
                            {
                                CorImagem01 = fastBitmap01.GetPixel(x, y);
                                CorImagem02 = fastBitmap02.GetPixel(x, y);
                                r = CorImagem01.R + CorImagem02.R;
                                g = CorImagem01.G + CorImagem02.G;
                                b = CorImagem01.B + CorImagem02.B;
                                if (r > Maior)
                                {
                                    Maior = Convert.ToInt32(r);
                                }
                                else if (g > Maior)
                                {
                                    Maior = Convert.ToInt32(g);
                                }
                                else if (b > Maior)
                                {
                                    Maior = Convert.ToInt32(b);
                                }
                                else if (r < Menor)
                                {
                                    Maior = Convert.ToInt32(r);
                                }
                                else if (g < Menor)
                                {
                                    Maior = Convert.ToInt32(g);
                                }
                                else if (b < Menor)
                                {
                                    Maior = Convert.ToInt32(b);
                                }
                            }
                        }
                    }
                }
            }
        }
        private static int CalcularSoma(int Cor, int Correcao, int Maior, int Menor)
        {
            float flutuante1, flutuante2, flutante3, resultado;
            if (Correcao == 0)  // se trucamento
            {
                if (Cor > 255)
                {
                    return 255;
                }
                if (Cor < 0)
                {
                    return 0;
                }
                return Cor;
            }
            else // Se normalização
            {
                flutuante1 = (Maior - Menor);
                flutuante2 = 255 / flutuante1;
                flutante3 = (Cor - Menor);
                resultado = flutuante2 * flutante3;
                return Convert.ToInt32(resultado);
            }
        }
        private static void Maior_Menor_Pixel(Bitmap Imagem, int Valor, int Operacao, ref int Maior, ref int Menor)
        {   // calculo de valor de pixel em soma com constante
            Color CorImagem;
            CorImagem = Imagem.GetPixel(0, 0);
            double r, g, b;
            int x, y;
            Maior = CorImagem.R;
            Menor = CorImagem.R;
            if (Operacao == 2) // Se adição com constante
                using (var fastBitmap = Imagem.FastLock())
                {
                    for (x = 0; x < Imagem.Width; x++)
                    {
                        for (y = 0; y < Imagem.Height; y++)
                        {
                            CorImagem = fastBitmap.GetPixel(x, y);
                            r = CorImagem.R * (Valor * 0.01);
                            g = CorImagem.G * (Valor * 0.01);
                            b = CorImagem.B * (Valor * 0.01);
                            if (r > Maior)
                            {
                                Maior = Convert.ToInt32(r);
                            }
                            else if (g > Maior)
                            {
                                Maior = Convert.ToInt32(g);
                            }
                            else if (b > Maior)
                            {
                                Maior = Convert.ToInt32(b);
                            }
                            else if (r < Menor)
                            {
                                Maior = Convert.ToInt32(r);
                            }
                            else if (g < Menor)
                            {
                                Maior = Convert.ToInt32(g);
                            }
                            else if (b < Menor)
                            {
                                Maior = Convert.ToInt32(b);
                            }
                        }

                    }
                }
        }

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

        public static Bitmap PretoBranco(Bitmap Imagem)
        {
            int x, y;
            using (var fastBitmap = Imagem.FastLock())
            {
                for (x = 0; x < Imagem.Width; x++)
                {
                    for (y = 0; y < Imagem.Height; y++)
                    {
                        Color CorPixel = fastBitmap.GetPixel(x, y);
                        int NovoA = CorPixel.A;
                        int NovoR = CorPixel.R;
                        int NovoG = CorPixel.G;
                        int NovoB = CorPixel.B;
                        int Media = (NovoR + NovoG + NovoB) / 3;
                        Media = Media < Form1_Photo_Editor.Limiar ? 0 : 255; // convertendo de cinza para preto e branco
                        fastBitmap.SetPixel(x, y, Color.FromArgb(NovoA, Media, Media, Media));
                    }
                }
            }
            return Imagem;
        }

        public static Bitmap SomaImagem(Bitmap Imagem01, Bitmap Imagem02, int Correcao, int Constante_Imagem, int Valor_Constante)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            int Maior = 0;
            int Menor = 0;
            int x, y;
            Color CorImagem01;
            Color CorImagem02;
            Color CorFinal;
            Bitmap Imagem01_Temp = new Bitmap(Imagem01);
            Bitmap Imagem02_Temp = new Bitmap(Imagem02);
            FastBitmap fastBitmap01 = new FastBitmap(Imagem01);


            if (Correcao == 1)  // Normalização de pixeis 
            {
                if (Constante_Imagem == 0)  // Se é operação com imagem ou constante, 0 é imagem 1 é com constante
                {
                    Maior_Menor_Pixel(Imagem01_Temp, Imagem02_Temp, 1, ref Maior, ref Menor); // Calculo o pixel se operção entre imagens
                }
                else
                {
                    Maior_Menor_Pixel(Imagem01_Temp, Constante_Imagem, 2, ref Maior, ref Menor);// Calculo o pixel se operção com constantes
                }
            }
                fastBitmap01.Lock();
                if (Constante_Imagem == 0) // Se opereção entre imagens
                {

                    // Operação entre imagens
                    for (x = 0; x < Imagem01_Temp.Width; x++)
                    {
                        for (y = 0; y < Imagem01_Temp.Height; y++)
                        {
                            CorImagem01 = Imagem01_Temp.GetPixel(x, y);
                            CorImagem02 = Imagem02_Temp.GetPixel(x, y);
                            r = CalcularSoma(CorImagem01.R + CorImagem02.R, Correcao, Maior, Menor);
                            g = CalcularSoma(CorImagem01.G + CorImagem02.G, Correcao, Maior, Menor);
                            b = CalcularSoma(CorImagem01.B + CorImagem02.B, Correcao, Maior, Menor);
                            CorFinal = Color.FromArgb(CorImagem01.A, r, g, b);
                            fastBitmap01.SetPixel(x, y, CorFinal);
                        }
                    }
                }
                else if (Constante_Imagem == 1) // se operação com constante
                {


                    for (x = 0; x < Imagem01_Temp.Width; x++)
                    {
                        for (y = 0; y < Imagem01_Temp.Height; y++)
                        {
                           
                            CorImagem01 = Imagem01_Temp.GetPixel(x, y);
                            CorImagem02 = Imagem02_Temp.GetPixel(x, y);
                            r = CalcularSoma(CorImagem01.R + Valor_Constante, Correcao, Maior, Menor);
                            g = CalcularSoma(CorImagem01.G + Valor_Constante, Correcao, Maior, Menor);
                            b = CalcularSoma(CorImagem01.B + Valor_Constante, Correcao, Maior, Menor);
                            CorFinal = Color.FromArgb(CorImagem01.A, r, g, b);
                            fastBitmap01.SetPixel(x, y, CorFinal);
                        }
                    }
                   

                }
                
            
            Imagem01_Temp.Dispose();
            fastBitmap01.Unlock();
            return Imagem01;
        }
    }
}


