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
        private Icon ico;

        private void onSearchButtonClick(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == addTab)
            {
                this.tabControl1.SelectedTab = DatabaseTab;
            }
            this.fileTagsTableAdapter.FillByFilepathsWithTag(this.devOrgDBDataSet.FileTags, SearchBox.Text);
           // this.tabControl1.SelectedTab.Text = SearchBox.Text;
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
            this.fileTagsTableAdapter.Fill(this.devOrgDBDataSet.FileTags);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'devOrgDBDataSet.FileTags' table. You can move, or remove it, as needed.
            this.fileTagsTableAdapter.Fill(this.devOrgDBDataSet.FileTags);
            ico = notifyIcon1.Icon;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.devOrgDBDataSet.Clear();
            this.fileTagsTableAdapter.Fill(this.devOrgDBDataSet.FileTags);
            this.fileTagsTableAdapter.FillTable(this.devOrgDBDataSet.FileTags);
        }

        private void AddProjectButton_OnClick(object sender, EventArgs e)
        {
            string pathEntry = "";
            pathEntry += pathTextBox.Text.ToString();
            string tagEntry = "";
            
            if (tagsListBox.Items.Count > 0)
            {
                tagEntry = tagsListBox.Items[0].ToString();
                if (tagsListBox.Items.Count > 1)
                {
                    for (int i = 0; i < tagsListBox.Items.Count; i++)
                    {
                        tagEntry += ",";
                        tagEntry += tagsListBox.Items[i].ToString();
                    }
                }
            }
            string authorEntry = "";
            if (authorsListBox.Items.Count > 0)
            {
                authorEntry = authorsListBox.Items[0].ToString();
                if (authorsListBox.Items.Count > 1)
                {
                    for (int i = 0; i < authorsListBox.Items.Count; i++)
                    {
                        authorEntry += ",";
                        authorEntry += authorsListBox.Items[i].ToString();
                    }
                }
            }
            string descEntry = descriptionTextBox.Text.ToString();

            if (pathEntry == "")
            {
                MessageBox.Show("Please enter a valid filepath.");
            }
            else if (tagEntry == "")
            {
                MessageBox.Show("Please enter a valid tag.");
            }
            else
            {
                this.fileTagsTableAdapter.InsertTuple("1", pathEntry, tagEntry, authorEntry, descEntry);
                MessageBox.Show("Project Added!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection sCells = dataGridView1.SelectedCells;
            foreach (DataGridViewTextBoxCell file in sCells)
            {
                if (file.ColumnIndex == filepathDataGridViewTextBoxColumn.HeaderCell.ColumnIndex)
                {
                    string filestr = file.Value.ToString();
                    fileTagsTableAdapter.DeleteFilepath(filestr);
                }
            }
            this.devOrgDBDataSet.Clear();
            this.fileTagsTableAdapter.Fill(this.devOrgDBDataSet.FileTags);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex != 1)
            {
                e.Handled = true;
                dataGridView1.BeginEdit(true);
            }
        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //read the new values.
            string newFilePath = row.Cells[1].Value.ToString();
            string newTags = row.Cells[2].Value.ToString();
            string newAuthor = row.Cells[3].Value.ToString();
            string newDescription = row.Cells[4].Value.ToString();

            string oldFilePath = devOrgDBDataSet.FileTags.Rows[e.RowIndex].ItemArray[1].ToString();
            fileTagsTableAdapter.UpdateTags(newTags, oldFilePath);
            fileTagsTableAdapter.UpdateAuthor(newAuthor, oldFilePath);
            fileTagsTableAdapter.UpdateDescription(newDescription, oldFilePath);
            //Since filepath is the primary key, it cannot be changed this way.
            //fileTagsTableAdapter.UpdateFilePath(newFilePath, oldFilePath);

            this.devOrgDBDataSet.Clear();
            this.fileTagsTableAdapter.Fill(this.devOrgDBDataSet.FileTags);
        }

        private void onFilepathDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {

                    string s = dataGridView1.CurrentCell.Value.ToString();
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = s,
                        UseShellExecute = true,
                        Verb = "open"
                    });
                }
            }
            else MessageBox.Show("Incorrect Number of cells");
        }

        private void copyClipboard_Click(object sender, EventArgs e)
        {
         //   if(dataGridView1.currentCel
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gAYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hideToSystemTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void showFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideToContextMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
