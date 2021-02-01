using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.ToolGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_ZJY.Threads
{
    class Class1
    {
        private static int execl =1;
        private static int img =1;
        private static int file =1;
        private static string password = "";
        private static int selectorzjy = 0;    //0表示未加载，1表示ZJY,2表示Select
        private static CogToolGroup cogToolGroup = null;
        private static CogToolBlock cogToolBlock = null;
        private static CogJobManager cogJobManager = null;

        public static int Execl { get => execl; set => execl = value; }
        public static int Img { get => img; set => img = value; }
        public static int File { get => file; set => file = value; }
        public static string Password { get => password; set => password = value; }
        public static int Selectorzjy { get => selectorzjy; set => selectorzjy = value; }
        public static CogToolGroup CogToolGroup { get => cogToolGroup; set => cogToolGroup = value; }
        public static CogToolBlock CogToolBlock { get => cogToolBlock; set => cogToolBlock = value; }
        public static CogJobManager CogJobManager { get => cogJobManager; set => cogJobManager = value; }
    }
}
