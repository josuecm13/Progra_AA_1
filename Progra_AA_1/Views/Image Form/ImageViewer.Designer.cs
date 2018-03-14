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
            this.top10btn = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Location = new System.Drawing.Point(12, 12);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(442, 385);
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            this.originalPictureBox.Click += new System.EventHandler(this.originalPictureBox_Click_1);
            // 
            // randomPicBox
            // 
            this.randomPicBox.Location = new System.Drawing.Point(526, 12);
            this.randomPicBox.Name = "randomPicBox";
            this.randomPicBox.Size = new System.Drawing.Size(442, 385);
            this.randomPicBox.TabIndex = 1;
            this.randomPicBox.TabStop = false;
            this.randomPicBox.Click += new System.EventHandler(this.randomPicBox_Click);
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
            // top10btn
            // 
            this.top10btn.Location = new System.Drawing.Point(883, 526);
            this.top10btn.Name = "top10btn";
            this.top10btn.Size = new System.Drawing.Size(85, 41);
            this.top10btn.TabIndex = 4;
            this.top10btn.Text = "Top 10";
            this.top10btn.UseVisualStyleBackColor = true;
            this.top10btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInfo.Location = new System.Drawing.Point(526, 415);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(442, 92);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 579);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.top10btn);
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
        private System.Windows.Forms.Button top10btn;
        private System.Windows.Forms.Label labelInfo;
    }
}