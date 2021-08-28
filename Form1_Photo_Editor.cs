using Photo_Editor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Editor
{
    public partial class Form1_Photo_Editor : Form
    {   
        
        
        public Form1_Photo_Editor()
        {
            InitializeComponent();      
           
        }

        private void Form1_Photo_Editor_Load(object sender, EventArgs e)
        {   
            //
            // Inicialização do programa
            //

            // Chamada da função de arredondamento
            //
            Region = System.Drawing.Region.FromHrgn(Round_Form.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            //
            //
          
          


        }

        private void Form1_Photo_Editor_MouseDown(object sender, MouseEventArgs e)
        {
           // evento mouse pressionado sobre a janela
           // Chamo a função de arrasto 
           
            if (e.Button == MouseButtons.Left)
            {
                Drag_Control.ReleaseCapture();
                Drag_Control.SendMessage(Handle,Drag_Control.WM_NCLBUTTONDOWN,Drag_Control.HT_CAPTION,0);
            }
           
        }

       
    }
}
