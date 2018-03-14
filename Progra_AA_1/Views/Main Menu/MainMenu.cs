using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progra_AA_1.Views.Image_Form;
using System.Windows.Forms;
using System.Threading;

namespace Progra_AA_1
{
    public partial class MainMenu : Form
    {

        string path;
        int distanceOption;
        int histOption;

        public MainMenu()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            distanceOption = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageViewer form = new ImageViewer();
            form.SetDesireImage(path);
            form.SetComponents(Int32.Parse(txt_population.Text), Int32.Parse(txt_gens.Text), Int32.Parse(txt_prpMut.Text), Int32.Parse(txt_prbCross.Text), distanceOption, int.Parse(txt_Genes_a_mutar.Text), int.Parse(txt_selection.Text),new Bitmap(path), histOption);
            form.Show();
            Thread t = new Thread(new ThreadStart(form.Run));
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                button1.Enabled = true;
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btn_Propio_CheckedChanged(object sender, EventArgs e)
        {
            distanceOption = 1;
        }

        private void txt_prpMut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            histOption = 0;
        }

        private void btn_Histo_CheckedChanged(object sender, EventArgs e)
        {
            histOption = 1;
        }
    }
}
