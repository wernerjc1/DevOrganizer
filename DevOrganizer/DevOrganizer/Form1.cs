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
using System.Data.SqlClient;

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
            bool sameTag = false;

            foreach (object obj in tagsListBox.Items)
            {
                if (obj.ToString() == tagsTextBox.Text)
                    sameTag = true;
            }

            if (tagsTextBox.Text != "" && !sameTag)
            {
                tagsListBox.Items.Add(tagsTextBox.Text);
                tagsTextBox.Clear();
            }
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            bool sameAuthor = false;

            foreach (object obj in authorsListBox.Items)
            {
                if (obj.ToString() == authorsTextBox.Text)
                    sameAuthor = true;
            }

            if (authorsTextBox.Text != "" && !sameAuthor)
            {
                authorsListBox.Items.Add(authorsTextBox.Text);
                authorsTextBox.Clear();
            }           
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                onSearchButtonClick(sender, e);
            }
        }

        private void tagsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addTagButton_Click(sender, e);
            }
        }

        private void authorsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addAuthorButton_Click(sender, e);
            }
        }

        private void tagsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                tagsListBox.Items.Remove(tagsListBox.SelectedItem);
            }
        }

        private void authorsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                authorsListBox.Items.Remove(authorsListBox.SelectedItem);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'devOrgDBDataSet.FileTags' table. You can move, or remove it, as needed.
            this.fileTagsTableAdapter.Fill(this.devOrgDBDataSet.FileTags);

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.devOrgDBDataSet.Clear();
            this.fileTagsTableAdapter.Fill(this.devOrgDBDataSet.FileTags);
        }



    }
}
