using System;
using System.Windows.Forms;
using WindowsFormsApp_ZJY.Threads;

namespace WindowsFormsApp_ZJY
{
    public partial class FormSave : Form
    {
        
        public FormSave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            if (radioButton1.Checked)
            {
                Class1.Img = 1;
            }else if (radioButton2.Checked)
            {
                Class1.Img = 0;
            }else if (radioButton3.Checked)
            {
                Class1.File = 1;
            }else if (radioButton4.Checked)
            {
                Class1.File = 0;
            }else if (radioButton5.Checked)
            {
                Class1.Execl = 1;
            }else if (radioButton6.Checked)
            {
                Class1.Execl = 0;
            }
            MessageBox.Show("保存成功");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Class1.Img == 1)
            {
                radioButton1.Checked = true;
            }
            else if (Class1.Img == 0)
            {
                radioButton2.Checked = true;
            }
            else if (Class1.File == 1)
            {
                radioButton3.Checked = true;
            }
            else if (Class1.File == 0)
            {
                radioButton4.Checked = true;
            }
            else if (Class1.Execl ==1)
            {
                radioButton5.Checked = true;
            }
            else if (Class1.Execl == 0)
            {
                radioButton6.Checked = true;
            }
        }
    }
}
