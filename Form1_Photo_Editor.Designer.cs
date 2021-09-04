
namespace Photo_Editor
{
    partial class Form1_Photo_Editor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Cmbb_Correcao = new System.Windows.Forms.ComboBox();
            this.Cmbb_Imagem_Constante = new System.Windows.Forms.ComboBox();
            this.Cmb_Bordas = new System.Windows.Forms.ComboBox();
            this.Cmb_Linhas = new System.Windows.Forms.ComboBox();
            this.Grp_B_Filtros = new System.Windows.Forms.GroupBox();
            this.Num_UpDown_Alta = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.Chkb_Blur_Pesos = new System.Windows.Forms.CheckBox();
            this.Num_UpDown_Blur = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.Num_UpDown_Laplace = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.Rdo_PassaAlta = new System.Windows.Forms.RadioButton();
            this.Rdo_Laplace = new System.Windows.Forms.RadioButton();
            this.Btn_Aplicar_Filtro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rdo_Linhas = new System.Windows.Forms.RadioButton();
            this.Rdo_Blur = new System.Windows.Forms.RadioButton();
            this.Rdo_Bordas = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Lbl_Imagem01 = new System.Windows.Forms.Label();
            this.Lbl_Imagem02 = new System.Windows.Forms.Label();
            this.Lbl_Imagem03 = new System.Windows.Forms.Label();
            this.Grp_B_Arit = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Aplicar_Ar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Num_UpDown_Limiar = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rdo_Negativo = new System.Windows.Forms.RadioButton();
            this.Rdo_PretoBranco = new System.Windows.Forms.RadioButton();
            this.Rdo_Cinza = new System.Windows.Forms.RadioButton();
            this.Grp_B_Bool = new System.Windows.Forms.GroupBox();
            this.Btn_Aplica_Bool = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rdo_XOR = new System.Windows.Forms.RadioButton();
            this.Rdo_OR = new System.Windows.Forms.RadioButton();
            this.Rdo_AND = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Salvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Imagem02 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Imagem01 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Pcb_03 = new System.Windows.Forms.PictureBox();
            this.Pcb_02 = new System.Windows.Forms.PictureBox();
            this.Pcb_01 = new System.Windows.Forms.PictureBox();
            this.Thread_Aritmetica = new System.ComponentModel.BackgroundWorker();
            this.Thread_Booleana = new System.ComponentModel.BackgroundWorker();
            this.Thread_Filtros = new System.ComponentModel.BackgroundWorker();
            this.Cmbb_Operacoes = new System.Windows.Forms.ComboBox();
            this.Lbl_Operacoes = new System.Windows.Forms.Label();
            this.Num_UpDown_ValorOp = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Grp_B_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Grp_B_Arit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Grp_B_Bool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_01)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1149, 0);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // Cmbb_Correcao
            // 
            this.Cmbb_Correcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbb_Correcao.FormattingEnabled = true;
            this.Cmbb_Correcao.Items.AddRange(new object[] {
            "Truncar 0 - 255",
            "Média"});
            this.Cmbb_Correcao.Location = new System.Drawing.Point(132, 43);
            this.Cmbb_Correcao.Name = "Cmbb_Correcao";
            this.Cmbb_Correcao.Size = new System.Drawing.Size(107, 21);
            this.Cmbb_Correcao.TabIndex = 75;
            this.toolTip1.SetToolTip(this.Cmbb_Correcao, "Seleciona o tipo de correção a ser aplicada em caso de estouro do pixel");
            this.Cmbb_Correcao.SelectedIndexChanged += new System.EventHandler(this.Cmbb_Correcao_SelectedIndexChanged);
            // 
            // Cmbb_Imagem_Constante
            // 
            this.Cmbb_Imagem_Constante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbb_Imagem_Constante.FormattingEnabled = true;
            this.Cmbb_Imagem_Constante.Items.AddRange(new object[] {
            "0 - Entre Imagens",
            "1 - Constante"});
            this.Cmbb_Imagem_Constante.Location = new System.Drawing.Point(132, 70);
            this.Cmbb_Imagem_Constante.Name = "Cmbb_Imagem_Constante";
            this.Cmbb_Imagem_Constante.Size = new System.Drawing.Size(107, 21);
            this.Cmbb_Imagem_Constante.TabIndex = 78;
            this.toolTip1.SetToolTip(this.Cmbb_Imagem_Constante, "Seleciona se a operação será feita em constante ou entre imagens");
            this.Cmbb_Imagem_Constante.SelectedIndexChanged += new System.EventHandler(this.Cmbb_Imagem_Constante_SelectedIndexChanged);
            // 
            // Cmb_Bordas
            // 
            this.Cmb_Bordas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Bordas.FormattingEnabled = true;
            this.Cmb_Bordas.Items.AddRange(new object[] {
            "Roberts Vertical",
            "Roberts Horizontal",
            "Sobel Vertical",
            "Sobel Horizontal",
            "Prewitt Vertical",
            "Prewitt Horizontal",
            "Frei-ChenVertical",
            "Frei-Chen Hotizontal"});
            this.Cmb_Bordas.Location = new System.Drawing.Point(30, 101);
            this.Cmb_Bordas.Name = "Cmb_Bordas";
            this.Cmb_Bordas.Size = new System.Drawing.Size(120, 21);
            this.Cmb_Bordas.TabIndex = 84;
            this.toolTip1.SetToolTip(this.Cmb_Bordas, "Seleciona a máscara do filtro");
            // 
            // Cmb_Linhas
            // 
            this.Cmb_Linhas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Linhas.FormattingEnabled = true;
            this.Cmb_Linhas.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Diagonal Superior",
            "Diagonal Inferior"});
            this.Cmb_Linhas.Location = new System.Drawing.Point(29, 151);
            this.Cmb_Linhas.Name = "Cmb_Linhas";
            this.Cmb_Linhas.Size = new System.Drawing.Size(120, 21);
            this.Cmb_Linhas.TabIndex = 90;
            this.toolTip1.SetToolTip(this.Cmb_Linhas, "Seleciona a máscara do filtro");
            // 
            // Grp_B_Filtros
            // 
            this.Grp_B_Filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grp_B_Filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Grp_B_Filtros.Controls.Add(this.Cmb_Linhas);
            this.Grp_B_Filtros.Controls.Add(this.Cmb_Bordas);
            this.Grp_B_Filtros.Controls.Add(this.Num_UpDown_Alta);
            this.Grp_B_Filtros.Controls.Add(this.Chkb_Blur_Pesos);
            this.Grp_B_Filtros.Controls.Add(this.Num_UpDown_Blur);
            this.Grp_B_Filtros.Controls.Add(this.Num_UpDown_Laplace);
            this.Grp_B_Filtros.Controls.Add(this.Rdo_PassaAlta);
            this.Grp_B_Filtros.Controls.Add(this.Rdo_Laplace);
            this.Grp_B_Filtros.Controls.Add(this.Btn_Aplicar_Filtro);
            this.Grp_B_Filtros.Controls.Add(this.pictureBox5);
            this.Grp_B_Filtros.Controls.Add(this.label1);
            this.Grp_B_Filtros.Controls.Add(this.Rdo_Linhas);
            this.Grp_B_Filtros.Controls.Add(this.Rdo_Blur);
            this.Grp_B_Filtros.Controls.Add(this.Rdo_Bordas);
            this.Grp_B_Filtros.Controls.Add(this.radioButton1);
            this.Grp_B_Filtros.ForeColor = System.Drawing.Color.White;
            this.Grp_B_Filtros.Location = new System.Drawing.Point(64, 314);
            this.Grp_B_Filtros.Name = "Grp_B_Filtros";
            this.Grp_B_Filtros.Size = new System.Drawing.Size(351, 360);
            this.Grp_B_Filtros.TabIndex = 1;
            this.Grp_B_Filtros.TabStop = false;
            this.Grp_B_Filtros.Text = "Filtros";
            // 
            // Num_UpDown_Alta
            // 
            this.Num_UpDown_Alta.Location = new System.Drawing.Point(157, 285);
            this.Num_UpDown_Alta.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Num_UpDown_Alta.Name = "Num_UpDown_Alta";
            this.Num_UpDown_Alta.Size = new System.Drawing.Size(51, 19);
            this.Num_UpDown_Alta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Num_UpDown_Alta.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.Num_UpDown_Alta.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_UpDown_Alta.TabIndex = 89;
            this.Num_UpDown_Alta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_UpDown_Alta.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Chkb_Blur_Pesos
            // 
            this.Chkb_Blur_Pesos.AutoSize = true;
            this.Chkb_Blur_Pesos.Location = new System.Drawing.Point(44, 258);
            this.Chkb_Blur_Pesos.Name = "Chkb_Blur_Pesos";
            this.Chkb_Blur_Pesos.Size = new System.Drawing.Size(106, 17);
            this.Chkb_Blur_Pesos.TabIndex = 88;
            this.Chkb_Blur_Pesos.Text = "Pesos Diferentes";
            this.Chkb_Blur_Pesos.UseVisualStyleBackColor = true;
            // 
            // Num_UpDown_Blur
            // 
            this.Num_UpDown_Blur.Location = new System.Drawing.Point(157, 224);
            this.Num_UpDown_Blur.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Num_UpDown_Blur.Name = "Num_UpDown_Blur";
            this.Num_UpDown_Blur.Size = new System.Drawing.Size(51, 19);
            this.Num_UpDown_Blur.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Num_UpDown_Blur.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.Num_UpDown_Blur.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_UpDown_Blur.TabIndex = 87;
            this.Num_UpDown_Blur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_UpDown_Blur.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Num_UpDown_Laplace
            // 
            this.Num_UpDown_Laplace.Location = new System.Drawing.Point(157, 186);
            this.Num_UpDown_Laplace.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Num_UpDown_Laplace.Name = "Num_UpDown_Laplace";
            this.Num_UpDown_Laplace.Size = new System.Drawing.Size(51, 19);
            this.Num_UpDown_Laplace.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Num_UpDown_Laplace.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.Num_UpDown_Laplace.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_UpDown_Laplace.TabIndex = 86;
            this.Num_UpDown_Laplace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_UpDown_Laplace.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Rdo_PassaAlta
            // 
            this.Rdo_PassaAlta.AutoSize = true;
            this.Rdo_PassaAlta.ForeColor = System.Drawing.Color.White;
            this.Rdo_PassaAlta.Location = new System.Drawing.Point(30, 287);
            this.Rdo_PassaAlta.Name = "Rdo_PassaAlta";
            this.Rdo_PassaAlta.Size = new System.Drawing.Size(75, 17);
            this.Rdo_PassaAlta.TabIndex = 77;
            this.Rdo_PassaAlta.TabStop = true;
            this.Rdo_PassaAlta.Text = "Passa Alta";
            this.Rdo_PassaAlta.UseVisualStyleBackColor = true;
            // 
            // Rdo_Laplace
            // 
            this.Rdo_Laplace.AutoSize = true;
            this.Rdo_Laplace.ForeColor = System.Drawing.Color.White;
            this.Rdo_Laplace.Location = new System.Drawing.Point(30, 189);
            this.Rdo_Laplace.Name = "Rdo_Laplace";
            this.Rdo_Laplace.Size = new System.Drawing.Size(77, 17);
            this.Rdo_Laplace.TabIndex = 76;
            this.Rdo_Laplace.TabStop = true;
            this.Rdo_Laplace.Text = "Laplaciano";
            this.Rdo_Laplace.UseVisualStyleBackColor = true;
            // 
            // Btn_Aplicar_Filtro
            // 
            this.Btn_Aplicar_Filtro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Aplicar_Filtro.Location = new System.Drawing.Point(97, 328);
            this.Btn_Aplicar_Filtro.Name = "Btn_Aplicar_Filtro";
            this.Btn_Aplicar_Filtro.Size = new System.Drawing.Size(100, 26);
            this.Btn_Aplicar_Filtro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Aplicar_Filtro.StateCommon.Border.Rounding = 10;
            this.Btn_Aplicar_Filtro.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_Aplicar_Filtro.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Aplicar_Filtro.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.Btn_Aplicar_Filtro.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.Btn_Aplicar_Filtro.TabIndex = 75;
            this.Btn_Aplicar_Filtro.Values.Text = "APLICAR";
            this.Btn_Aplicar_Filtro.Click += new System.EventHandler(this.Btn_Aplicar_Filtro_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Photo_Editor.Properties.Resources.icons8_editar_imagem_80;
            this.pictureBox5.Location = new System.Drawing.Point(248, 36);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(97, 84);
            this.pictureBox5.TabIndex = 74;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rdo_Linhas
            // 
            this.Rdo_Linhas.AutoSize = true;
            this.Rdo_Linhas.ForeColor = System.Drawing.Color.White;
            this.Rdo_Linhas.Location = new System.Drawing.Point(28, 128);
            this.Rdo_Linhas.Name = "Rdo_Linhas";
            this.Rdo_Linhas.Size = new System.Drawing.Size(121, 17);
            this.Rdo_Linhas.TabIndex = 3;
            this.Rdo_Linhas.TabStop = true;
            this.Rdo_Linhas.Text = "Detecção de Linhas";
            this.Rdo_Linhas.UseVisualStyleBackColor = true;
            // 
            // Rdo_Blur
            // 
            this.Rdo_Blur.AutoSize = true;
            this.Rdo_Blur.ForeColor = System.Drawing.Color.White;
            this.Rdo_Blur.Location = new System.Drawing.Point(30, 226);
            this.Rdo_Blur.Name = "Rdo_Blur";
            this.Rdo_Blur.Size = new System.Drawing.Size(43, 17);
            this.Rdo_Blur.TabIndex = 2;
            this.Rdo_Blur.TabStop = true;
            this.Rdo_Blur.Text = "Blur";
            this.Rdo_Blur.UseVisualStyleBackColor = true;
            // 
            // Rdo_Bordas
            // 
            this.Rdo_Bordas.AutoSize = true;
            this.Rdo_Bordas.ForeColor = System.Drawing.Color.White;
            this.Rdo_Bordas.Location = new System.Drawing.Point(26, 78);
            this.Rdo_Bordas.Name = "Rdo_Bordas";
            this.Rdo_Bordas.Size = new System.Drawing.Size(123, 17);
            this.Rdo_Bordas.TabIndex = 1;
            this.Rdo_Bordas.TabStop = true;
            this.Rdo_Bordas.Text = "Detecção de Bordas";
            this.Rdo_Bordas.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(28, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nenhum";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Lbl_Imagem01
            // 
            this.Lbl_Imagem01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_Imagem01.AutoSize = true;
            this.Lbl_Imagem01.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Imagem01.ForeColor = System.Drawing.Color.White;
            this.Lbl_Imagem01.Location = new System.Drawing.Point(131, 4);
            this.Lbl_Imagem01.Name = "Lbl_Imagem01";
            this.Lbl_Imagem01.Size = new System.Drawing.Size(95, 21);
            this.Lbl_Imagem01.TabIndex = 7;
            this.Lbl_Imagem01.Text = "Imagem 01";
            // 
            // Lbl_Imagem02
            // 
            this.Lbl_Imagem02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_Imagem02.AutoSize = true;
            this.Lbl_Imagem02.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Imagem02.ForeColor = System.Drawing.Color.White;
            this.Lbl_Imagem02.Location = new System.Drawing.Point(542, 4);
            this.Lbl_Imagem02.Name = "Lbl_Imagem02";
            this.Lbl_Imagem02.Size = new System.Drawing.Size(95, 21);
            this.Lbl_Imagem02.TabIndex = 8;
            this.Lbl_Imagem02.Text = "Imagem 02";
            // 
            // Lbl_Imagem03
            // 
            this.Lbl_Imagem03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_Imagem03.AutoSize = true;
            this.Lbl_Imagem03.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Imagem03.ForeColor = System.Drawing.Color.White;
            this.Lbl_Imagem03.Location = new System.Drawing.Point(908, 4);
            this.Lbl_Imagem03.Name = "Lbl_Imagem03";
            this.Lbl_Imagem03.Size = new System.Drawing.Size(114, 21);
            this.Lbl_Imagem03.TabIndex = 9;
            this.Lbl_Imagem03.Text = "Imagem Final";
            // 
            // Grp_B_Arit
            // 
            this.Grp_B_Arit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grp_B_Arit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Grp_B_Arit.Controls.Add(this.label9);
            this.Grp_B_Arit.Controls.Add(this.Num_UpDown_ValorOp);
            this.Grp_B_Arit.Controls.Add(this.Cmbb_Operacoes);
            this.Grp_B_Arit.Controls.Add(this.Lbl_Operacoes);
            this.Grp_B_Arit.Controls.Add(this.Cmbb_Imagem_Constante);
            this.Grp_B_Arit.Controls.Add(this.label6);
            this.Grp_B_Arit.Controls.Add(this.Cmbb_Correcao);
            this.Grp_B_Arit.Controls.Add(this.label5);
            this.Grp_B_Arit.Controls.Add(this.Btn_Aplicar_Ar);
            this.Grp_B_Arit.Controls.Add(this.pictureBox4);
            this.Grp_B_Arit.Controls.Add(this.Num_UpDown_Limiar);
            this.Grp_B_Arit.Controls.Add(this.label4);
            this.Grp_B_Arit.Controls.Add(this.label2);
            this.Grp_B_Arit.Controls.Add(this.Rdo_Negativo);
            this.Grp_B_Arit.Controls.Add(this.Rdo_PretoBranco);
            this.Grp_B_Arit.Controls.Add(this.Rdo_Cinza);
            this.Grp_B_Arit.ForeColor = System.Drawing.Color.White;
            this.Grp_B_Arit.Location = new System.Drawing.Point(438, 314);
            this.Grp_B_Arit.Name = "Grp_B_Arit";
            this.Grp_B_Arit.Size = new System.Drawing.Size(351, 360);
            this.Grp_B_Arit.TabIndex = 5;
            this.Grp_B_Arit.TabStop = false;
            this.Grp_B_Arit.Text = "Operações Aritméticas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Imagem/Constante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tipo de Correção";
            // 
            // Btn_Aplicar_Ar
            // 
            this.Btn_Aplicar_Ar.Location = new System.Drawing.Point(139, 328);
            this.Btn_Aplicar_Ar.Name = "Btn_Aplicar_Ar";
            this.Btn_Aplicar_Ar.Size = new System.Drawing.Size(100, 26);
            this.Btn_Aplicar_Ar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Aplicar_Ar.StateCommon.Border.Rounding = 10;
            this.Btn_Aplicar_Ar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_Aplicar_Ar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Aplicar_Ar.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.Btn_Aplicar_Ar.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.Btn_Aplicar_Ar.TabIndex = 73;
            this.Btn_Aplicar_Ar.Values.Text = "CALCULAR";
            this.Btn_Aplicar_Ar.Click += new System.EventHandler(this.Btn_Aplicar_Ar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Photo_Editor.Properties.Resources.icons8_sem_imagem_80;
            this.pictureBox4.Location = new System.Drawing.Point(260, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 86);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // Num_UpDown_Limiar
            // 
            this.Num_UpDown_Limiar.Location = new System.Drawing.Point(141, 199);
            this.Num_UpDown_Limiar.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Num_UpDown_Limiar.Name = "Num_UpDown_Limiar";
            this.Num_UpDown_Limiar.Size = new System.Drawing.Size(120, 19);
            this.Num_UpDown_Limiar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Num_UpDown_Limiar.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.Num_UpDown_Limiar.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_UpDown_Limiar.TabIndex = 73;
            this.Num_UpDown_Limiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Limiar";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Operações Aritméticas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rdo_Negativo
            // 
            this.Rdo_Negativo.AutoSize = true;
            this.Rdo_Negativo.Location = new System.Drawing.Point(51, 114);
            this.Rdo_Negativo.Name = "Rdo_Negativo";
            this.Rdo_Negativo.Size = new System.Drawing.Size(68, 17);
            this.Rdo_Negativo.TabIndex = 2;
            this.Rdo_Negativo.TabStop = true;
            this.Rdo_Negativo.Text = "Negativo";
            this.Rdo_Negativo.UseVisualStyleBackColor = true;
            // 
            // Rdo_PretoBranco
            // 
            this.Rdo_PretoBranco.AutoSize = true;
            this.Rdo_PretoBranco.Location = new System.Drawing.Point(51, 164);
            this.Rdo_PretoBranco.Name = "Rdo_PretoBranco";
            this.Rdo_PretoBranco.Size = new System.Drawing.Size(96, 17);
            this.Rdo_PretoBranco.TabIndex = 1;
            this.Rdo_PretoBranco.TabStop = true;
            this.Rdo_PretoBranco.Text = "Preto e Branco";
            this.Rdo_PretoBranco.UseVisualStyleBackColor = true;
            // 
            // Rdo_Cinza
            // 
            this.Rdo_Cinza.AutoSize = true;
            this.Rdo_Cinza.Location = new System.Drawing.Point(51, 139);
            this.Rdo_Cinza.Name = "Rdo_Cinza";
            this.Rdo_Cinza.Size = new System.Drawing.Size(101, 17);
            this.Rdo_Cinza.TabIndex = 0;
            this.Rdo_Cinza.TabStop = true;
            this.Rdo_Cinza.Text = "Escala de Cinza";
            this.Rdo_Cinza.UseVisualStyleBackColor = true;
            // 
            // Grp_B_Bool
            // 
            this.Grp_B_Bool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grp_B_Bool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Grp_B_Bool.Controls.Add(this.Btn_Aplica_Bool);
            this.Grp_B_Bool.Controls.Add(this.pictureBox6);
            this.Grp_B_Bool.Controls.Add(this.label3);
            this.Grp_B_Bool.Controls.Add(this.Rdo_XOR);
            this.Grp_B_Bool.Controls.Add(this.Rdo_OR);
            this.Grp_B_Bool.Controls.Add(this.Rdo_AND);
            this.Grp_B_Bool.ForeColor = System.Drawing.Color.White;
            this.Grp_B_Bool.Location = new System.Drawing.Point(816, 314);
            this.Grp_B_Bool.Name = "Grp_B_Bool";
            this.Grp_B_Bool.Size = new System.Drawing.Size(351, 360);
            this.Grp_B_Bool.TabIndex = 10;
            this.Grp_B_Bool.TabStop = false;
            this.Grp_B_Bool.Text = "Filtros";
            // 
            // Btn_Aplica_Bool
            // 
            this.Btn_Aplica_Bool.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Aplica_Bool.Location = new System.Drawing.Point(147, 328);
            this.Btn_Aplica_Bool.Name = "Btn_Aplica_Bool";
            this.Btn_Aplica_Bool.Size = new System.Drawing.Size(100, 26);
            this.Btn_Aplica_Bool.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Aplica_Bool.StateCommon.Border.Rounding = 10;
            this.Btn_Aplica_Bool.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_Aplica_Bool.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Aplica_Bool.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.Btn_Aplica_Bool.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.Btn_Aplica_Bool.TabIndex = 74;
            this.Btn_Aplica_Bool.Values.Text = "APLICAR";
            this.Btn_Aplica_Bool.Click += new System.EventHandler(this.Btn_Aplica_Bool_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Photo_Editor.Properties.Resources.icons8_diagrama_de_venn_50;
            this.pictureBox6.Location = new System.Drawing.Point(246, 36);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 86);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 74;
            this.pictureBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operações Booleanas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rdo_XOR
            // 
            this.Rdo_XOR.AutoSize = true;
            this.Rdo_XOR.Location = new System.Drawing.Point(96, 114);
            this.Rdo_XOR.Name = "Rdo_XOR";
            this.Rdo_XOR.Size = new System.Drawing.Size(48, 17);
            this.Rdo_XOR.TabIndex = 2;
            this.Rdo_XOR.TabStop = true;
            this.Rdo_XOR.Text = "XOR";
            this.Rdo_XOR.UseVisualStyleBackColor = true;
            // 
            // Rdo_OR
            // 
            this.Rdo_OR.AutoSize = true;
            this.Rdo_OR.Location = new System.Drawing.Point(96, 82);
            this.Rdo_OR.Name = "Rdo_OR";
            this.Rdo_OR.Size = new System.Drawing.Size(41, 17);
            this.Rdo_OR.TabIndex = 1;
            this.Rdo_OR.TabStop = true;
            this.Rdo_OR.Text = "OR";
            this.Rdo_OR.UseVisualStyleBackColor = true;
            // 
            // Rdo_AND
            // 
            this.Rdo_AND.AutoSize = true;
            this.Rdo_AND.Location = new System.Drawing.Point(96, 50);
            this.Rdo_AND.Name = "Rdo_AND";
            this.Rdo_AND.Size = new System.Drawing.Size(48, 17);
            this.Rdo_AND.TabIndex = 0;
            this.Rdo_AND.TabStop = true;
            this.Rdo_AND.Text = "AND";
            this.Rdo_AND.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.Btn_Salvar);
            this.panel1.Controls.Add(this.Btn_Imagem02);
            this.panel1.Controls.Add(this.Btn_Imagem01);
            this.panel1.Controls.Add(this.Lbl_Imagem03);
            this.panel1.Controls.Add(this.Grp_B_Arit);
            this.panel1.Controls.Add(this.Lbl_Imagem02);
            this.panel1.Controls.Add(this.Grp_B_Bool);
            this.panel1.Controls.Add(this.Lbl_Imagem01);
            this.panel1.Controls.Add(this.Grp_B_Filtros);
            this.panel1.Controls.Add(this.Pcb_03);
            this.panel1.Controls.Add(this.Pcb_02);
            this.panel1.Controls.Add(this.Pcb_01);
            this.panel1.Location = new System.Drawing.Point(22, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 808);
            this.panel1.TabIndex = 11;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Salvar.Location = new System.Drawing.Point(897, 270);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(160, 25);
            this.Btn_Salvar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Salvar.StateCommon.Border.Rounding = 10;
            this.Btn_Salvar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_Salvar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Salvar.TabIndex = 73;
            this.Btn_Salvar.Values.Text = "SALVAR ";
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Imagem02
            // 
            this.Btn_Imagem02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Imagem02.Location = new System.Drawing.Point(517, 270);
            this.Btn_Imagem02.Name = "Btn_Imagem02";
            this.Btn_Imagem02.Size = new System.Drawing.Size(160, 25);
            this.Btn_Imagem02.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Imagem02.StateCommon.Border.Rounding = 10;
            this.Btn_Imagem02.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_Imagem02.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Imagem02.TabIndex = 72;
            this.Btn_Imagem02.Values.Text = "CARREGAR IMAGEM 02";
            this.Btn_Imagem02.Click += new System.EventHandler(this.Btn_Imagem02_Click);
            // 
            // Btn_Imagem01
            // 
            this.Btn_Imagem01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Imagem01.Location = new System.Drawing.Point(135, 270);
            this.Btn_Imagem01.Name = "Btn_Imagem01";
            this.Btn_Imagem01.Size = new System.Drawing.Size(160, 25);
            this.Btn_Imagem01.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_Imagem01.StateCommon.Border.Rounding = 10;
            this.Btn_Imagem01.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Btn_Imagem01.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Imagem01.TabIndex = 71;
            this.Btn_Imagem01.Values.Text = "CARREGAR IMAGEM 01";
            this.Btn_Imagem01.Click += new System.EventHandler(this.Btn_Imagem01_Click);
            // 
            // Pcb_03
            // 
            this.Pcb_03.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pcb_03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pcb_03.Location = new System.Drawing.Point(816, 28);
            this.Pcb_03.Name = "Pcb_03";
            this.Pcb_03.Size = new System.Drawing.Size(348, 236);
            this.Pcb_03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcb_03.TabIndex = 4;
            this.Pcb_03.TabStop = false;
            // 
            // Pcb_02
            // 
            this.Pcb_02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pcb_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pcb_02.Location = new System.Drawing.Point(438, 28);
            this.Pcb_02.Name = "Pcb_02";
            this.Pcb_02.Size = new System.Drawing.Size(351, 236);
            this.Pcb_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcb_02.TabIndex = 3;
            this.Pcb_02.TabStop = false;
            // 
            // Pcb_01
            // 
            this.Pcb_01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pcb_01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pcb_01.Location = new System.Drawing.Point(64, 28);
            this.Pcb_01.Name = "Pcb_01";
            this.Pcb_01.Size = new System.Drawing.Size(351, 236);
            this.Pcb_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcb_01.TabIndex = 2;
            this.Pcb_01.TabStop = false;
            // 
            // Thread_Aritmetica
            // 
            this.Thread_Aritmetica.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Thread_Aritmetica_DoWork);
            this.Thread_Aritmetica.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Thread_Aritmetica_RunWorkerCompleted);
            // 
            // Thread_Booleana
            // 
            this.Thread_Booleana.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Thread_Booleana_DoWork);
            this.Thread_Booleana.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Thread_Booleana_RunWorkerCompleted);
            // 
            // Thread_Filtros
            // 
            this.Thread_Filtros.WorkerReportsProgress = true;
            this.Thread_Filtros.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Thread_Filtros_DoWork);
            this.Thread_Filtros.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Thread_Filtros_ProgressChanged);
            this.Thread_Filtros.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Thread_Filtros_RunWorkerCompleted);
            // 
            // Cmbb_Operacoes
            // 
            this.Cmbb_Operacoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbb_Operacoes.FormattingEnabled = true;
            this.Cmbb_Operacoes.Items.AddRange(new object[] {
            "Soma",
            "Subtração",
            "Multiplicação",
            "Divisão"});
            this.Cmbb_Operacoes.Location = new System.Drawing.Point(147, 242);
            this.Cmbb_Operacoes.Name = "Cmbb_Operacoes";
            this.Cmbb_Operacoes.Size = new System.Drawing.Size(107, 21);
            this.Cmbb_Operacoes.TabIndex = 86;
            this.toolTip1.SetToolTip(this.Cmbb_Operacoes, "Seleciona a operação a ser realizada");
            // 
            // Lbl_Operacoes
            // 
            this.Lbl_Operacoes.AutoSize = true;
            this.Lbl_Operacoes.Location = new System.Drawing.Point(25, 245);
            this.Lbl_Operacoes.Name = "Lbl_Operacoes";
            this.Lbl_Operacoes.Size = new System.Drawing.Size(116, 13);
            this.Lbl_Operacoes.TabIndex = 87;
            this.Lbl_Operacoes.Text = "Operações Aritméticas ";
            // 
            // Num_UpDown_ValorOp
            // 
            this.Num_UpDown_ValorOp.Location = new System.Drawing.Point(141, 269);
            this.Num_UpDown_ValorOp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Num_UpDown_ValorOp.Name = "Num_UpDown_ValorOp";
            this.Num_UpDown_ValorOp.Size = new System.Drawing.Size(120, 19);
            this.Num_UpDown_ValorOp.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Num_UpDown_ValorOp.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.Num_UpDown_ValorOp.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_UpDown_ValorOp.TabIndex = 88;
            this.Num_UpDown_ValorOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Valor Constante:";
            // 
            // Form1_Photo_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1249, 865);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1_Photo_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Photo_Editor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_Photo_Editor_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Photo_Editor_Resize);
            this.Grp_B_Filtros.ResumeLayout(false);
            this.Grp_B_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Grp_B_Arit.ResumeLayout(false);
            this.Grp_B_Arit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Grp_B_Bool.ResumeLayout(false);
            this.Grp_B_Bool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox Grp_B_Filtros;
        private System.Windows.Forms.PictureBox Pcb_01;
        private System.Windows.Forms.PictureBox Pcb_02;
        private System.Windows.Forms.PictureBox Pcb_03;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rdo_Linhas;
        private System.Windows.Forms.RadioButton Rdo_Blur;
        private System.Windows.Forms.RadioButton Rdo_Bordas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Lbl_Imagem01;
        private System.Windows.Forms.Label Lbl_Imagem02;
        private System.Windows.Forms.Label Lbl_Imagem03;
        private System.Windows.Forms.GroupBox Grp_B_Arit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Rdo_Negativo;
        private System.Windows.Forms.RadioButton Rdo_PretoBranco;
        private System.Windows.Forms.RadioButton Rdo_Cinza;
        private System.Windows.Forms.GroupBox Grp_B_Bool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Rdo_XOR;
        private System.Windows.Forms.RadioButton Rdo_OR;
        private System.Windows.Forms.RadioButton Rdo_AND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Imagem01;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Imagem02;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Aplicar_Ar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.ComponentModel.BackgroundWorker Thread_Aritmetica;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Aplicar_Filtro;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Aplica_Bool;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmbb_Correcao;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown Num_UpDown_Limiar;
        private System.Windows.Forms.ComboBox Cmbb_Imagem_Constante;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Salvar;
        private System.Windows.Forms.ComboBox Cmb_Bordas;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown Num_UpDown_Alta;
        private System.Windows.Forms.CheckBox Chkb_Blur_Pesos;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown Num_UpDown_Blur;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown Num_UpDown_Laplace;
        private System.Windows.Forms.RadioButton Rdo_PassaAlta;
        private System.Windows.Forms.RadioButton Rdo_Laplace;
        private System.ComponentModel.BackgroundWorker Thread_Booleana;
        private System.ComponentModel.BackgroundWorker Thread_Filtros;
        private System.Windows.Forms.ComboBox Cmb_Linhas;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown Num_UpDown_ValorOp;
        private System.Windows.Forms.ComboBox Cmbb_Operacoes;
        private System.Windows.Forms.Label Lbl_Operacoes;
        private System.Windows.Forms.Label label9;
    }
}

