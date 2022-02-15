using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace RegistrationAndLogin
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string qrtext = textBox1.Text; 
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(qrtext);
            pictureBox1.Image = qrcode as Image;
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; 
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                pictureBox1.Image.Save(save.FileName); 
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                pictureBox1.ImageLocation = load.FileName; 
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder(); 
            MessageBox.Show(decoder.decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap))); 
        }
    }


}
    


