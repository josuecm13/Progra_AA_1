namespace Progra_AA_1
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Manhattan = new System.Windows.Forms.RadioButton();
            this.btn_Propio = new System.Windows.Forms.RadioButton();
            this.lbl_mutacion = new System.Windows.Forms.Label();
            this.lbl_cruce = new System.Windows.Forms.Label();
            this.lbl_Pob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_population = new System.Windows.Forms.TextBox();
            this.txt_prbCross = new System.Windows.Forms.ComboBox();
            this.txt_prpMut = new System.Windows.Forms.ComboBox();
            this.txt_gens = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageSelecter = new System.Windows.Forms.Button();
            this.txt_Genes_a_mutar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_selection = new System.Windows.Forms.ComboBox();
            this.btn_ColorH = new System.Windows.Forms.RadioButton();
            this.btn_Histo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(182, 21);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(172, 17);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Aproximador de Imágenes";
            // 
            // btn_Manhattan
            // 
            this.btn_Manhattan.AutoSize = true;
            this.btn_Manhattan.Location = new System.Drawing.Point(6, 21);
            this.btn_Manhattan.Name = "btn_Manhattan";
            this.btn_Manhattan.Size = new System.Drawing.Size(147, 21);
            this.btn_Manhattan.TabIndex = 1;
            this.btn_Manhattan.TabStop = true;
            this.btn_Manhattan.Text = "Método Manhattan";
            this.btn_Manhattan.UseVisualStyleBackColor = true;
            this.btn_Manhattan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_Propio
            // 
            this.btn_Propio.AutoSize = true;
            this.btn_Propio.Location = new System.Drawing.Point(7, 55);
            this.btn_Propio.Name = "btn_Propio";
            this.btn_Propio.Size = new System.Drawing.Size(170, 21);
            this.btn_Propio.TabIndex = 2;
            this.btn_Propio.TabStop = true;
            this.btn_Propio.Text = "Método Darwin-Wallas";
            this.btn_Propio.UseVisualStyleBackColor = true;
            this.btn_Propio.CheckedChanged += new System.EventHandler(this.btn_Propio_CheckedChanged);
            // 
            // lbl_mutacion
            // 
            this.lbl_mutacion.AutoSize = true;
            this.lbl_mutacion.Location = new System.Drawing.Point(51, 148);
            this.lbl_mutacion.Name = "lbl_mutacion";
            this.lbl_mutacion.Size = new System.Drawing.Size(168, 17);
            this.lbl_mutacion.TabIndex = 4;
            this.lbl_mutacion.Text = "Probabilidad de mutación";
            // 
            // lbl_cruce
            // 
            this.lbl_cruce.AutoSize = true;
            this.lbl_cruce.Location = new System.Drawing.Point(51, 88);
            this.lbl_cruce.Name = "lbl_cruce";
            this.lbl_cruce.Size = new System.Drawing.Size(146, 17);
            this.lbl_cruce.TabIndex = 5;
            this.lbl_cruce.Text = "Probabilidad de cruce";
            // 
            // lbl_Pob
            // 
            this.lbl_Pob.AutoSize = true;
            this.lbl_Pob.Location = new System.Drawing.Point(51, 58);
            this.lbl_Pob.Name = "lbl_Pob";
            this.lbl_Pob.Size = new System.Drawing.Size(145, 17);
            this.lbl_Pob.TabIndex = 6;
            this.lbl_Pob.Text = "Tamaño de población";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Número de generaciones";
            // 
            // txt_population
            // 
            this.txt_population.Location = new System.Drawing.Point(278, 53);
            this.txt_population.Name = "txt_population";
            this.txt_population.Size = new System.Drawing.Size(100, 22);
            this.txt_population.TabIndex = 8;
            this.txt_population.Text = "100";
            // 
            // txt_prbCross
            // 
            this.txt_prbCross.FormattingEnabled = true;
            this.txt_prbCross.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.txt_prbCross.Location = new System.Drawing.Point(278, 81);
            this.txt_prbCross.Name = "txt_prbCross";
            this.txt_prbCross.Size = new System.Drawing.Size(100, 24);
            this.txt_prbCross.TabIndex = 9;
            this.txt_prbCross.Text = "80";
            this.txt_prbCross.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_prpMut
            // 
            this.txt_prpMut.FormattingEnabled = true;
            this.txt_prpMut.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.txt_prpMut.Location = new System.Drawing.Point(278, 141);
            this.txt_prpMut.Name = "txt_prpMut";
            this.txt_prpMut.Size = new System.Drawing.Size(100, 24);
            this.txt_prpMut.TabIndex = 10;
            this.txt_prpMut.Text = "46";
            this.txt_prpMut.SelectedIndexChanged += new System.EventHandler(this.txt_prpMut_SelectedIndexChanged);
            // 
            // txt_gens
            // 
            this.txt_gens.Location = new System.Drawing.Point(278, 171);
            this.txt_gens.Name = "txt_gens";
            this.txt_gens.Size = new System.Drawing.Size(100, 22);
            this.txt_gens.TabIndex = 11;
            this.txt_gens.Text = "100";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(583, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imageSelecter
            // 
            this.imageSelecter.Location = new System.Drawing.Point(441, 139);
            this.imageSelecter.Name = "imageSelecter";
            this.imageSelecter.Size = new System.Drawing.Size(236, 23);
            this.imageSelecter.TabIndex = 13;
            this.imageSelecter.Text = "Seleccionar Imagen";
            this.imageSelecter.UseVisualStyleBackColor = true;
            this.imageSelecter.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Genes_a_mutar
            // 
            this.txt_Genes_a_mutar.FormattingEnabled = true;
            this.txt_Genes_a_mutar.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.txt_Genes_a_mutar.Location = new System.Drawing.Point(278, 111);
            this.txt_Genes_a_mutar.Name = "txt_Genes_a_mutar";
            this.txt_Genes_a_mutar.Size = new System.Drawing.Size(100, 24);
            this.txt_Genes_a_mutar.TabIndex = 15;
            this.txt_Genes_a_mutar.Text = "30";
            this.txt_Genes_a_mutar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pocentaje de genes a mutar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Procentaje de Seleccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_selection
            // 
            this.txt_selection.FormattingEnabled = true;
            this.txt_selection.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.txt_selection.Location = new System.Drawing.Point(278, 199);
            this.txt_selection.Name = "txt_selection";
            this.txt_selection.Size = new System.Drawing.Size(100, 24);
            this.txt_selection.TabIndex = 17;
            this.txt_selection.Text = "5";
            // 
            // btn_ColorH
            // 
            this.btn_ColorH.AutoSize = true;
            this.btn_ColorH.Location = new System.Drawing.Point(243, 314);
            this.btn_ColorH.Name = "btn_ColorH";
            this.btn_ColorH.Size = new System.Drawing.Size(158, 21);
            this.btn_ColorH.TabIndex = 18;
            this.btn_ColorH.TabStop = true;
            this.btn_ColorH.Text = "Histograma de Color";
            this.btn_ColorH.UseVisualStyleBackColor = true;
            this.btn_ColorH.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // btn_Histo
            // 
            this.btn_Histo.AutoSize = true;
            this.btn_Histo.Location = new System.Drawing.Point(243, 348);
            this.btn_Histo.Name = "btn_Histo";
            this.btn_Histo.Size = new System.Drawing.Size(146, 21);
            this.btn_Histo.TabIndex = 19;
            this.btn_Histo.TabStop = true;
            this.btn_Histo.Text = "Histograma Propio";
            this.btn_Histo.UseVisualStyleBackColor = true;
            this.btn_Histo.CheckedChanged += new System.EventHandler(this.btn_Histo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Manhattan);
            this.groupBox1.Controls.Add(this.btn_Propio);
            this.groupBox1.Location = new System.Drawing.Point(47, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 82);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Histo);
            this.Controls.Add(this.btn_ColorH);
            this.Controls.Add(this.txt_selection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Genes_a_mutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageSelecter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_gens);
            this.Controls.Add(this.txt_prpMut);
            this.Controls.Add(this.txt_prbCross);
            this.Controls.Add(this.txt_population);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Pob);
            this.Controls.Add(this.lbl_cruce);
            this.Controls.Add(this.lbl_mutacion);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "MainMenu";
            this.Text = "Aproximador de Imágenes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.RadioButton btn_Manhattan;
        private System.Windows.Forms.RadioButton btn_Propio;
        private System.Windows.Forms.Label lbl_mutacion;
        private System.Windows.Forms.Label lbl_cruce;
        private System.Windows.Forms.Label lbl_Pob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_population;
        private System.Windows.Forms.ComboBox txt_prbCross;
        private System.Windows.Forms.ComboBox txt_prpMut;
        private System.Windows.Forms.TextBox txt_gens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button imageSelecter;
        private System.Windows.Forms.ComboBox txt_Genes_a_mutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_selection;
        private System.Windows.Forms.RadioButton btn_ColorH;
        private System.Windows.Forms.RadioButton btn_Histo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

