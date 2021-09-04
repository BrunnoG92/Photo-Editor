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

        public static  double[,] FreiChenVertical = new double[,]  { { 1,  0, -1 },
                                                             { Raiz,  0, -Raiz },
                                                             { 1,  0, -1 } };

        public static  double[,] FreiChenHorizontal = new double[,] {{-1, -Raiz, -1 },
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


        public static double[,] Blur3_1 = new double[,] {  { 1, 1, 1 },
                                                    { 1, 1, 1 },
                                                    { 1, 1, 1 } };

        public static double[,] Blur3_d = new double[,] {  { 1, 2, 1 },
                                                    { 2, 4, 2 },
                                                    { 1, 2, 1 } };

        public static double[,] Blur5_1 = new double[,] {  { 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1}};

        public static double[,] Blur7_1 = new double[,] {  { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1},
                                                    { 1, 1, 1, 1, 1, 1, 1}};

        public static double[,] PassaAlta3_1 = new double[,] { { -1, -1, -1 },
                                                        { -1,  8, -1 },
                                                        { -1, -1, -1 }};

        public static Bitmap Colocar_Filtro(Image Imagem01, Filtro_Paramentros Parametros)
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

        public static Bitmap Coloca_Filtro_Mediana(Image Imagem01, int Tamanho_Filtro)
        {
            Bitmap Imagem1 = new Bitmap(Imagem01);
            FastBitmap Imagem_Fast = new FastBitmap(Imagem1);

            Bitmap Imagem_Temp = new Bitmap(Imagem01);

            //---------------------------------------------------------

            int centroMask = (Tamanho_Filtro - 1) / 2;

            Color corAux = Imagem_Temp.GetPixel(0, 0);

            int[] Vetor = new int[Tamanho_Filtro];

            int Maior = corAux.R, Menor = corAux.R, aux;

            Imagem_Fast.Lock();

            for (int yImg = 0; yImg < Imagem01.Height; yImg++)
            {
                for (int xImg = 0; xImg < Imagem01.Width; xImg++)
                {

                    for (int yFiltro = 0; yFiltro < Tamanho_Filtro; yFiltro++)
                    {
                        for (int xFiltro = 0; xFiltro < Tamanho_Filtro; xFiltro++)
                        {
                            int xFiltroNovo = xFiltro - centroMask;
                            int yFiltroNovo = yFiltro - centroMask;

                            int xFiltroSobreImagem = xImg + xFiltroNovo;
                            int yFiltroSobreImagem = yImg + yFiltroNovo;

                            if (xFiltroSobreImagem >= 0 && xFiltroSobreImagem < Imagem_Temp.Width &&
                                yFiltroSobreImagem >= 0 && yFiltroSobreImagem < Imagem_Temp.Height)
                            {
                                Color corOriginal = Imagem_Temp.GetPixel(xFiltroSobreImagem, yFiltroSobreImagem);
                                Vetor[xFiltro] = corOriginal.R;
                            }
                        }
                    }

                    for (int i = 0; i < Vetor.Length; i++)
                    {
                        for (int j = i + 1; j < Vetor.Length; j++)
                        {
                            if (Vetor[j] < Vetor[i])
                            {
                                aux = Vetor[i];
                                Vetor[i] = Vetor[j];
                                Vetor[j] = aux;
                            }
                        }
                    }

                    Color corNovoPixel = Color.FromArgb(255, Trunca_0_255(Vetor[(Vetor.Length / 2) + 1]), Trunca_0_255(Vetor[(Vetor.Length / 2) + 1]), Trunca_0_255(Vetor[(Vetor.Length / 2) + 1]));
                    Imagem_Fast.SetPixel(xImg, yImg, corNovoPixel);
                }
            }

            Imagem_Temp.Dispose();
            Imagem_Fast.Unlock();

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

