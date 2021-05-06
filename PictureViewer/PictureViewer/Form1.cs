using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //show the open file dialog.if the user clicks ok,load the picture that the user chose
            if ( openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            } 
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the picture
            pictureBox1.Image=null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //show the color dialog box.if the user clicks ok,change the pictureBox control's background
            //to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if the user selects the stretch check box,change the pictureBox's
            //sizeMode property to "stretch",if the user clears the check box,change it to "Normal"
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
