using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           string _img = "http://www.digitalwuhan.gov.cn:8399/arcgis/rest/services/LAKE2000/MapServer/export?dpi=96&transparent=true&format=png8&bbox=114.37389085517776%2C30.159344810076078%2C114.58439766114068%2C30.319793677199257&bboxSR=4490&imageSR=4490&size=799%2C609&f=image";
            Image imm = imagefromurl(_img);
            pictureBox1.Image = imm;

        }
        private Image imagefromurl(string url)
        {
            Image img = null;
            HttpWebRequest r = (HttpWebRequest)WebRequest.Create(url);
            using (WebResponse wr = r.GetResponse())
            {
                img = Image.FromStream(wr.GetResponseStream());
            }
            return img;
        }
        string a = "http://www.digitalwuhan.gov.cn:8399/arcgis/rest/services/LAKE2000/MapServer/export?dpi=96&transparent=true&format=png8&bbox=114.37389085517776%2C30.159344810076078%2C114.58439766114068%2C30.319793677199257&bboxSR=4490&imageSR=4490&size=799%2C609&f=image";
        string b= "http://www.digitalwuhan.gov.cn:8399/arcgis/rest/services/LAKE2000/MapServer/export?dpi=96&transparent=true&format=png8&&bbox=";
        string c = "114.37389085517776%2C30.159344810076078%2C114.58439766114068%2C30.319793677199257";
        string d = "&bboxSR=4490&imageSR=4490&size=799%2C609&f=image";
        double e1 = 114.37389085517776;
        double e2 = 114.58439766114068;
        double f1 = 30.159344810076078;
        double f2 = 30.319793677199257;
        private void button1_Click(object sender, EventArgs e)
        {            
            f1 = f1 + 0.005;
            f2 = f2 + 0.005;
            string f11 = f1.ToString();
            string f22 = f2.ToString();
            c = e1 + "%2C"+f11 + "%2C"+ e2 + "%2C" + f22;
            a = b + c + d;
            Image imm = imagefromurl(a);
            pictureBox1.Image = imm;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            f1 = f1-0.005;          
            f2 = f2-0.005;
            string f11 = f1.ToString();
            string f22 = f2.ToString();
            c = e1 + "%2C" + f11 + "%2C" + e2 + "%2C" + f22;
            a = b + c + d;
            Image imm = imagefromurl(a);
            pictureBox1.Image = imm;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            e1 =e1 - 0.005;
            e2 =e2- 0.005;
            string e11 = e1.ToString();
            string e22 = e2.ToString();
            c = e11 + "%2C" + f1 + "%2C" + e22 + "%2C" + f2;
            a = b + c + d;
            Image imm = imagefromurl(a);
            pictureBox1.Image = imm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            e1 = e1 + 0.005;
            e2 = e2 + 0.005;
            string e11 = e1.ToString();
            string e22 = e2.ToString();
            c = e11 + "%2C" + f1 + "%2C" + e22 + "%2C" + f2;
            a = b + c + d;
            Image imm = imagefromurl(a);
            pictureBox1.Image = imm;
        }
    
      


    }
}
