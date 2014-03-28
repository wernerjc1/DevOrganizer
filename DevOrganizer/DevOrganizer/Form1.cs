using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Shell;
using System.IO;

namespace DevOrganizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onSearchButtonClick(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == addTab)
            {
                ;
            }
            else if (this.tabControl1.SelectedTab == DatabaseTab)
            {
                DatabaseTab.Text = "HOOOO";
            }
        }

    }
}
