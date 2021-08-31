using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Editor.Classes
{
    class Operacoes_Aritmeticas
    {
        // Funções para calculo dos valores de Pixel. 03 Sobrecargas
        private static void Maior_Menor_Pixel(Bitmap Imagem01_Temp, Bitmap Imagem02_Temp, int Tipo_Operacao, ref int Maior, ref int Menor)
        {   
            // Sobrecarga 1 - Operação com 2 imagens
            // 0 - Adição
            // 1 - Subtração
            Color Cor_Imagem01, Cor_Imagem02;
            double r, g, b;

            Cor_Imagem01 = Imagem01_Temp.GetPixel(0, 0);
            Maior = Cor_Imagem01.R;
            Menor = Cor_Imagem01.R;

            if (Tipo_Operacao == 0) // Adição entre imagens
            {
                for (int x = 0; x < Imagem01_Temp.Width; x++)
                {
                    for (int y = 0; y < Imagem01_Temp.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        Cor_Imagem02 = Imagem02_Temp.GetPixel(x, y);
                        r = Cor_Imagem01.R + Cor_Imagem02.R;
                        g = Cor_Imagem01.G + Cor_Imagem02.G;
                        b = Cor_Imagem01.B + Cor_Imagem02.B;

                        if (r > Maior)
                            Maior = Convert.ToInt32(r);
                        else if (g > Maior)
                            Maior = Convert.ToInt32(g);
                        else if (b > Maior)
                            Maior = Convert.ToInt32(b);
                        else if (r < Menor)
                            Menor = Convert.ToInt32(r);
                        else if (g < Menor)
                            Menor = Convert.ToInt32(g);
                        else if (b < Menor)
                            Menor = Convert.ToInt32(b);
                    }
                }
            }
            else if (Tipo_Operacao == 1) // Subtração entre imagens
            {
                for (int x = 0; x < Imagem01_Temp.Width; x++)
                {
                    for (int y = 0; y < Imagem01_Temp.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        Cor_Imagem02 = Imagem02_Temp.GetPixel(x, y);
                        r = Cor_Imagem01.R - Cor_Imagem02.R;
                        g = Cor_Imagem01.G - Cor_Imagem02.G;
                        b = Cor_Imagem01.B - Cor_Imagem02.B;

                        if (r > Maior)
                            Maior = (int)r;
                        else if (g > Maior)
                            Maior = (int)g;
                        else if (b > Maior)
                            Maior = (int)b;
                        else if (r < Menor)
                            Menor = (int)r;
                        else if (g < Menor)
                            Menor = (int)g;
                        else if (b < Menor)
                            Menor = (int)b;
                    }
                }
            }

        }
        private static void Maior_Menor_Pixel(Bitmap Imagem01_Temp, int Valor_Constante, int Tipo_Operacao, ref int Maior, ref int Menor)
        {
            Color cor;
            double r, g, b;

            cor = Imagem01_Temp.GetPixel(0, 0);
            Maior = cor.R;
            Menor = cor.R;

            if (Tipo_Operacao == 1) // Adição com constantes
            {
                for (int x = 0; x < Imagem01_Temp.Width; x++)
                {
                    for (int y = 0; y < Imagem01_Temp.Height; y++)
                    {
                        cor = Imagem01_Temp.GetPixel(x, y);
                        r = cor.R + Valor_Constante;
                        g = cor.G + Valor_Constante;
                        b = cor.B + Valor_Constante;

                        if (r > Maior)
                            Maior = (int)r;
                        else if (g > Maior)
                            Maior = (int)g;
                        else if (b > Maior)
                            Maior = (int)b;
                        else if (r < Menor)
                            Menor = (int)r;
                        else if (g < Menor)
                            Menor = (int)g;
                        else if (b < Menor)
                            Menor = (int)b;
                    }
                }
            }
            if (Tipo_Operacao == 2) // Subtração com constantes
            {
                for (int x = 0; x < Imagem01_Temp.Width; x++)
                {
                    for (int y = 0; y < Imagem01_Temp.Height; y++)
                    {
                        cor = Imagem01_Temp.GetPixel(x, y);
                        r = cor.R - Valor_Constante;
                        g = cor.G - Valor_Constante;
                        b = cor.B - Valor_Constante;

                        if (r > Maior)
                            Maior = (int)r;
                        else if (g > Maior)
                            Maior = (int)g;
                        else if (b > Maior)
                            Maior = (int)b;
                        else if (r < Menor)
                            Menor = (int)r;
                        else if (g < Menor)
                            Menor = (int)g;
                        else if (b < Menor)
                            Menor = (int)b;
                    }
                }
            }
        }
        private static void Maior_Menor_Pixel(Bitmap bitmaptemp, int op, ref int Maior, ref int Menor)
        {
            Color cor;
            int r, g, b;

            cor = bitmaptemp.GetPixel(0, 0);
            Maior = cor.R;
            Menor = cor.R;

            if (op == 5)
            {
                for (int x = 0; x < bitmaptemp.Width; x++)
                {
                    for (int y = 0; y < bitmaptemp.Height; y++)
                    {
                        cor = bitmaptemp.GetPixel(x, y);
                        r = cor.R;
                        g = cor.G;
                        b = cor.B;

                        if (r > Maior)
                            Maior = r;
                        else if (g > Maior)
                            Maior = g;
                        else if (b > Maior)
                            Maior = b;
                        else if (r < Menor)
                            Menor = r;
                        else if (g < Menor)
                            Menor = g;
                        else if (b < Menor)
                            Menor = b;
                    }
                }
            }
        }

        // Função para o calculo da soma da imagem
        public static int Calcula_Soma(int Cor, int Tipo_Correcao, int Maior, int Menor)
        {
            float Flutuante01, Flutuante02, Resultado, Flutuante03;
            //CORREÇÃO "0" INDICA TRUNCAMENTO 0-255
            if (Tipo_Correcao == 0)
            {
                if (Cor > 255)
                    return 255;

                if (Cor < 0)
                    return 0;

                return Cor;
            }
            //CORREÇÃO "1" INDICA NORMALIZAÇÃO
            else
            {
                Flutuante01 = (Maior - Menor);
                Flutuante02 = 255 / Flutuante01;
                Flutuante03 = (Cor - Menor);
                Resultado = Flutuante02 * Flutuante03;
                return Convert.ToInt32(Resultado);
            }

        }

        // Função para a manipulação da imagem. Soma entre imagens ou constantes
        public static Bitmap ConverteSoma(Image image1, Image image2, int Tipo_Correcao, int Imagem_Constante, int valorConstante)
        {

            Bitmap bitmap1 = new Bitmap(image1);
            Bitmap bitmap2 = new Bitmap(image2);

            FastBitmap fastBitmap1 = new FastBitmap(bitmap1);

            Bitmap bitmaptemp1 = new Bitmap(image1);
            Bitmap bitmaptemp2 = new Bitmap(image2);

            Color cor1, cor2, color;
            int r, g, b, Maior = 0, Menor = 0;

            //VERIFICA O TIPO DE CORREÇÃO, CASO FOR 1 ELE PRECISARÁ DOS VALORES DE MAX E MIN FUTURAMENTE, ENTÃO ESTES VALORES SÃO ENCONTRADOS AQUI NO INÍCIO.
            if (Tipo_Correcao == 1)
            {
                if (Imagem_Constante == 0)
                    Maior_Menor_Pixel(bitmaptemp1, bitmaptemp2, 0, ref Maior, ref Menor);//O MÉTODO QUE ENCONTRARÁ MAX E MIN CASO A OPERAÇÃO SEJA ENTRE DUAS IMAGENS
                else
                    Maior_Menor_Pixel(bitmaptemp1, valorConstante, 1, ref Maior, ref Menor);//O MÉTODO QUE ENCONTRARÁ MAX E MIN CASO A OPERAÇÃO SEJA COM UM VALOR CONSTANTE

            }

            fastBitmap1.Lock();

            if (Imagem_Constante == 0)
            {
                //ARGUMENTOS PARA OPERAÇÃO ENTRE IMAGENS
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    for (int y = 0; y < bitmap1.Height; y++)
                    {
                        cor1 = bitmaptemp1.GetPixel(x, y);
                        cor2 = bitmaptemp2.GetPixel(x, y);

                        r = Calcula_Soma(cor1.R + cor2.R, Tipo_Correcao, Maior, Menor);
                        g = Calcula_Soma(cor1.G + cor2.G, Tipo_Correcao, Maior, Menor);
                        b = Calcula_Soma(cor1.B + cor2.B, Tipo_Correcao, Maior, Menor);

                        color = Color.FromArgb(cor1.A, r, g, b);

                        fastBitmap1.SetPixel(x, y, color);
                    }
                }
            }
            else if (Imagem_Constante == 1)
            {
                //ARGUMENTOS PARA OPERAÇÃO COM UM VALOR CONSTANTE
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    for (int y = 0; y < bitmap1.Height; y++)
                    {
                        cor1 = bitmaptemp1.GetPixel(x, y);
                        cor2 = bitmaptemp2.GetPixel(x, y);

                        r = Calcula_Soma(cor1.R + valorConstante, Tipo_Correcao, Maior, Menor);
                        g = Calcula_Soma(cor1.G + valorConstante, Tipo_Correcao, Maior, Menor);
                        b = Calcula_Soma(cor1.B + valorConstante, Tipo_Correcao, Maior, Menor);

                        color = Color.FromArgb(cor1.A, r, g, b);

                        fastBitmap1.SetPixel(x, y, color);
                    }
                }
            }

            bitmaptemp1.Dispose();
            fastBitmap1.Unlock();
            return bitmap1;


        }

        private static int Calculo_Sub(int cor, int tipoCorrecao, int max, int min)
        {
            float virgula, virgula2, resultado, virgula3;

            //CORREÇÃO "0" INDICA TRUNCAMENTO 0-255
            if (tipoCorrecao == 0)
            {
                if (cor > 255)
                    return 255;

                if (cor < 0)
                    return 0;

                return cor;
            }
            //CORREÇÃO "1" INDICA NORMALIZAÇÃO
            else
            {
                virgula = (max - min);
                virgula2 = 255 / virgula;
                virgula3 = (cor - min);
                resultado = virgula2 * virgula3;
                return Convert.ToInt32(resultado);
            }
        }

        public static Bitmap ConverteSubtracao(Image Imagem01, Image Imagem02, int TipoCorrecao, int Imagem_Constante, int Valor_Constante)
        {

            Bitmap Imagem01_B = new Bitmap(Imagem01);
            Bitmap Imagem02_B = new Bitmap(Imagem02);

            FastBitmap fastBitmap1 = new FastBitmap(Imagem01_B);

            Bitmap Imagem01_Temp = new Bitmap(Imagem01);
            Bitmap Imagem02_Temp = new Bitmap(Imagem02);

            Color Cor_Imagem01, Cor_Imagem02, Cor_Final;
            int r, g, b, max = 0, min = 0;

            //VERIFICA O TIPO DE CORREÇÃO, CASO FOR 1 ELE PRECISARÁ DOS VALORES DE MAX E MIN FUTURAMENTE, ENTÃO ESTES VALORES SÃO ENCONTRADOS AQUI NO INÍCIO.
            if (TipoCorrecao == 1) // Se tipo de correção for normalização / Média
            {
                if (Imagem_Constante == 0) // Se subtração entre imagens
                {
                    Maior_Menor_Pixel(Imagem01_Temp, Imagem02_Temp, 1, ref max, ref min);//O MÉTODO QUE ENCONTRARÁ MAX E MIN CASO A OPERAÇÃO SEJA ENTRE DUAS IMAGENS
                }
                else
                    Maior_Menor_Pixel(Imagem01_Temp, Valor_Constante, 0, ref max, ref min);//O MÉTODO QUE ENCONTRARÁ MAX E MIN CASO A OPERAÇÃO SEJA COM UM VALOR CONSTANTE

            }

            fastBitmap1.Lock();

            if (Imagem_Constante == 0)
            {
                //ARGUMENTOS PARA OPERAÇÃO ENTRE IMAGENS
                for (int x = 0; x < Imagem01_B.Width; x++)
                {
                    for (int y = 0; y < Imagem01_B.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        Cor_Imagem02 = Imagem02_Temp.GetPixel(x, y);

                        r = Calculo_Sub(Cor_Imagem01.R - Cor_Imagem02.R, TipoCorrecao, max, min);
                        g = Calculo_Sub(Cor_Imagem01.G - Cor_Imagem02.G, TipoCorrecao, max, min);
                        b = Calculo_Sub(Cor_Imagem01.B - Cor_Imagem02.B, TipoCorrecao, max, min);

                        Cor_Final = Color.FromArgb(Cor_Imagem01.A, r, g, b);

                        fastBitmap1.SetPixel(x, y, Cor_Final);
                    }
                }
            }
            else if (Imagem_Constante == 1)
            {
                //ARGUMENTOS PARA OPERAÇÃO COM UM VALOR CONSTANTE
                for (int x = 0; x < Imagem01_B.Width; x++)
                {
                    for (int y = 0; y < Imagem01_B.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);


                        r = Calculo_Sub(Cor_Imagem01.R - Valor_Constante, TipoCorrecao, max, min);
                        g = Calculo_Sub(Cor_Imagem01.G - Valor_Constante, TipoCorrecao, max, min);
                        b = Calculo_Sub(Cor_Imagem01.B - Valor_Constante, TipoCorrecao, max, min);

                        Cor_Final = Color.FromArgb(Cor_Imagem01.A, r, g, b);

                        fastBitmap1.SetPixel(x, y, Cor_Final);
                    }
                }
            }

            Imagem01_Temp.Dispose();
            fastBitmap1.Unlock();
            return Imagem01_B;


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


    }
}