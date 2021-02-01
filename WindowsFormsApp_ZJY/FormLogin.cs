using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp_ZJY.Threads;

namespace WindowsFormsApp_ZJY
{
    public partial class FormLogin : Form
    {
        private FormMain UserformMain;  //FormMain窗体
        public FormLogin(FormMain formMain)   //调用FormMain窗体
        {
            InitializeComponent();
            UserformMain = formMain;   
        }
        public void Read(string path)    //读取密码
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\user\\" + path, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                Class1.Password = line.ToString();
            }
            sr.Close();
        }
        private void WriteForTxt(string path, string contentSrt)  //写入密码
        {
            FileStream fs = new FileStream(Application.StartupPath + "\\user\\" + path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter wr = null;
            wr = new StreamWriter(fs);
            wr.WriteLine(contentSrt);
            wr.Flush(); //把所有缓冲区内容清理,并写入基础流
            wr.Close();
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("没有选中用户");
            }else
            {
            if (comboBox1.SelectedItem.Equals("游客"))
                {
                    this.Close();  //关闭窗体
                    UserformMain.menuStrip1.Items[0].Visible = false;   //调用formmain中控件，将私有属性变成公共属性
                    UserformMain.menuStrip1.Items[2].Visible = false;
                    UserformMain.menuStrip1.Items[3].Visible = false;
                }
                else if (comboBox1.SelectedItem.Equals("用户"))
                {
                    Read("UserPassword.txt");
                    if (textBox1.Text.Equals(Class1.Password))
                    {
                        // MessageBox.Show("登陆成功");
                        Class1.Password = "";
                        this.Close();  //关闭窗体
                        UserformMain.menuStrip1.Items[0].Visible = true;
                        UserformMain.menuStrip1.Items[2].Visible = true;
                        UserformMain.menuStrip1.Items[3].Visible = true;
                    }
                    else
                    {
                        textBox1.Text = "";
                        MessageBox.Show("密码错误");
                    }
                }
                else if (comboBox1.SelectedItem.Equals("管理员"))
                {
                    Read("AdminPassword.txt");
                    if (textBox1.Text.Equals(Class1.Password))
                    {
                        // MessageBox.Show("登陆成功");
                        Class1.Password = "";
                        this.Close();  //关闭窗体
                        UserformMain.menuStrip1.Items[0].Visible = true;
                        UserformMain.menuStrip1.Items[2].Visible = true;
                        UserformMain.menuStrip1.Items[3].Visible = true;
                    }
                    else
                    {
                        textBox1.Text = "";
                        MessageBox.Show("密码错误");

                    }
                }

            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            button2.Enabled = false;
            Class1.Password = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("用户"))
            {
                if (textBox2.Text.Equals(""))
                {
                    MessageBox.Show("输入的密码为空");
                }
                else
                {
                    WriteForTxt("UserPassword.txt", textBox2.Text);
                    MessageBox.Show("保存成功");
                    panel1.Hide();
                }
            }
            else if (comboBox1.SelectedItem.Equals("管理员"))
            {
                if (textBox2.Text.Equals(""))
                {
                    MessageBox.Show("输入的密码为空");
                }
                else
                {
                    WriteForTxt("AdminPassword.txt", textBox2.Text);
                    MessageBox.Show("保存成功");
                    panel1.Hide();
                }
            }  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString()) //获取选择的内容
            {

                case "游客": panel2.Hide(); button2.Enabled = false; break;

                case "用户": panel2.Show(); button2.Enabled = true; break;

                case "管理员": panel2.Show(); button2.Enabled = true; break;

            }
        }
    }
}
