﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_ZJY.Threads
{
    public delegate void text(string str); //定义一个用于更新UI的委托，需要传入一个字符串参数
    public delegate void threadmethod();//定义一个用于传入线程所运行的方法的委托，不需要参数
    class ThreadMain
    {
        Control control;//线程依赖对象，一般为窗体上下文
        text mymethod;//线程更新UI的方法，可以通过参数让用户自定义
        //第一个窗体上下文，直接传this即可，第二个更新UI的方法名，第三个线程执行的方法名
        public void runthread(Control con,text menthod, threadmethod method)
        {
            control = con; 
            mymethod = menthod;
      
            Thread thread = new Thread(new ThreadStart (method));
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
