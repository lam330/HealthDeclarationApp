using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace First_GUI 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void LoadQrcode()
        {
            //convert text => Qr
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //data from input textbox
            string name = tb_name.Text;
            int age = int.Parse(tb_age.Text);
            string address = tb_address.Text;

            //show thanks
            //MessageBox.Show("Thank you (^-^)", "", MessageBoxButtons.OK);
            //checkbox process
            string signsResult = "";
            int count = 0;
            if(ckb_temp.Checked || ckb_cough.Checked ||ckb_headache.Checked)
            {
                //+ chuoi
                //test func
                if(ckb_temp.Checked)
                {
                    if(count == 0)
                    {
                        signsResult += "high temperature";
                        count++;
                    }
                    else
                    {
                        signsResult += ",high temperature";
                    }
                    
                }
                if(ckb_cough.Checked)
                {
                    
                    if (count == 0)
                    {
                        signsResult += "cough";
                        count++;
                    }
                    else
                    {
                        signsResult += ",cough";
                    }
                }
                if(ckb_headache.Checked)
                {
                    if (count == 0)
                    {
                        signsResult += "headache";
                        count++;
                    }
                    else
                    {
                        signsResult += ",headache";
                    }
                }
                string title = "Thanks for information";
                string message = "Name: {0} \n Age: {1} \n Address: {2} \n Illness's signs: {3} ";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(string.Format(message, name, age, address, signsResult), title,buttons ,
                    MessageBoxIcon.Information) ;
                //handle user choose
                if(result==DialogResult.OK)
                {
                    //Create QR Code
                    QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                    string finalString = "Name: " + name + '\n' +
                                         "Age: " + tb_age.Text + '\n' +
                                         "Signs of illness: " + signsResult;

                    var myData = QG.CreateQrCode(finalString, QRCoder.QRCodeGenerator.ECCLevel.H);
                    var code = new QRCoder.QRCode(myData);
                    pb_QR.Image = code.GetGraphic(50);

                    //save File
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            pb_QR.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                        }
                    }
                }
                else
                {
                    //clear contents 
                    tb_name.Text = string.Empty;
                    tb_age.Text = string.Empty;
                    tb_address.Text = string.Empty;
                }
                
            }
            

           
    
            
            

            LoadQrcode();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            string html = http.Get("https://www.howkteam.vn/").ToString();
            MessageBox.Show(html);

            File.WriteAllText("res.html", html);
        }
    }
}
