using Photo_Editor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Editor
{
    public partial class Form1_Photo_Editor : Form
    {
        public static int Limiar;
        public static int CorrecaoSelecionado;
        public static int Imagem_Constante;
        public static int Operacao_Selecionada;
        public int Borda_Selecionada;
        public int Linha_Selecionada;
        public int Laplaciano;
        public int BlurValor;
        int PassaAltaValor;
        bool Sucesso_A, SucessoB, SucessoF;
        public static decimal Cinza_R, Cinza_G, Cinza_B;


        public Form1_Photo_Editor()
        {
            InitializeComponent();
            Pcb04_Carregando.Visible = false;

        }
        private void Cmbb_Correcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmbb_Correcao.SelectedIndex == 0)
            {
                CorrecaoSelecionado = 0; // Truncamento
            }
            else
            {
                CorrecaoSelecionado = 1; // Normalização/Média
            }
        }
        private void Cmbb_Imagem_Constante_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (Cmbb_Imagem_Constante.SelectedIndex == 0)
            {
                Imagem_Constante = 0;  //0 - Entre Imagens
            }
            else
            {
                Imagem_Constante = 1;  //1 - Constante
            }
        }

        private void Form1_Photo_Editor_Load(object sender, EventArgs e)
        {



        }

        private void Form1_Photo_Editor_MouseDown(object sender, MouseEventArgs e)
        {
            // evento mouse pressionado sobre a janela
            // Chamo a função de arrasto 

            if (e.Button == MouseButtons.Left)
            {
                Drag_Control.ReleaseCapture();
                Drag_Control.SendMessage(Handle, Drag_Control.WM_NCLBUTTONDOWN, Drag_Control.HT_CAPTION, 0);
            }

        }

        private void Form1_Photo_Editor_Resize(object sender, EventArgs e)
        {
            // Controlo a forma das bordas com base no tamanho da janela

            if (this.WindowState == FormWindowState.Maximized)
            {   // Janela maximizada, retiro as bordas arredondadas
                Region = System.Drawing.Region.FromHrgn(Round_Form.CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
                Invalidate();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {   // Janela restaurada, adiciono as bordas arredondadas
                Region = System.Drawing.Region.FromHrgn(Round_Form.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                Invalidate();
            }
        }

        private void Btn_Imagem01_Click(object sender, EventArgs e)
        {   // Seleciono a imagem 01
            OpenFileDialog abraFoto1 = new OpenFileDialog();
            abraFoto1.Filter = "Arquivos de Imagens (*.jpg; *.png;*.bmp) | *.jpg; *.png; *.bmp";
            if (abraFoto1.ShowDialog() == DialogResult.OK)
            {
                Pcb_01.Image = new Bitmap(abraFoto1.FileName);
            }
        }

        private void Btn_Imagem02_Click(object sender, EventArgs e)
        {   // Seleciono a imagem 02
            OpenFileDialog abraFoto2 = new OpenFileDialog();
            abraFoto2.Filter = "Arquivos de Imagens (*.jpg; *.png;*.bmp) | *.jpg; *.png; *.bmp";
            if (abraFoto2.ShowDialog() == DialogResult.OK)
            {
                Pcb_02.Image = new Bitmap(abraFoto2.FileName);
            }
        }


        private void Thread_Aritmetica_DoWork(object sender, DoWorkEventArgs e)
        {
            // Chama a função de Escala de cinza na classe Operacoes_Aritmeticas 
           
            if (Rdo_Cinza.Checked)
            {
                Bitmap ImagemCinza = new Bitmap(Pcb_01.Image);
                Operacoes_Aritmeticas.Converte_Cinza_Media(ImagemCinza);
                Thread_Aritmetica.ReportProgress(10);
                Pcb_03.Image = ImagemCinza;
            }
            else if (Rdo_Negativo.Checked == true)
            {
                Bitmap Imagem_Negativo = new Bitmap(Pcb_01.Image);
                Operacoes_Aritmeticas.Negativo(Imagem_Negativo);
                Pcb_03.Image = Imagem_Negativo;
            }
            else if (Rdo_Cinza_Co.Checked == true)
            {
                Bitmap ImagemCinzaCo = new Bitmap(Pcb_01.Image);
                Operacoes_Aritmeticas.EscalaDeCinsaCoeficienteFx(ImagemCinzaCo, Num_UpDown_Cinza_R.Value, Num_UpDown_Cinza_G.Value, Num_UpDown_Cinza_B.Value);
                Thread_Aritmetica.ReportProgress(20);
                Pcb_03.Image = ImagemCinzaCo;
            }

            else if (Rdo_PretoBranco.Checked == true)
            {
                {
                    Limiar = (int)Num_UpDown_Limiar.Value;
                    Bitmap ImagemPretoBranco = new Bitmap(Pcb_01.Image);
                    Operacoes_Aritmeticas.PretoBranco(ImagemPretoBranco);
                    Thread_Aritmetica.ReportProgress(30);
                    Pcb_03.Image = ImagemPretoBranco;
                }
            }


            else if (Operacao_Selecionada == 0) // Se soma selecionado
            {
                if (Pcb_02.Image == null)// se não selecionar imagem 02
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteSoma((Bitmap)Pcb_01.Image, (Bitmap)Pcb_01.Image, CorrecaoSelecionado, Imagem_Constante, (int)Num_UpDown_ValorOp.Value);
                    Thread_Aritmetica.ReportProgress(40);

                }
                else
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteSoma((Bitmap)Pcb_01.Image, (Bitmap)Pcb_02.Image, CorrecaoSelecionado, Imagem_Constante, (int)Num_UpDown_ValorOp.Value);
                    Thread_Aritmetica.ReportProgress(50);

                }

            }
            else if (Operacao_Selecionada == 1) // Se subtração selecionada
            {

                if (Pcb_02.Image == null)// se imagem 02 não fo r selecionada
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteSubtracao(Pcb_01.Image, Pcb_01.Image, CorrecaoSelecionado, Imagem_Constante, (int)Num_UpDown_ValorOp.Value);
                    Thread_Aritmetica.ReportProgress(60);
                }
                else
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteSubtracao(Pcb_01.Image, Pcb_02.Image, CorrecaoSelecionado, Imagem_Constante, (int)Num_UpDown_ValorOp.Value);

                }
            }
            else if (Operacao_Selecionada == 2) // Multiplicação Selecionada
            {
                if (Pcb_02.Image == null)// se imagem 02 não for selecionada
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteMultiplicacao(Pcb_01.Image, Pcb_01.Image, (int)Num_UpDown_ValorOp.Value, CorrecaoSelecionado, Imagem_Constante);
                    Thread_Aritmetica.ReportProgress(70);
                }
                else
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteMultiplicacao(Pcb_01.Image, Pcb_02.Image, (int)Num_UpDown_ValorOp.Value, CorrecaoSelecionado, Imagem_Constante);
                    Thread_Aritmetica.ReportProgress(810);
                }
            }
            else if (Operacao_Selecionada == 3) // Se divisão selecionada
            {
                if (Pcb_02.Image == null) //se não tiver uma segunda imagem selecionada
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteDivisao(Pcb_01.Image, Pcb_01.Image, (int)Num_UpDown_ValorOp.Value, CorrecaoSelecionado, Imagem_Constante);
                    Thread_Aritmetica.ReportProgress(90);
                }
                else
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteDivisao(Pcb_01.Image, Pcb_02.Image, (int)Num_UpDown_ValorOp.Value, CorrecaoSelecionado, Imagem_Constante);
                    Thread_Aritmetica.ReportProgress(99);
                }
            }
        }
        private void Thread_Aritmetica_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Pcb04_Carregando.Visible = true;
        }

        private void Btn_Aplicar_Ar_Click(object sender, EventArgs e)
        {

            // botão aplicar aritmetica chama a thread que faz os calculos aritméticos 
            if (Pcb_01.Image != null && Pcb_02.Image != null && Cmbb_Imagem_Constante.SelectedIndex == 0) // SE OPERAÇÃO ENTRE IMAGENS COM DUAS IMAGENS VALIDAS
            {
                Operacao_Selecionada = Cmbb_Operacoes.SelectedIndex;
                Cinza_R = Num_UpDown_Cinza_R.Value;
                Cinza_G = Num_UpDown_Cinza_G.Value;
                Cinza_B = Num_UpDown_Cinza_B.Value;
                Thread_Aritmetica.RunWorkerAsync();
                Btn_Aplicar_Ar.Enabled = false;
                Btn_Aplica_Bool.Enabled = false;
                Btn_Aplicar_Filtro.Enabled = false;

            }
            else if (Pcb_01.Image == null || Pcb_02.Image == null)
            {
                if (Cmbb_Imagem_Constante.SelectedIndex == 0)
                {
                    MessageBox.Show("Você deve selecionar duas imagems para aplicar um filtro entre imagens", "Erro ao aplicar filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            if (Cmbb_Imagem_Constante.SelectedIndex == 1) // SE SELECIONADO ENTRE CONSTANTES
            {
                if (Pcb_01.Image != null) // SE HÁ UMA IMAGEM VALIDA EM IMAGEM01
                {
                    Operacao_Selecionada = Cmbb_Operacoes.SelectedIndex;
                    Cinza_R = Num_UpDown_Cinza_R.Value;
                    Cinza_G = Num_UpDown_Cinza_G.Value;
                    Cinza_B = Num_UpDown_Cinza_B.Value;
                    Thread_Aritmetica.RunWorkerAsync();
                    Btn_Aplicar_Ar.Enabled = false;
                    Btn_Aplica_Bool.Enabled = false;
                    Btn_Aplicar_Filtro.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Você deve selecionar a imagem 01 para aplicar um filtro entre constantes", "Erro ao aplicar filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }



        }

        private void Thread_Aritmetica_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Pcb04_Carregando.Visible = false;
            Btn_Aplicar_Ar.Enabled = true;
            Btn_Aplica_Bool.Enabled = true;
            Btn_Aplicar_Filtro.Enabled = true;
            Rdo_Negativo.Checked = false;
            Rdo_Cinza.Checked = false;
            Rdo_PretoBranco.Checked = false;
            if (Pcb_03.Image != null)
            {
                Sucesso_A = true;
                SucessoF = false;
                SucessoB = false;
            }
            MessageBox.Show("Filtro aplicado com sucesso", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (Sucesso_A == true)
            {
                SaveFileDialog Salva_Foto = new SaveFileDialog();
                Salva_Foto.Filter = "Images|*.png;*.bmp;*.jpg";
                if (Rdo_Negativo.Checked == true)
                {
                    Salva_Foto.FileName = "Negativo.png";
                }
                else if (Rdo_Cinza.Checked == true)
                {
                    Salva_Foto.FileName = "Escala Cinza Média.png";
                }
                else if (Rdo_Cinza_Co.Checked == true)
                {
                    Salva_Foto.FileName = "Escala de Cinza Coeficiente.png";
                }
                else if (Rdo_PretoBranco.Checked == true)
                {
                    Salva_Foto.FileName = "Escala Preto e Branco.png";
                }
                else if (Cmbb_Operacoes.ContainsFocus == false) // PEGO O NOME DA OPÇÃO SELECIONADA NA COMBO BOX QUANDO ESTE PERDE O FOCO
                {
                    string Tipo = $"{this.Cmbb_Imagem_Constante.GetItemText(this.Cmbb_Imagem_Constante.SelectedItem)}";
                    string Operacao = $"{this.Cmbb_Operacoes.GetItemText(this.Cmbb_Operacoes.SelectedItem)}";
                    string NomeFinal = Operacao + " " + Tipo + ".png";
                    Salva_Foto.FileName = NomeFinal;
                }


                ImageFormat format = ImageFormat.Png;
                if (Salva_Foto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(Salva_Foto.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;

                    }
                    Pcb_03.Image.Save(Salva_Foto.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Você deve aplicar um filtro aritmético antes de salvar", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Thread_Booleana_DoWork(object sender, DoWorkEventArgs e)
        {
            
            if (Rdo_AND.Checked == true)
            {
                Pcb_03.Image = Operacoes_Booleanas.ConverteParaAND(Pcb_01.Image, Pcb_02.Image);
                Thread_Booleana.ReportProgress(20);
            }
            else if (Rdo_OR.Checked == true)
            {
                Pcb_03.Image = Operacoes_Booleanas.ConverteParaOR(Pcb_01.Image, Pcb_02.Image);
                Thread_Booleana.ReportProgress(40);
            }
            else if (Rdo_XOR.Checked == true)
            {
                Pcb_03.Image = Operacoes_Booleanas.ConverteParaXOR(Pcb_01.Image, Pcb_02.Image);
                Thread_Booleana.ReportProgress(80);
            }
        }
        private void Thread_Booleana_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Pcb_03.Visible = true;
        }
        private void Thread_Booleana_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Pcb04_Carregando.Visible = false;
            if (Pcb_03.Image != null)
            {
                SucessoB = true;
                SucessoF = false;
                Sucesso_A = false;
            }
            MessageBox.Show("Filtro Aplicado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_Aplica_Bool_Click(object sender, EventArgs e)
        {
            if(Pcb_01.Image != null && Pcb_02.Image != null) // SE OPERAÇÃO ENTRE IMAGENS COM DUAS IMAGENS VALIDAS
            {
                Thread_Booleana.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Você deve selecionar duas imagems para aplicar um filtro booleano", "Erro ao aplicar filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        

        private void Thread_Filtros_DoWork(object sender, DoWorkEventArgs e)
        {
            // APLICAÇÃO DE FILTROS DE BORDAS
           
            if (Rdo_Bordas.Checked == true)
            {
                if (Borda_Selecionada == 0)
                {
                    Thread_Filtros.ReportProgress(10);
                    Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.RobertsVertical, 1);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);

                }
                else if (Borda_Selecionada == 1)
                {
                    Thread_Filtros.ReportProgress(20);
                    Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.RobertsHorizontal, 1);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
                }
                else if (Borda_Selecionada == 2)
                {
                    Thread_Filtros.ReportProgress(30);
                    float mod = 4;
                    mod = 1 / mod;
                    Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.SobelVertical, mod);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
                }
                else if (Borda_Selecionada == 3)
                {
                    Thread_Filtros.ReportProgress(40);
                    float mod = 4;
                    mod = 1 / mod;
                    Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.SobelHorizontal, mod);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
                }
                else if (Borda_Selecionada == 4)
                {
                    Thread_Filtros.ReportProgress(50);
                    float mod = 3;
                    mod = 1 / mod;
                    Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.PrewittVertical, mod);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
                }
                else if (Borda_Selecionada == 5)
                {
                    Thread_Filtros.ReportProgress(60);
                    float mod = 3;
                    mod = 1 / mod;
                    Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.PrewittHorizontal, mod);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
                }
                else if (Borda_Selecionada == 6)
                {
                    Thread_Filtros.ReportProgress(70);
                    double raiz = Math.Sqrt(2);
                    float mod = 2 + (float)raiz;
                    mod = 1 / mod;
                    Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.FreiChenVertical, mod);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
                }
                else if (Borda_Selecionada == 7)
                {
                    Thread_Filtros.ReportProgress(90);
                    double raiz = Math.Sqrt(2);
                    float mod = 2 + (float)raiz;
                    mod = 1 / mod;
                    Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.FreiChenHorizontal, mod);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
                }

            }

            //
            // APLICAÇÃO DE FILTROS DE LINHAS
            //
            if (Rdo_Linhas.Checked == true)
            {
                if (Linha_Selecionada == 0)
                {
                    Thread_Filtros.ReportProgress(10);
                    Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros(3, Operacoes_Filtros.LinhaHorizontal, 1);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                }
                else if (Linha_Selecionada == 1)
                {
                    Thread_Filtros.ReportProgress(20);
                    Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros(3, Operacoes_Filtros.LinhaVertical, 1);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                }
                else if (Linha_Selecionada == 2)
                {
                    Thread_Filtros.ReportProgress(30);
                    Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros(3, Operacoes_Filtros.LinhaDiagonalSuperior, 1);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                }
                else if (Linha_Selecionada == 3)
                {
                    Thread_Filtros.ReportProgress(40);
                    Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros(3, Operacoes_Filtros.LinhaDiagonalInferior, 1);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                }
            }


            // APLICAÇÃO DE FILTROS LAPLACIANO
            if (Rdo_Laplace.Checked == true)
            {
                if (Laplaciano == 3)
                {

                    Thread_Filtros.ReportProgress(10);
                    Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros((int)Laplaciano, Operacoes_Filtros.Laplaciano_3, 1);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                }
                else if (Laplaciano == 5)
                {
                    Thread_Filtros.ReportProgress(20);
                    Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros((int)Laplaciano, Operacoes_Filtros.Laplaciano_5, 1);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                }
                else if (Laplaciano == 9)
                {
                    Thread_Filtros.ReportProgress(30);
                    Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros((int)Laplaciano, Operacoes_Filtros.Laplaciano_9, 1);
                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                }
                else
                {
                    Thread_Filtros.ReportProgress(40);
                    MessageBox.Show("O Numero Inserido não é válido. Para Lapaciano as entradas devem ser: 3, 5 ou 9", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // APLICAÇÃO DE FILTROS BLUR
            if (Rdo_Blur.Checked == true)
              
            {
                if (Chkb_Blur_Pesos.Checked == false)
                {

                    if (BlurValor == 3)
                    {

                        Thread_Filtros.ReportProgress(10);
                        float mod = 16;
                        mod = 1 / mod;
                        Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros(3, Operacoes_Filtros.Blur3_d, mod);
                       
                        Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                    }
                }

                {
                    if (BlurValor == 3)
                    {
                       
                        float mod = (float)BlurValor * (float)BlurValor;
                        mod = 1 / mod;
                        Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros((int)BlurValor, Operacoes_Filtros.Blur3_1, mod);
                        Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                    }
                    else if (BlurValor == 5)
                    {
                       
                        float mod = (float)BlurValor * (float)BlurValor;
                        mod = 1 / mod;
                        Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros((int)BlurValor, Operacoes_Filtros.Blur5_1, mod);
                        Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                    }
                    else if (BlurValor == 7)
                    {
                        
                        float mod = (float)BlurValor * (float)BlurValor;
                        mod = 1 / mod;
                        Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros((int)BlurValor, Operacoes_Filtros.Blur7_1, mod);
                        Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                    }
                    else
                    {
                        MessageBox.Show("O Numero Inserido não é válido. Para Blur as entradas devem ser: 3, 5 ou 7", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



            // APLICAÇÃO DE FILTROS PASSA ALTA
            if (Rdo_PassaAlta.Checked == true)
            {
                if (PassaAltaValor == 3)
                {
                    Thread_Filtros.ReportProgress(10);
                    float mod = (float)PassaAltaValor * (float)PassaAltaValor;
                    mod = 1 / mod;
                    Filtro_Paramentros parametrosDoFiltro = new Filtro_Paramentros((int)PassaAltaValor, Operacoes_Filtros.PassaAlta3_1, mod);

                    Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, parametrosDoFiltro);
                }
            }

        }
        private void Thread_Filtros_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Pcb04_Carregando.Visible = true;
            Btn_Aplicar_Filtro.Enabled = false;


        }

        private void Thread_Filtros_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Pcb04_Carregando.Visible = false;
            Btn_Aplicar_Filtro.Enabled = true;
            Chkb_Blur_Pesos.Checked = false;
            if (Pcb_03.Image != null)
            {
                SucessoF = true;
                Sucesso_A = false;
                SucessoB = false;
            }
        }

        private void Btn_Aplicar_Filtro_Click(object sender, EventArgs e)
        {
            Pcb_03.Image = null;
            if (Pcb_01.Image != null)
            {
                Borda_Selecionada = Cmb_Bordas.SelectedIndex;
                Linha_Selecionada = Cmb_Linhas.SelectedIndex;
                Laplaciano = (int)Num_UpDown_Laplace.Value;
                BlurValor = (int)Num_UpDown_Blur.Value;
                PassaAltaValor = (int)Num_UpDown_Alta.Value;
                Thread_Filtros.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Você deve selecionar a imagem 01 antes de realizar este calculo", "Erro ao aplicar filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Num_UpDown_Cinza_B.Value.ToString());
        }

        private void Grp_B_Arit_Leave(object sender, EventArgs e)
        {
            //desabilito as opções marcadas no groupbox Aritimetica
            Rdo_Negativo.Checked = false;
            Rdo_Cinza.Checked = false;
            Rdo_Cinza_Co.Checked = false;
            Rdo_PretoBranco.Checked = false;
        }

        private void Grp_B_Filtros_Leave(object sender, EventArgs e)
        {
            //desabilito as opções marcadas no groupbox Filtros
            Rdo_Bordas.Checked = false;
            Rdo_Nenhum.Checked = false;
            Rdo_Linhas.Checked = false;
            Rdo_Laplace.Checked = false;
            Rdo_Blur.Checked = false;
            Chkb_Blur_Pesos.Checked = false;
            Rdo_PassaAlta.Checked = false;
        }

        private void Grp_B_Bool_Leave(object sender, EventArgs e)
        {
            //desabilito as opções marcadas no groupbox Booleanas
            Rdo_AND.Checked = false;
            Rdo_OR.Checked = false;
            Rdo_XOR.Checked = false;
        }

        private void Cmbb_Operacoes_Click(object sender, EventArgs e)
        {
            //desabilito as opções marcadas no groupbox Aritimetica quando clico em operação aritmetica
            Rdo_Negativo.Checked = false;
            Rdo_Cinza.Checked = false;
            Rdo_Cinza_Co.Checked = false;
            Rdo_PretoBranco.Checked = false;
        }

      

        private void Btn_Salva_Filtro_Click(object sender, EventArgs e)
        {
            if (SucessoF == true)
            {
                // SALVA O RESULTADO DO FILTRO
                SaveFileDialog Salva_Foto = new SaveFileDialog();
                Salva_Foto.Filter = "Images|*.png;*.bmp;*.jpg";
                if (Rdo_Bordas.Checked == true)
                {
                    if (Cmb_Bordas.ContainsFocus == false)
                    {
                        string Borda = "Detecção de bordas ";
                        string Tipo = $"{this.Cmb_Bordas.GetItemText(this.Cmb_Bordas.SelectedItem)}";
                        Salva_Foto.FileName = Borda + Tipo;
                    }
                }
                else if (Rdo_Linhas.Checked == true)
                {
                    if (Cmb_Linhas.ContainsFocus == false)
                    {
                        string Linha = "Detecção de linhas ";
                        string Tipo = $"{this.Cmb_Bordas.GetItemText(this.Cmb_Linhas.SelectedItem)}";
                        Salva_Foto.FileName = Linha + Tipo;

                    }
                }
                else if (Rdo_Laplace.Checked == true)
                {
                    Salva_Foto.FileName = "Filtro Laplace.png";
                }
                else if (Rdo_Blur.Checked == true)
                {
                    Salva_Foto.FileName = "Filtro Blur.png";
                }
                else if (Rdo_PassaAlta.Checked == true)
                {
                    Salva_Foto.FileName = "Filtro Passa Alta.png";
                }

                ImageFormat format = ImageFormat.Png;
                if (Salva_Foto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(Salva_Foto.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;

                    }
                    Pcb_03.Image.Save(Salva_Foto.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Você deve aplicar um filtro antes de salvar", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Btn_Salva_Booleano_Click(object sender, EventArgs e)
        {
            // Salva o resultado das operações booleanas
            if (SucessoB == true)
            {
                SaveFileDialog Salva_Foto = new SaveFileDialog();
                Salva_Foto.Filter = "Images|*.png;*.bmp;*.jpg";

                if (Rdo_AND.Checked == true)
                {
                    Salva_Foto.FileName = "Operação AND.png";
                }
                else if (Rdo_OR.Checked == true)
                {
                    Salva_Foto.FileName = "Operação OR.png";
                }
                else if (Rdo_XOR.Checked == true)
                {
                    Salva_Foto.FileName = "Operação XOR.png";
                }

                ImageFormat format = ImageFormat.Png;
                if (Salva_Foto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(Salva_Foto.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;

                    }
                    Pcb_03.Image.Save(Salva_Foto.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Você deve aplicar um filtro booleano antes de salvar", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
