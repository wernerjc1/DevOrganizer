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

        private void explorerBrowser1_Load(object sender, EventArgs e)
        {
            explorerBrowser1.Navigate((ShellObject)KnownFolders.Desktop);
        }

        private void onSearchButtonClick(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == addTab)
            {
                try
                {
                    // navigate to specific folder
                    explorerBrowser1.Navigate(ShellFileSystemFolder.FromFolderPath(SearchBox.Text));
                }
                catch
                {
                    try
                    {
                        string newPath = Path.GetFullPath(SearchBox.Text);// Directory.GetCurrentDirectory();
                        //explorerBrowser1.
                        //newPath += "\\";
                        //newPath += SearchBox.Text;
                        addTab.Text = newPath;
                        explorerBrowser1.Navigate(ShellFileSystemFolder.FromFolderPath(newPath));

                    }
                    catch
                    {
                        MessageBox.Show("Navigation not possible.");
                    }
                }
            }
            else if (this.tabControl1.SelectedTab == DatabaseTab)
            {
                DatabaseTab.Text = "HOOOO";
            }
        }

    }
}
