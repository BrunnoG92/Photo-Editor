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
            else if (Tipo_Operacao == 2) // Multiplicação entre imagens
            {

                for (int x = 0; x < Imagem01_Temp.Width; x++)
                {
                    for (int y = 0; y < Imagem01_Temp.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        Cor_Imagem02 = Imagem02_Temp.GetPixel(x, y);
                        r = Cor_Imagem01.R * Cor_Imagem02.R;
                        g = Cor_Imagem01.G * Cor_Imagem02.G;
                        b = Cor_Imagem01.B * Cor_Imagem02.B;

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
            else if (Tipo_Operacao == 3)  // Divisão entre imagens
            {
                for (int x = 0; x < Imagem01_Temp.Width; x++)
                {
                    for (int y = 0; y < Imagem01_Temp.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        Cor_Imagem02 = Imagem02_Temp.GetPixel(x, y);
                        r = Cor_Imagem01.R / Cor_Imagem02.R;
                        g = Cor_Imagem01.G / Cor_Imagem02.G;
                        b = Cor_Imagem01.B / Cor_Imagem02.B;

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

        }
        private static void Maior_Menor_Pixel(Bitmap Imagem01_Temp, int Valor_Constante, int Tipo_Operacao, ref int Maior, ref int Menor)
        {
            Color Cor_Imagem01;
            double r, g, b;

            Cor_Imagem01 = Imagem01_Temp.GetPixel(0, 0);
            Maior = Cor_Imagem01.R;
            Menor = Cor_Imagem01.R;

            if (Tipo_Operacao == 1) // Adição com constantes
            {
                for (int x = 0; x < Imagem01_Temp.Width; x++)
                {
                    for (int y = 0; y < Imagem01_Temp.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        r = Cor_Imagem01.R + Valor_Constante;
                        g = Cor_Imagem01.G + Valor_Constante;
                        b = Cor_Imagem01.B + Valor_Constante;

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
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        r = Cor_Imagem01.R - Valor_Constante;
                        g = Cor_Imagem01.G - Valor_Constante;
                        b = Cor_Imagem01.B - Valor_Constante;

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
            if (Tipo_Operacao == 3) // Multiplicação com constantes
            {
                for (int x = 0; x < Imagem01_Temp.Width; x++)
                {
                    for (int y = 0; y < Imagem01_Temp.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        r = Cor_Imagem01.R * (Valor_Constante * 0.01);
                        g = Cor_Imagem01.G * (Valor_Constante * 0.01);
                        b = Cor_Imagem01.B * (Valor_Constante * 0.01);

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
            if (Tipo_Operacao == 4) // Divisão com constantes
            {
                for (int x = 0; x < Imagem01_Temp.Width; x++)
                {
                    for (int y = 0; y < Imagem01_Temp.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        r = Cor_Imagem01.R * (1 + Valor_Constante * 0.01);
                        g = Cor_Imagem01.G * (1 + Valor_Constante * 0.01);
                        b = Cor_Imagem01.B * (1 + Valor_Constante * 0.01);

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



        }
        private static void Maior_Menor_Pixel(Bitmap bitmaptemp, int Tipo_Operacao, ref int Maior, ref int Menor)
        {
            Color cor;
            int r, g, b;

            cor = bitmaptemp.GetPixel(0, 0);
            Maior = cor.R;
            Menor = cor.R;

            if (Tipo_Operacao == 5)
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
            float Diferenca_Maior_Menor, Divida_Branco, Resultado, Diferenca_Cor;
            //CORREÇÃO "0" SERÁ FEITO O TRUNCAMENTO (0 OU 255)
            if (Tipo_Correcao == 0)
            {
                if (Cor > 255)
                    return 255;

                if (Cor < 0)
                    return 0;

                return Cor;
            }
            //CORREÇÃO "1" SERÁ FEITA A NORMALIZAÇÃO DOS PIXELS
            else
            {
                Diferenca_Maior_Menor = (Maior - Menor);
                Divida_Branco = 255 / Diferenca_Maior_Menor;
                Diferenca_Cor = (Cor - Menor);
                Resultado = Divida_Branco * Diferenca_Cor;
                return Convert.ToInt32(Resultado);
            }

        }

        // Função para a manipulação da imagem. Soma entre imagens ou constantes
        public static Bitmap ConverteSoma(Image image1, Image image2, int Tipo_Correcao, int Imagem_Constante, int valorConstante)
        {

            Bitmap Imagem1 = new Bitmap(image1);
            Bitmap Imagem2 = new Bitmap(image2);

            FastBitmap fastImagem1 = new FastBitmap(Imagem1);

            Bitmap Imagem01_Temp = new Bitmap(image1);
            Bitmap Imagem02_Temp = new Bitmap(image2);

            Color cor1, cor2, color;
            int r, g, b, Maior = 0, Menor = 0;

            //VERIFICA O TIPO DE CORREÇÃO SELECIONADO. A CORREÇÃO 1 (NORMALIZAÇÃO) EXIGE QUE OS VALORES MAIOR E MENOR DOS PIXEIS SEJAM JA ENCONTRADOS PREVIAMENTE, O QUE É FEITO AQUI
            if (Tipo_Correcao == 1)
            {
                if (Imagem_Constante == 0)
                    Maior_Menor_Pixel(Imagem01_Temp, Imagem02_Temp, 0, ref Maior, ref Menor);//METODO PARA ENCONTRAR O VALOR MAIOR E MENOR PIXEL EM OPERAÇÕES COM DUAS IMAGENS
                else
                    Maior_Menor_Pixel(Imagem01_Temp, valorConstante, 1, ref Maior, ref Menor);//METODO PARA ENCONTRAR O VALOR MAIOR E MENOR PIXEL EM OPERAÇÕES COM VALORES CONSTANTES

            }

            fastImagem1.Lock();

            if (Imagem_Constante == 0)
            {
                //OPERAÇÃO ENTRE IMAGENS
                for (int x = 0; x < Imagem1.Width; x++)
                {
                    for (int y = 0; y < Imagem1.Height; y++)
                    {
                        cor1 = Imagem01_Temp.GetPixel(x, y);
                        cor2 = Imagem02_Temp.GetPixel(x, y);

                        r = Calcula_Soma(cor1.R + cor2.R, Tipo_Correcao, Maior, Menor);
                        g = Calcula_Soma(cor1.G + cor2.G, Tipo_Correcao, Maior, Menor);
                        b = Calcula_Soma(cor1.B + cor2.B, Tipo_Correcao, Maior, Menor);

                        color = Color.FromArgb(cor1.A, r, g, b);

                        fastImagem1.SetPixel(x, y, color);
                    }
                }
            }
            else if (Imagem_Constante == 1)
            {
                //OPERAÇÃO ENTRE CONSTANTES
                for (int x = 0; x < Imagem1.Width; x++)
                {
                    for (int y = 0; y < Imagem1.Height; y++)
                    {
                        cor1 = Imagem01_Temp.GetPixel(x, y);
                        cor2 = Imagem02_Temp.GetPixel(x, y);

                        r = Calcula_Soma(cor1.R + valorConstante, Tipo_Correcao, Maior, Menor);
                        g = Calcula_Soma(cor1.G + valorConstante, Tipo_Correcao, Maior, Menor);
                        b = Calcula_Soma(cor1.B + valorConstante, Tipo_Correcao, Maior, Menor);

                        color = Color.FromArgb(cor1.A, r, g, b);

                        fastImagem1.SetPixel(x, y, color);
                    }
                }
            }

            Imagem01_Temp.Dispose();
            fastImagem1.Unlock();
            return Imagem1;


        }

        private static int Calculo_Sub(int cor, int tipoCorrecao, int max, int min)
        {
            float Diferenca_Maior_Menor, Divida_Branco, Resultado, Diferenca_Cor;

            //CORREÇÃO "0" SERÁ FEITO O TRUNCAMENTO (0 OU 255)
            if (tipoCorrecao == 0)
            {
                if (cor > 255)
                    return 255;

                if (cor < 0)
                    return 0;

                return cor;
            }
            //CORREÇÃO "1" SERÁ FEITA A NORMALIZAÇÃO DOS PIXELS
            else
            {
                Diferenca_Maior_Menor = (max - min);
                Divida_Branco = 255 / Diferenca_Maior_Menor;
                Diferenca_Cor = (cor - min);
                Resultado = Divida_Branco * Diferenca_Cor;
                return Convert.ToInt32(Resultado);
            }
        }

        public static Bitmap ConverteSubtracao(Image Imagem01, Image Imagem02, int TipoCorrecao, int Imagem_Constante, int Valor_Constante)
        {

            Bitmap Imagem01_B = new Bitmap(Imagem01);
            Bitmap Imagem02_B = new Bitmap(Imagem02);

            FastBitmap fastImagem1 = new FastBitmap(Imagem01_B);

            Bitmap Imagem01_Temp = new Bitmap(Imagem01);
            Bitmap Imagem02_Temp = new Bitmap(Imagem02);

            Color Cor_Imagem01, Cor_Imagem02, Cor_Final;
            int r, g, b, max = 0, min = 0;

            //VERIFICA O TIPO DE CORREÇÃO SELECIONADO. A CORREÇÃO 1 (NORMALIZAÇÃO) EXIGE QUE OS VALORES MAIOR E MENOR DOS PIXEIS SEJAM JA ENCONTRADOS PREVIAMENTE, O QUE É FEITO AQUI
            if (TipoCorrecao == 1) // Se tipo de correção for normalização / Média
            {
                if (Imagem_Constante == 0) // Se subtração entre imagens
                {
                    Maior_Menor_Pixel(Imagem01_Temp, Imagem02_Temp, 1, ref max, ref min);//METODO PARA ENCONTRAR O VALOR MAIOR E MENOR PIXEL EM OPERAÇÕES COM DUAS IMAGENS
                }
                else
                    Maior_Menor_Pixel(Imagem01_Temp, Valor_Constante, 0, ref max, ref min);//METODO PARA ENCONTRAR O VALOR MAIOR E MENOR PIXEL EM OPERAÇÕES COM VALORES CONSTANTES

            }

            fastImagem1.Lock();

            if (Imagem_Constante == 0)
            {
                //OPERAÇÃO ENTRE IMAGENS
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

                        fastImagem1.SetPixel(x, y, Cor_Final);
                    }
                }
            }
            else if (Imagem_Constante == 1)
            {
                //OPERAÇÃO ENTRE CONSTANTES
                for (int x = 0; x < Imagem01_B.Width; x++)
                {
                    for (int y = 0; y < Imagem01_B.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);


                        r = Calculo_Sub(Cor_Imagem01.R - Valor_Constante, TipoCorrecao, max, min);
                        g = Calculo_Sub(Cor_Imagem01.G - Valor_Constante, TipoCorrecao, max, min);
                        b = Calculo_Sub(Cor_Imagem01.B - Valor_Constante, TipoCorrecao, max, min);

                        Cor_Final = Color.FromArgb(Cor_Imagem01.A, r, g, b);

                        fastImagem1.SetPixel(x, y, Cor_Final);
                    }
                }
            }

            Imagem01_Temp.Dispose();
            fastImagem1.Unlock();
            return Imagem01_B;


        }

        private static int Calcula_Multi_Constante(int Cor_Imagem, int Multiplica_Valor, int TipoCorrecao, int Maior, int Menor) // Calculo a multiplicação com constantes
        {
            double Resultado_Const;
            float Valor_Mult, Diferenca_Maior_Menor, Divida_Branco, Resultado_Norm, MenorCor;

            //CORREÇÃO "0" SERÁ FEITO O TRUNCAMENTO (0 OU 255)
            if (TipoCorrecao == 0)
            {
                Resultado_Const = Cor_Imagem * (1 + Multiplica_Valor * 0.01);

                if (Resultado_Const > 255)
                    return 255;

                if (Resultado_Const < 0)
                    return 0;

                return Convert.ToInt32(Resultado_Const);
            }
            //CORREÇÃO "1" SERÁ FEITA A NORMALIZAÇÃO DOS PIXELS
            else
            {
                Valor_Mult = Cor_Imagem * (1 + Multiplica_Valor * 0.01f);
                Diferenca_Maior_Menor = (Maior - Menor);
                Divida_Branco = 255 / Diferenca_Maior_Menor;
                MenorCor = (Valor_Mult - Menor);
                Resultado_Norm = Divida_Branco * MenorCor;
                return Convert.ToInt32(Resultado_Norm);
            }
        }
        private static int Calcula_Multi_Imagens(int Cor_Imagem01, int Cor_Imagem02, int TipoCorrecao, int Maior, int Menor)
        {
            double Valor_Mult_Trunca;
            float Valor_Mult_Norma, Diferenca_Maior_Menor, Divida_Branco, Valor_Mult_Normal, MenorCor;

            //CORREÇÃO "0" SERÁ FEITO O TRUNCAMENTO (0 OU 255)
            if (TipoCorrecao == 0)
            {
                Valor_Mult_Trunca = Cor_Imagem01 * Cor_Imagem02;

                if (Valor_Mult_Trunca > 255)
                    return 255;

                if (Valor_Mult_Trunca < 0)
                    return 0;

                return Convert.ToInt32(Valor_Mult_Trunca);
            }
            //CORREÇÃO "1" SERÁ FEITA A NORMALIZAÇÃO DOS PIXELS
            else
            {
                Valor_Mult_Norma = Cor_Imagem01 * Cor_Imagem02;
                Diferenca_Maior_Menor = (Maior - Menor);
                Divida_Branco = 255 / Diferenca_Maior_Menor;
                MenorCor = (Valor_Mult_Norma - Menor);
                Valor_Mult_Normal = Divida_Branco * MenorCor;
                return Convert.ToInt32(Valor_Mult_Normal);
            }
        }
        public static Bitmap ConverteMultiplicacao(Image Imagem01, Image Imagem02, int Valor_Constante, int TipoCorrecao, int Imagem_Constante)
        {

            Bitmap Imagem1 = new Bitmap(Imagem01);
            Bitmap Imagem2 = new Bitmap(Imagem02);

            FastBitmap fastImagem1 = new FastBitmap(Imagem1);

            Bitmap Imagem01_Temp = new Bitmap(Imagem01);
            Bitmap Imagem02_Temp = new Bitmap(Imagem02);

            Color cor1, cor2, color;
            int r, g, b, max = 0, min = 0;

            //VERIFICA O TIPO DE CORREÇÃO SELECIONADO. A CORREÇÃO 1 (NORMALIZAÇÃO) EXIGE QUE OS VALORES MAIOR E MENOR DOS PIXEIS SEJAM JA ENCONTRADOS PREVIAMENTE, O QUE É FEITO AQUI

            if (TipoCorrecao == 1) // Normalização / Média
            {
                if (Imagem_Constante == 0) // entre imagens
                {
                    Maior_Menor_Pixel(Imagem01_Temp, Imagem02_Temp, 2, ref max, ref min);//METODO PARA ENCONTRAR O VALOR MAIOR E MENOR PIXEL EM OPERAÇÕES COM DUAS IMAGENS

                }
                else
                    Maior_Menor_Pixel(Imagem01_Temp, Valor_Constante, 3, ref max, ref min); ;//METODO PARA ENCONTRAR O VALOR MAIOR E MENOR PIXEL EM OPERAÇÕES COM VALORES CONSTANTES
            }

            fastImagem1.Lock();

            if (Imagem_Constante == 1)
            {
                for (int x = 0; x < Imagem1.Width; x++)
                {
                    for (int y = 0; y < Imagem1.Height; y++)
                    {
                        cor1 = Imagem01_Temp.GetPixel(x, y);

                        r = Calcula_Multi_Constante(cor1.R, Valor_Constante, TipoCorrecao, max, min);
                        g = Calcula_Multi_Constante(cor1.G, Valor_Constante, TipoCorrecao, max, min);
                        b = Calcula_Multi_Constante(cor1.B, Valor_Constante, TipoCorrecao, max, min);

                        color = Color.FromArgb(cor1.A, r, g, b);

                        fastImagem1.SetPixel(x, y, color);
                    }
                }
            }
            else
            {
                for (int x = 0; x < Imagem1.Width; x++)
                {
                    for (int y = 0; y < Imagem1.Height; y++)
                    {
                        cor1 = Imagem01_Temp.GetPixel(x, y);
                        cor2 = Imagem02_Temp.GetPixel(x, y);

                        r = Calcula_Multi_Imagens(cor1.R, cor2.R, TipoCorrecao, max, min);
                        g = Calcula_Multi_Imagens(cor1.G, cor2.G, TipoCorrecao, max, min);
                        b = Calcula_Multi_Imagens(cor1.B, cor2.B, TipoCorrecao, max, min);

                        color = Color.FromArgb(cor1.A, r, g, b);

                        fastImagem1.SetPixel(x, y, color);
                    }
                }
            }

            Imagem01_Temp.Dispose();
            fastImagem1.Unlock();
            return Imagem1;


        }
        private static int Calcula_Div_Constante(int Cor_Imagem, int Divide_Valor, int TipoCorrecao, int Maior, int Menor)
        {
            double Resultado_Constante;
            float Valor_Div, Diferenca_Maior_menor, Divide_Branco, Resultado_Div, Menor_Cor;

            //CORREÇÃO "0" INDICA TRUNCAMENTO 0-255
            if (TipoCorrecao == 0)
            {
                Resultado_Constante = Cor_Imagem * (Divide_Valor * 0.01);

                if (Resultado_Constante > 255)
                    return 255;

                if (Resultado_Constante < 0)
                    return 0;

                return Convert.ToInt32(Resultado_Constante);
            }
            else
            //CORREÇÃO "1" INDICA NORMALIZAÇÃO
            {
                Valor_Div = Cor_Imagem * (Divide_Valor * 0.01f);
                Diferenca_Maior_menor = (Maior - Menor);
                Divide_Branco = 255 / Diferenca_Maior_menor;
                Menor_Cor = (Valor_Div - Menor);
                Resultado_Div = Divide_Branco * Menor_Cor;
                return Convert.ToInt32(Resultado_Div);


            }

        }
        private static int Calcula_Div_Imagens(int Cor_Imagem01, int Cor_Imagem02, int TipoCorrecao, int Maior, int Menor)
        {
            double Divisao_Trunca, DividaZero;
            float Divisao_Normal, Diferenca_Maior_Menor, Divide_Branco, Resultado, Menor_Cor, Divide_Cor_Imagem01, Divide_Cor_Imagem02;

            Divide_Cor_Imagem01 = Cor_Imagem01 / 255;
            Divide_Cor_Imagem02 = Cor_Imagem02 / 255;
            //CORREÇÃO "0" SERÁ FEITO O TRUNCAMENTO (0 OU 255)
            if (TipoCorrecao == 0)
            {
                if (Divide_Cor_Imagem02 == 0)
                {
                    DividaZero = 0.0001;
                    Divisao_Trunca = Divide_Cor_Imagem01 / DividaZero;
                }
                else
                    Divisao_Trunca = Divide_Cor_Imagem01 / Divide_Cor_Imagem02;

                if (Divisao_Trunca > 255)
                    return 255;

                if (Divisao_Trunca < 0)
                    return 0;

                return Convert.ToInt32(Divisao_Trunca);
            }
            //CORREÇÃO "1" SERÁ FEITA A NORMALIZAÇÃO DOS PIXELS
            else
            {
                Divisao_Normal = Divide_Cor_Imagem01 / Divide_Cor_Imagem02;
                Diferenca_Maior_Menor = (Maior - Menor);
                Divide_Branco = 255 / Diferenca_Maior_Menor;
                Menor_Cor = (Divisao_Normal - Menor);
                Resultado = Divide_Branco * Menor_Cor;
                return (int)(Resultado);
            }
        }
        private static int Truncar_0_ou_255(double cor)
        {
            if (cor > 255) return 255;
            if (cor < 0) return 0;

            return (int)cor;
        }
        public static Bitmap ConverteDivisao(Image Imagem01, Image Imagem02, int Valor_Constante, int TipoCorrecao, int Imagem_Constante)
        {
            Bitmap Imagem1 = new Bitmap(Imagem01);
            Bitmap Imagem2 = new Bitmap(Imagem02);

            FastBitmap fastImagem1 = new FastBitmap(Imagem1);

            Bitmap Imagem01_Temp = new Bitmap(Imagem01);
            Bitmap Imagem02_Temp = new Bitmap(Imagem02);

            Color Cor_Imagem01, Cor_Imagem02, Cor_Final;
            int r, g, b, Maior = 0, Menor = 0;

            //VERIFICA O TIPO DE CORREÇÃO SELECIONADO. A CORREÇÃO 1 (NORMALIZAÇÃO) EXIGE QUE OS VALORES MAIOR E MENOR DOS PIXEIS SEJAM JA ENCONTRADOS PREVIAMENTE, O QUE É FEITO AQUI
            if (TipoCorrecao == 1)
            {
                if (Imagem_Constante == 0)
                {
                    Maior_Menor_Pixel(Imagem01_Temp, Imagem02_Temp, 3, ref Maior, ref Menor);//METODO PARA ENCONTRAR O VALOR MAIOR E MENOR PIXEL EM OPERAÇÕES COM DUAS IMAGENS
                }
                else
                    Maior_Menor_Pixel(Imagem01_Temp, Valor_Constante, 4, ref Maior, ref Menor);//METODO PARA ENCONTRAR O VALOR MAIOR E MENOR PIXEL EM OPERAÇÕES COM VALORES CONSTANTES
            }

            fastImagem1.Lock();

            if (Imagem_Constante == 1) // se entre constantes
            {
                for (int x = 0; x < Imagem1.Width; x++)
                {
                    for (int y = 0; y < Imagem1.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);

                        r = Calcula_Div_Constante(Cor_Imagem01.R, Valor_Constante, TipoCorrecao, Maior, Menor);
                        g = Calcula_Div_Constante(Cor_Imagem01.G, Valor_Constante, TipoCorrecao, Maior, Menor);
                        b = Calcula_Div_Constante(Cor_Imagem01.B, Valor_Constante, TipoCorrecao, Maior, Menor);

                        Cor_Final = Color.FromArgb(Cor_Imagem01.A, r, g, b);

                        fastImagem1.SetPixel(x, y, Cor_Final);
                    }
                }
            }
            else if (Imagem_Constante == 0) //se entre imagens
            {
                for (int x = 0; x < Imagem1.Width; x++)
                {
                    for (int y = 0; y < Imagem1.Height; y++)
                    {
                        Cor_Imagem01 = Imagem01_Temp.GetPixel(x, y);
                        Cor_Imagem02 = Imagem02_Temp.GetPixel(x, y);

                        r = Calcula_Div_Imagens(Cor_Imagem01.R, Cor_Imagem02.R, TipoCorrecao, Maior, Menor);
                        g = Calcula_Div_Imagens(Cor_Imagem01.G, Cor_Imagem02.G, TipoCorrecao, Maior, Menor);
                        b = Calcula_Div_Imagens(Cor_Imagem01.B, Cor_Imagem02.B, TipoCorrecao, Maior, Menor);

                        r = Convert.ToInt32(Truncar_0_ou_255(100.0 * ((Cor_Imagem01.R / 255.0) / ((Cor_Imagem02.R == 0 ? 0.0001 : Cor_Imagem02.R) / 255))));
                        g = Convert.ToInt32(Truncar_0_ou_255(100.0 * ((Cor_Imagem01.R / 255.0) / ((Cor_Imagem02.R == 0 ? 0.0001 : Cor_Imagem02.R) / 255))));
                        b = Convert.ToInt32(Truncar_0_ou_255(100.0 * ((Cor_Imagem01.R / 255.0) / ((Cor_Imagem02.R == 0 ? 0.0001 : Cor_Imagem02.R) / 255))));

                        Cor_Final = Color.FromArgb(Cor_Imagem01.A, r, g, b);

                        fastImagem1.SetPixel(x, y, Cor_Final);
                    }
                }
            }

            Imagem01_Temp.Dispose();
            fastImagem1.Unlock();
            return Imagem1;

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