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

namespace Progra_AA_1
{
    public partial class MainMenu : Form
    {

        string path;
        int distanceOption;

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
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
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
    }
}
