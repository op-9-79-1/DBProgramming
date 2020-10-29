using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement3
{
    public partial class ConfigManager : StudentManagement3.MainForm
    {

        private static ConfigManager instance_ = new ConfigManager();

        public static ConfigManager GetInstance()
        {
            return instance_;
        }

        private ConfigManager()
        {

        }

        public int GetRecentlyUsedListIdx()
        {
            //int index = Properties.Settings.Default.index_set;
            int index = 3;
            return index;
        }
    }
}
