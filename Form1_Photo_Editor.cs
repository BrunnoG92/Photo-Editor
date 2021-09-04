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

        public Form1_Photo_Editor()
        {
            InitializeComponent();

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
                Operacoes_Aritmeticas.ConverteCinza(ImagemCinza);
                Pcb_03.Image = ImagemCinza;
            }
            else if (Rdo_Negativo.Checked == true)
            {
                Bitmap Imagem_Negativo = new Bitmap(Pcb_01.Image);
                Operacoes_Aritmeticas.Negativo(Imagem_Negativo);
                Pcb_03.Image = Imagem_Negativo;
            }

            else if (Rdo_PretoBranco.Checked == true)
            {
                {
                    Limiar = (int)Num_UpDown_Limiar.Value;
                    Bitmap ImagemPretoBranco = new Bitmap(Pcb_01.Image);
                    Operacoes_Aritmeticas.PretoBranco(ImagemPretoBranco);
                    Pcb_03.Image = ImagemPretoBranco;
                }
            }


            else if (Rdo_Soma.Checked == true)
            {
                if (Pcb_02.Image == null)// se não selecionar imagem 02
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteSoma((Bitmap)Pcb_01.Image, (Bitmap)Pcb_01.Image, CorrecaoSelecionado, Imagem_Constante, Convert.ToInt32(Num_UpDown_Soma.Value));

                }
                else
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteSoma((Bitmap)Pcb_01.Image, (Bitmap)Pcb_02.Image, CorrecaoSelecionado, Imagem_Constante, Convert.ToInt32(Num_UpDown_Soma.Value));

                }

            }
            else if (Rdo_Sub.Checked == true)
            {

                if (Pcb_02.Image == null)// se imagem 02 não fo r selecionada
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteSubtracao(Pcb_01.Image, Pcb_01.Image, CorrecaoSelecionado, Imagem_Constante, (int)Num_UpDown_Sub.Value);

                }
                else
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteSubtracao(Pcb_01.Image, Pcb_02.Image, CorrecaoSelecionado, Imagem_Constante, (int)Num_UpDown_Sub.Value);

                }
            }
            else if (Rdo_Multiplicacao.Checked == true)
            {
                if (Pcb_02.Image == null)// se imagem 02 não for selecionada
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteMultiplicacao(Pcb_01.Image, Pcb_01.Image, (int)Num_UpDown_Mult.Value, CorrecaoSelecionado, Imagem_Constante);
                }
                else
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteMultiplicacao(Pcb_01.Image, Pcb_02.Image, (int)Num_UpDown_Mult.Value, CorrecaoSelecionado, Imagem_Constante);

                }
            }
            else if (Rdo_Divisao.Checked == true)
            { 
                if (Pcb_02.Image == null) //se não tiver uma segunda imagem selecionada
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteDivisao(Pcb_01.Image, Pcb_01.Image, (int)Num_UpDown_Div.Value, CorrecaoSelecionado, Imagem_Constante);

                }
                else 
                {
                    Pcb_03.Image = Operacoes_Aritmeticas.ConverteDivisao(Pcb_01.Image, Pcb_02.Image, (int)Num_UpDown_Div.Value, CorrecaoSelecionado, Imagem_Constante);

                }
            }
        }

        private void Btn_Aplicar_Ar_Click(object sender, EventArgs e)
        {   // botão aplicar aritmetica chama a thread que faz os calculos aritméticos 
            Thread_Aritmetica.RunWorkerAsync();
            Btn_Aplicar_Ar.Enabled = false;
            Btn_Aplica_Bool.Enabled = false;
            Btn_Aplicar_Filtro.Enabled = false;
        }

        private void Thread_Aritmetica_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Btn_Aplicar_Ar.Enabled = true;
            Btn_Aplica_Bool.Enabled = true;
            Btn_Aplicar_Filtro.Enabled = true;
            MessageBox.Show("Filtro aplicado com sucesso", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog Salva_Foto = new SaveFileDialog();
            Salva_Foto.Filter = "Images|*.png;*.bmp;*.jpg";
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

        private void Thread_Booleana_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Rdo_AND.Checked == true)
            {
                Pcb_03.Image = Operacoes_Booleanas.ConverteParaAND(Pcb_01.Image, Pcb_02.Image);
            }
            else if (Rdo_OR.Checked == true)
            {
                Pcb_03.Image = Operacoes_Booleanas.ConverteParaOR(Pcb_01.Image, Pcb_02.Image);
            }
            else if (Rdo_XOR.Checked == true)
            {
                Pcb_03.Image = Operacoes_Booleanas.ConverteParaXOR(Pcb_01.Image, Pcb_02.Image);
            }
        }
        private void Btn_Aplica_Bool_Click(object sender, EventArgs e)
        {
            Thread_Booleana.RunWorkerAsync();
        }

        private void Thread_Booleana_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Filtro Aplicado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
          
        private void Thread_Filtros_DoWork(object sender, DoWorkEventArgs e)
        {   
            
            if (Cmb_Bordas.SelectedIndex == 0)
            {
               
                Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.RobertsVertical, 1);
                Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
            }
            else if (Cmb_Bordas.SelectedIndex == 1)
            {
               
                Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.RobertsHorizontal, 1);
                Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
            }
            else if (Cmb_Bordas.SelectedIndex == 2)
            {
                float mod = 4;
                mod = 1 / mod;
                Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.SobelVertical, mod);
                Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
            }
            else if (Cmb_Bordas.SelectedIndex == 3)
            {
                float mod = 4;
                mod = 1 / mod;
                Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.SobelHorizontal, mod);
                Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
            }
            else if (Cmb_Bordas.SelectedIndex == 4)
            {
                float mod = 3;
                mod = 1 / mod;
                Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.PrewittVertical, mod);
                Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
            }
            else if (Cmb_Bordas.SelectedIndex == 5)
            {
                float mod = 3;
                mod = 1 / mod;
                Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.PrewittHorizontal, mod);
                Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
            }
            else if (Cmb_Bordas.SelectedIndex == 6)
            {
                double raiz = Math.Sqrt(2);
                float mod = 2 + (float)raiz;
                mod = 1 / mod;
                Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.FreiChenVertical, mod);
                Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
            }
            else if (Cmb_Bordas.SelectedIndex == 7)
            {
                double raiz = Math.Sqrt(2);
                float mod = 2 + (float)raiz;
                mod = 1 / mod;
                Filtro_Paramentros Parametros_Filtros = new Filtro_Paramentros(3, Operacoes_Filtros.FreiChenHorizontal, mod);
                Pcb_03.Image = Operacoes_Filtros.Colocar_Filtro(Pcb_01.Image, Parametros_Filtros);
            }
        }
    }
}
