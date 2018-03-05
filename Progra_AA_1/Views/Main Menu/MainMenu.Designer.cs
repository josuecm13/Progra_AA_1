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
            this.txt_poblacion = new System.Windows.Forms.TextBox();
            this.probaCruce = new System.Windows.Forms.ComboBox();
            this.probaMuta = new System.Windows.Forms.ComboBox();
            this.txt_gens = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageSelecter = new System.Windows.Forms.Button();
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
            this.btn_Manhattan.Location = new System.Drawing.Point(54, 260);
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
            this.btn_Propio.Location = new System.Drawing.Point(54, 297);
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
            this.lbl_mutacion.Location = new System.Drawing.Point(51, 153);
            this.lbl_mutacion.Name = "lbl_mutacion";
            this.lbl_mutacion.Size = new System.Drawing.Size(168, 17);
            this.lbl_mutacion.TabIndex = 4;
            this.lbl_mutacion.Text = "Probabilidad de mutación";
            // 
            // lbl_cruce
            // 
            this.lbl_cruce.AutoSize = true;
            this.lbl_cruce.Location = new System.Drawing.Point(51, 120);
            this.lbl_cruce.Name = "lbl_cruce";
            this.lbl_cruce.Size = new System.Drawing.Size(146, 17);
            this.lbl_cruce.TabIndex = 5;
            this.lbl_cruce.Text = "Probabilidad de cruce";
            // 
            // lbl_Pob
            // 
            this.lbl_Pob.AutoSize = true;
            this.lbl_Pob.Location = new System.Drawing.Point(51, 84);
            this.lbl_Pob.Name = "lbl_Pob";
            this.lbl_Pob.Size = new System.Drawing.Size(145, 17);
            this.lbl_Pob.TabIndex = 6;
            this.lbl_Pob.Text = "Tamaño de población";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Número de generaciones";
            // 
            // txt_poblacion
            // 
            this.txt_poblacion.Location = new System.Drawing.Point(240, 84);
            this.txt_poblacion.Name = "txt_poblacion";
            this.txt_poblacion.Size = new System.Drawing.Size(100, 22);
            this.txt_poblacion.TabIndex = 8;
            this.txt_poblacion.Text = "40";
            // 
            // probaCruce
            // 
            this.probaCruce.FormattingEnabled = true;
            this.probaCruce.Items.AddRange(new object[] {
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
            this.probaCruce.Location = new System.Drawing.Point(240, 117);
            this.probaCruce.Name = "probaCruce";
            this.probaCruce.Size = new System.Drawing.Size(100, 24);
            this.probaCruce.TabIndex = 9;
            this.probaCruce.Text = "20";
            this.probaCruce.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // probaMuta
            // 
            this.probaMuta.FormattingEnabled = true;
            this.probaMuta.Items.AddRange(new object[] {
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
            this.probaMuta.Location = new System.Drawing.Point(240, 153);
            this.probaMuta.Name = "probaMuta";
            this.probaMuta.Size = new System.Drawing.Size(100, 24);
            this.probaMuta.TabIndex = 10;
            this.probaMuta.Text = "29";
            // 
            // txt_gens
            // 
            this.txt_gens.Location = new System.Drawing.Point(240, 185);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 392);
            this.Controls.Add(this.imageSelecter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_gens);
            this.Controls.Add(this.probaMuta);
            this.Controls.Add(this.probaCruce);
            this.Controls.Add(this.txt_poblacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Pob);
            this.Controls.Add(this.lbl_cruce);
            this.Controls.Add(this.lbl_mutacion);
            this.Controls.Add(this.btn_Propio);
            this.Controls.Add(this.btn_Manhattan);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form1";
            this.Text = "Aproximador de Imágenes";
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
        private System.Windows.Forms.TextBox txt_poblacion;
        private System.Windows.Forms.ComboBox probaCruce;
        private System.Windows.Forms.ComboBox probaMuta;
        private System.Windows.Forms.TextBox txt_gens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button imageSelecter;
    }
}

