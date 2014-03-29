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
                this.tabControl1.SelectedTab = DatabaseTab;
            }
            this.tabControl1.SelectedTab.Text = SearchBox.Text;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (FolderOption.Checked == true)
            {
                folderBrowserDialog1.ShowDialog();
                pathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                openFileDialog1.ShowDialog();
            }
        }

        private void FolderOption_Click(object sender, EventArgs e)
        {
            FileOption.Checked = false;
        }

        private void FileOption_Click(object sender, EventArgs e)
        {
            FolderOption.Checked = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pathTextBox.Text = openFileDialog1.FileName;
        }

        private void addTagButton_Click(object sender, EventArgs e)
        {
            if (tagsTextBox.Text != "")
            {
                tagsListBox.Items.Add(tagsTextBox.Text);
            }
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            if (authorsTextBox.Text != "")
            {
                authorsListBox.Items.Add(authorsTextBox.Text);
            }           
        }




    }
}
