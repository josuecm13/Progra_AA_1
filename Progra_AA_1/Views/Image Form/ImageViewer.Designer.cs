namespace Progra_AA_1.Views.Image_Form
{
    partial class ImageViewer
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
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.randomPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_console = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Location = new System.Drawing.Point(12, 12);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(395, 385);
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // randomPicBox
            // 
            this.randomPicBox.Location = new System.Drawing.Point(526, 12);
            this.randomPicBox.Name = "randomPicBox";
            this.randomPicBox.Size = new System.Drawing.Size(442, 385);
            this.randomPicBox.TabIndex = 1;
            this.randomPicBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imagen Destino";
            // 
            // txtbox_console
            // 
            this.txtbox_console.Location = new System.Drawing.Point(526, 415);
            this.txtbox_console.Name = "txtbox_console";
            this.txtbox_console.Size = new System.Drawing.Size(442, 96);
            this.txtbox_console.TabIndex = 3;
            this.txtbox_console.Text = "";
            this.txtbox_console.TextChanged += new System.EventHandler(this.txtbox_console_TextChanged);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 523);
            this.Controls.Add(this.txtbox_console);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomPicBox);
            this.Controls.Add(this.originalPictureBox);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox randomPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtbox_console;
    }
}