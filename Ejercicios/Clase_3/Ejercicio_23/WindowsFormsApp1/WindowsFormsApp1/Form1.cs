using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.txtCoso.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//44622.png");
            this.btnHacerAlgo.ImageList = new ImageList();

            this.btnHacerAlgo.ImageList.Images.Add("cerrado", image);

            Image image2 = Image.FromFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "61355.png"));
            this.btnHacerAlgo.ImageList.Images.Add("abierto", image);

            if (this.btnHacerAlgo.ImageKey == "abierto")
            {
                this.btnHacerAlgo.ImageKey = "cerrado";
                this.txtCoso.Enabled = false;

            }
            else
            {
                this.btnHacerAlgo.ImageKey = "abierto";
                this.txtCoso.Enabled = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
