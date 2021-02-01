using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro.ToolGroup;
using Cognex.VisionPro.ToolBlock;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;
using NPOI.HSSF.UserModel;
using WindowsFormsApp_ZJY.Threads;

namespace WindowsFormsApp_ZJY
{

    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        //加载Job
        private void LoadCogJobManager(CogJobManagerEdit cogJobManagerEdit, string path)
        {
            try
            {
                //Thread threadZJY = new Thread(delegate (){     //创建线程
                Class1.CogJobManager = (CogJobManager)CogSerializer.LoadObjectFromFile(Application.StartupPath + path);
                cogJobManagerEdit1.Subject = Class1.CogJobManager;
                // });
                //threadZJY.Priority = ThreadPriority.Lowest;   //线程优先级
                //threadZJY.Start();
            }
            catch(FileNotFoundException f)
            {
                MessageBox.Show(f.FileName+"该路径下没有此文件");
            }
        }
        //重写加载Job
        private void LoadCogJobManager(string path)
        {
            try
            {
                Class1.CogJobManager = (CogJobManager)CogSerializer.LoadObjectFromFile(Application.StartupPath + path);
            }
            catch (FileNotFoundException f)
            {
                MessageBox.Show(f.FileName + "该路径下没有此文件");
            }
        }

        //保存图像，自定义文件名
        private void SaveImg(CogRecordDisplay cogRecordDisplay, string path)
        {
            if (cogRecordDisplay.Image == null)   //判断是否有图片
                return;
            if (!Directory.Exists(Application.StartupPath + path))    //如果没有同名文件夹，就创建一个文件夹
            {
                Directory.CreateDirectory(Application.StartupPath + path);
            }
            //保存图片至文件（24位位图）
            Image image = default(Image);
            image = cogRecordDisplay.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image, null, 0);
            image.Save(Application.StartupPath + path + DateTime.Now.ToString("yyyyMMddhhmmssff") + ".png", ImageFormat.Bmp);  //路径、时间、格式
        }
        //重写保存图像，自动生成时间的文件，并保存
        private void SaveImg(CogRecordDisplay cogRecordDisplay)
        {
            if (cogRecordDisplay.Image == null)   //判断是否有图片
                return;
            //如果没有同名文件夹，就创建一个文件夹
            if (!Directory.Exists(Application.StartupPath + "\\file\\image\\" + DateTime.Now.ToString("yyyyMMdd") + "\\"))   //时间文件名的文件夹
            {
                Directory.CreateDirectory(Application.StartupPath + "\\file\\image\\" + DateTime.Now.ToString("yyyyMMdd") + "\\");
            }
            //保存图片至文件（24位位图）
            Image image = default(Image);
            image = cogRecordDisplay.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image, null, 0);
            image.Save(Application.StartupPath + "\\file\\image\\" + DateTime.Now.ToString("yyyyMMdd") + "\\" + DateTime.Now.ToString("yyyyMMddhhmmssff") + ".png", ImageFormat.Bmp);  //路径、时间、格式
        }

        //写入数据，自定义文件名
        private void SaveFile(string txt, string path)
        {
            if (txt.Length == 0)  //判断输入数据是否为空
            {
                MessageBox.Show("传入的数据为空");
            }
            else
            {
                //指定的字符串追加到文件中，如果文件还不存在则创建该文件
                File.AppendAllText(Application.StartupPath + path, DateTime.Now.ToString("yyyyMMddhhmmssff") + "：" + txt, Encoding.UTF8);
            }
        }
        //重写写入数据方法，自动生成时间的文件
        private void SaveFile(string txt)
        {
            if (txt.Length == 0)  //判断输入数据是否为空
            {
                MessageBox.Show("传入的数据为空");
            }
            else
            {
                //指定的字符串追加到文件中，如果文件还不存在则创建该文件
                File.AppendAllText(Application.StartupPath + "\\file\\result\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt",
                    "\r\n" + DateTime.Now.ToString("hh" + ":" + "mm" + ":" + "ss") + "\r\n" + txt, Encoding.UTF8);
            }
        }

        //保存至表格
        private void SaveExcel(string str)
        {
            string path = Application.StartupPath + "\\file\\excel\\" + DateTime.Now.ToString("yyyyMMdd") + ".xls";
            HSSFWorkbook hSSFWorkbook = new HSSFWorkbook();
            if (!File.Exists(path))    //判断是否有同名表格
            {
                //新建表格
                var sheet = hSSFWorkbook.CreateSheet(DateTime.Now.ToString("yyyyMMdd"));  //创建日期的excel表格

                var row = sheet.CreateRow(0);  //创建0行
                var row1 = sheet.CreateRow(1);
                for (int i = 0; i < str.Length; i++)
                {
                    var a = row.CreateCell(i);  //行中第一个数据
                    a.SetCellValue(i + 1);   //内容
                    var text = row1.CreateCell(i);
                    text.SetCellValue(str[i] - 48);  //
                }
                FileStream file = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                hSSFWorkbook.Write(file);
                file.Dispose();
            }
            else
            {
                FileStream file = new FileStream(path, FileMode.OpenOrCreate);   //读取流
                HSSFWorkbook workbook = new HSSFWorkbook(file);
                var sheet1 = workbook.GetSheetAt(0);
                int num = sheet1.LastRowNum + 1;  //最大行数
                FileStream filein = new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.ReadWrite); //写入流
                //获取到已存在的sheet
                var sheet = workbook.GetSheet(DateTime.Now.ToString("yyyyMMdd"));
                //把xls文件读入workbook变量里
                var row = sheet.CreateRow(num);  //创建最大行数
                for (int i = 0; i < str.Length; i++)
                {
                    var a = row.CreateCell(i);  //创建行中第一个数据
                    a.SetCellValue(str[i] - 48);   //内容
                }
                workbook.Write(filein);
                file.Close();
                filein.Close();
            }
        }


        //菜单栏
        private void jobZJYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            buttonDanCi.Visible = true;
            buttonLianXu.Visible = true;
            LoadCogJobManager(cogJobManagerEdit1, "\\vpp\\QuickBuild_ZJY.vpp");
            Class1.Selectorzjy = 1;
        }
        private void jobSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            buttonDanCi.Visible = true;
            buttonLianXu.Visible = true;
            LoadCogJobManager(cogJobManagerEdit1, "\\vpp\\QuickBuildSelect.vpp");
            Class1.Selectorzjy = 2;

        }
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSave form2 = new FormSave();
            form2.ShowDialog();
        }
        private void 文件位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\file";
            System.Diagnostics.Process.Start("explorer.exe", path);
        }
        private void 用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }


        //窗体事件
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            LoadCogJobManager(cogJobManagerEdit1, "\\vpp\\QuickBuildAll.vpp");  //调用方法加载Job

            menuStrip1.Items[0].Visible = false;
            menuStrip1.Items[2].Visible = false;
            menuStrip1.Items[3].Visible = false;
            buttonDanCi.Visible = false;
            buttonLianXu.Visible = false;
            //线程实例化
            Threads.ThreadMain threadMain = new Threads.ThreadMain();
            threadMain.runthread(this, getstr, add);
        }


        //触发
        private void buttonDanCi_Click(object sender, EventArgs e)  //单次触发
        {
            switch (Class1.Selectorzjy)
            {
                case 1:
                    ZJYContent();
                    break;
                case 2:
                    SelectContent();
                    break;
            }
        }
        private void buttonLianXu_Click(object sender, EventArgs e)   //多次触发（连续五下）
        {
            switch (Class1.Selectorzjy)
            {
                case 1:
                    for (int zjyNum = 0; zjyNum < 5; zjyNum++)
                    {
                        ZJYContent();
                    }
                    break;
                case 2:
                    for (int selNum = 0; selNum < 5; selNum++)
                    {
                        SelectContent();
                    }
                    break;
            }
        }


        //触发时的内容
        private void SelectContent()
        {
            Class1.CogJobManager.Run();       //Class1.CogJobManager.RunContinuous();  连续运行作业
            while(true)    //更新运行状态
            {
                Thread.Sleep(1);  //线程延迟
                //获取实时运行状态，当运行状态为CogJobsRunningStateConstants.None，没有事件运行
                if (Class1.CogJobManager.JobsRunningState.ToString().Equals("None"))
                {
                    Class1.CogToolGroup = cogJobManagerEdit1.Subject.Job("CogJobSelect").VisionTool as CogToolGroup;
                    Class1.CogToolBlock = Class1.CogToolGroup.Tools["CogToolBlock1"] as CogToolBlock;   //调用CogToolBlock1
                    ICogRecord cogRecord = Class1.CogToolBlock.CreateLastRunRecord();   //job中的CogToolBlock1创建结果图像
                    cogRecordDisplay1.Record = cogRecord.SubRecords[1];   //取出序号为n的图像
                    cogRecordDisplay1.Fit(true);     //图像显示控件图像自适应大小
                    panel1.Show();

                    if (Class1.Img == 1)
                    {
                        SaveImg(cogRecordDisplay1);      //调用图片保存至文件的方法
                    }

                    Class1.CogToolBlock = Class1.CogToolGroup.Tools["CogToolBlock2"] as CogToolBlock;
                    string text = Class1.CogToolBlock.Outputs["Output"].Value.ToString();
                    if (Class1.File == 1)
                    {
                        SaveFile(text);  //调用数据写入文件的方法
                    }

                    string file = Class1.CogToolBlock.Outputs["Text"].Value.ToString();
                    if (Class1.Execl == 1)
                    {
                        SaveExcel(file);
                    }
                    return;
                }
            }
        }
        private void ZJYContent()
        {
            Class1.CogJobManager.Run();
            while(true)    //更新运行状态
            {
                Thread.Sleep(1);  //线程延迟
                //获取实时运行状态，当运行状态为None，没有事件运行
                if (Class1.CogJobManager.JobsRunningState == CogJobsRunningStateConstants.None)
                {
                    Class1.CogToolGroup = cogJobManagerEdit1.Subject.Job("CogJob_ZJY").VisionTool as CogToolGroup;
                    Class1.CogToolBlock = Class1.CogToolGroup.Tools["CogToolBlock1"] as CogToolBlock;
                    ICogRecord cogRecord = Class1.CogToolBlock.CreateLastRunRecord();
                    cogRecordDisplay1.Record = cogRecord.SubRecords[1];
                    cogRecordDisplay1.Fit(true);
                    panel1.Show();

                    Double C = (System.Double)Class1.CogToolBlock.Outputs["Distance1"].Value;
                    MessageBox.Show("距离为：" + C.ToString());
                    return;
                }
            }
        }




        public void add()  //线程需要执行的方法
        {
            Threads.text t = new Threads.text(getstr);
            while (true)
            {
                try
                {
                    Invoke(t, DateTime.Now.ToString("yyyy" + "年" + "MM" + "月" + "dd" + "日" + "\n" + "hh" + "：" + "mm" + "\n" + "ss" + ":" + "ff"));
                    Thread.Sleep(1000);
                }
                catch(InvalidOperationException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public void getstr(string str) //更新UI方法
        {
            this.label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)     //测试
        {
            if (textBox1.Text.Equals("0"))
            {
                // buttonLianXu_Click(sender, e);
                // textBox1.Text = "";
                //listView1.Items.Add(DateTime.Now.ToString("yyyyMMddhhmmss")+"运行正常");
                listView1.Items.Add(DateTime.Now.ToString("yyyyMMddhhmmss") + "运行失败");
                textBox1.Text = "";
            }
            else if (textBox1.Text.Equals("1"))
            {
                buttonDanCi_Click(sender, e);
                textBox1.Text = "";
                listView1.Items.Add(DateTime.Now.ToString("yyyyMMddhhmmss") + "运行正常");
            }
            else
            {
                MessageBox.Show("输入的格式错误，只能是0或1");
            }
        }
    }
}
