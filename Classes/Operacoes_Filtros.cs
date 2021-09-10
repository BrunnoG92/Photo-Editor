using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Editor.Classes
{
    class Operacoes_Filtros
    {
        static double Raiz = Math.Sqrt(2);

        public static double[,] LinhaHorizontal = new double[,] { { -1, -1, -1 },
                                                           {  2,  2,  2 },
                                                           { -1, -1, -1 } };

        public static double[,] LinhaVertical = new double[,] { { -1,  2, -1 },
                                                         { -1,  2, -1 },
                                                         { -1,  2, -1 } };

        public static double[,] LinhaDiagonalSuperior = new double[,] { { -1, -1,  2 },
                                                            { -1,  2, -1 },
                                                            {  2, -1, -1 } };

        public static double[,] LinhaDiagonalInferior = new double[,] { {  2, -1, -1 },
                                                            { -1,  2, -1 },
                                                            { -1, -1,  2 }};


        public static double[,] RobertsVertical = new double[,]   { { 0,  0, -1 },
                                                             { 0,  1,  0 },
                                                             { 0,  0,  0 }};

        public static double[,] RobertsHorizontal = new double[,] { { -1, 0,  0 },
                                                             {  0, 1,  0 },
                                                             {  0, 0,  0 }};

        public static double[,] SobelVertical = new double[,]     { { 1,  0, -1 },
                                                             { 2,  0, -2 },
                                                             { 1,  0, -1 }};

        public static double[,] SobelHorizontal = new double[,]   { {-1, -2, -1 },
                                                             { 0,  0,  0 },
                                                             { 1,  2,  1 }};

        public static double[,] PrewittVertical = new double[,]   { { 1,  0, -1 },
                                                             { 1,  0, -1 },
                                                             { 1,  0, -1 }};

        public static double[,] PrewittHorizontal = new double[,] { {-1, -1, -1 },
                                                             { 0,  0,  0 },
                                                             { 1,  1, -1 }};

        public static double[,] FreiChenVertical = new double[,]  { { 1,  0, -1 },
                                                             { Raiz,  0, -Raiz },
                                                             { 1,  0, -1 } };

        public static double[,] FreiChenHorizontal = new double[,] {{-1, -Raiz, -1 },
                                                             { 0,  0,  0 },
                                                             { 1,  Raiz, -1 }};

        public static double[,] Laplaciano_3 = new double[,] { {  0, -1,  0 },
                                                        { -1,  4, -1 },
                                                        {  0, -1,  0 } };

        public static double[,] Laplaciano_5 = new double[,] { { -1, -1, -1, -1, -1 },
                                                        { -1, -1, -1, -1, -1 },
                                                        { -1, -1, 24, -1, -1 },
                                                        { -1, -1, -1, -1, -1 },
                                                        { -1, -1, -1, -1, -1 }};

        public static double[,] Laplaciano_9 = new double[,] { { -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                                                        { -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                                                        { -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                                                        { -1, -1, -1,  8,  8,  8, -1, -1, -1 },
                                                        { -1, -1, -1,  8,  8,  8, -1, -1, -1 },
                                                        { -1, -1, -1,  8,  8,  8, -1, -1, -1 },
                                                        { -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                                                        { -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                                                        { -1, -1, -1, -1, -1, -1, -1, -1, -1 }};


        public static double[,] Suavi_Media_3_P_1 = new double[,] {  { 1, 1, 1 },
                                                    { 1, 1, 1 },
                                                    { 1, 1, 1 } };

        public static double[,] Suavi_Media_3_P_D = new double[,] {  { 1, 2, 1 },
                                                    { 2, 4, 2 },
                                                    { 1, 2, 1 } };

        public static double[,] Sauvi_Media_5_P_1 = new double[,] {  { 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1}};

        public static double[,] Suavi_Media_7_1 = new double[,] {  { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1}};


        public static double[,] Suavi_Mediana_3_3 = new double[,]   {{ 1, 1, 1 },
                                                                     { 1, 1, 1 },
                                                                     { 1, 1, 1 } };

        public static double[,] Suavi_Mediana_5_5 = new double[,]   { { 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1 } };


        public static double[,] Suavi_Mediana_7_7 = new double[,]   { { 1, 1, 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1, 1, 1 },
                                                                     { 1, 1, 1, 1, 1, 1, 1 } };

        public static double[,] PassaAlta3_1 = new double[,] { { -1, -1, -1 },
                                                        { -1,  8, -1 },
                                                        { -1, -1, -1 }};



        public static Bitmap Colocar_Filtro(Image Imagem01, Filtro_Paramentros Parametros) //Duas sobrecarda. Coloca Filtro Media e Mediana
        {
            Bitmap Imagem1 = new Bitmap(Imagem01);
            FastBitmap FastImagem01 = new FastBitmap(Imagem1);

            Bitmap Imagem01_Temp = new Bitmap(Imagem01);

            //---------------------------------------------------------

            int Centro_Mascara = (Parametros.filtroSize - 1) / 2;

            FastImagem01.Lock();

            for (int ImagemY = 0; ImagemY < Imagem01.Height; ImagemY++)
            {
                for (int ImagemX = 0; ImagemX < Imagem01.Width; ImagemX++)
                {
                    double r = 0;
                    double g = 0;
                    double b = 0;

                    for (int Filtro_Y = 0; Filtro_Y < Parametros.filtroSize; Filtro_Y++)
                    {
                        for (int Filtro_X = 0; Filtro_X < Parametros.filtroSize; Filtro_X++)
                        {
                            int Novo_Filtro_X = Filtro_X - Centro_Mascara;
                            int Novo_Filtro_Y = Filtro_Y - Centro_Mascara;

                            int FiltroX_Imagem = ImagemX + Novo_Filtro_X;
                            int FiltroY_Imagem = ImagemY + Novo_Filtro_Y;

                            if (FiltroX_Imagem >= 0 && FiltroX_Imagem < Imagem01_Temp.Width &&
                                FiltroY_Imagem >= 0 && FiltroY_Imagem < Imagem01_Temp.Height)
                            {
                                Color Cor_Original = Imagem01_Temp.GetPixel(FiltroX_Imagem, FiltroY_Imagem);

                                r += Cor_Original.R * Parametros.filtroMask[Filtro_Y, Filtro_X];
                                g += Cor_Original.G * Parametros.filtroMask[Filtro_Y, Filtro_X];
                                b += Cor_Original.B * Parametros.filtroMask[Filtro_Y, Filtro_X];
                            }
                        }
                    }

                    r *= Parametros.filtroMod;
                    g *= Parametros.filtroMod;
                    b *= Parametros.filtroMod;

                    Color corNovoPixel = Color.FromArgb(255, Trunca_0_255(r), Trunca_0_255(g), Trunca_0_255(b));
                    FastImagem01.SetPixel(ImagemX, ImagemY, corNovoPixel);
                }
            }

            Imagem01_Temp.Dispose();
            FastImagem01.Unlock();

            return Imagem1;
        }

        public static Bitmap Colocar_Filtro(Image Imagem01, int Tamanho, double[,] Mascara, double Filtro_Mod)
        {
            Bitmap Imagem1 = new Bitmap(Imagem01);
            FastBitmap FastImagem01 = new FastBitmap(Imagem1);
            Bitmap bitmapAux1 = new Bitmap(Imagem01);
            FastImagem01.Lock();
            int CentroMascara = (Tamanho - 1) / 2;
            Color Cor_Original = bitmapAux1.GetPixel(0, 0);
            int maiorPix = Cor_Original.R;
            int menorPix = Cor_Original.R;
            int auxvetor;
            int[] vetor = new int[Tamanho];
            for (int imagemY = 0; imagemY < Imagem01.Height; imagemY++)
            {
                for (int imagemX = 0; imagemX < Imagem01.Width; imagemX++)
                {
                    for (int filtroY = 0; filtroY < Tamanho; filtroY++)
                    {
                        for (int filtroX = 0; filtroX < Tamanho; filtroX++)
                        {
                            int filtroNovoX = filtroX - CentroMascara;
                            int filtroNovoY = filtroY - CentroMascara;
                            int filtroImagemX = imagemX + filtroNovoX;
                            int filtroImagemY = imagemY + filtroNovoY;
                            if (filtroImagemX >= 0 && filtroImagemX < bitmapAux1.Width && filtroImagemY >= 0 && filtroImagemY < bitmapAux1.Height)
                            {
                                Color corOriginal1 = bitmapAux1.GetPixel(filtroImagemX, filtroImagemY);
                                vetor[filtroX] = corOriginal1.R;
                            }
                        }
                    }

                    for (int i = 0; i < vetor.Length; i++)
                    {
                        for (int j = 0; j < vetor.Length; j++)
                        {
                            if (vetor[j] < vetor[i])
                            {
                                auxvetor = vetor[i];
                                vetor[i] = vetor[j];
                                vetor[j] = auxvetor;
                            }
                        }
                    }


                    Color corNovoPixel = Color.FromArgb(255, Trunca_0_255(vetor[(vetor.Length / 2) + 1]), Trunca_0_255(vetor[(vetor.Length / 2) + 1]), Trunca_0_255(vetor[(vetor.Length / 2) + 1]));
                    FastImagem01.SetPixel(imagemX, imagemY, corNovoPixel);
                }
            }

            FastImagem01.Unlock();

            return Imagem1;
        }
        public static int Trunca_0_255(double cor)
        {
            if (cor > 255) return 255;
            else if (cor < 0) return 0;
            else return (int)cor;
        }
    }
}

