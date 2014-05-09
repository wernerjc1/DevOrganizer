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
            GreyedText = "tag1,tag2,...";
            SearchBox.Text = GreyedText;
            SearchBox.ForeColor = Color.Gray;
            copiedLabel.ForeColor = copiedLabel.BackColor;
        }
        private Icon ico;
        private string GreyedText;


        private void onSearchButtonClick(object sender, EventArgs e)
        {
            if (SearchBox.Text == "" || SearchBox.Text == GreyedText)
            {
                return;
            }
            if (this.tabControl1.SelectedTab == addTab)
            {
                this.tabControl1.SelectedTab = DatabaseTab;
            }
            //this.fileTagsTableAdapter.FillByFilepathsWithTag(this.devOrgDBDataSet.FileTags, SearchBox.Text);
            char[] delimiterChars = {','};

            string[] tags = SearchBox.Text.Split(delimiterChars);
            if (tags.Length == 1)
            {
                this.fileTagsTableAdapter.FillByFilepathsWithTag(this.devOrgDBDataSet.FileTags, "%"+tags[0]+"%");
            }
            else if (tags.Length == 2)
            {
                this.fileTagsTableAdapter.FillByFilepathsWithTwoTags(this.devOrgDBDataSet.FileTags, "%"+tags[0]+"%", "%"+tags[1]+"%");
            }
            else if (tags.Length >= 3)
            {
                if (tags.Length > 3)
                {
                    MessageBox.Show("Omitting search to three tags.");
                }
                this.fileTagsTableAdapter.FillByFilepathsWithThreeTags(this.devOrgDBDataSet.FileTags, "%"+tags[0]+"%", "%"+tags[1]+"%", "%"+tags[2]+"%");
            }

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
            this.updateButton_Click(sender, e);
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
            this.updateButton_Click(sender, e);
        }

        private void AddProjectButton_OnClick(object sender, EventArgs e)
        {
            this.fileTagsTableAdapter.Fill(this.devOrgDBDataSet.FileTags);
            string pathEntry = "";
            if (pathTextBox.Text != "")
            {
                pathEntry += pathTextBox.Text.ToString();
                for (int i = 0; i < devOrgDBDataSet.FileTags.Rows.Count; i++)
                {
                    if (pathEntry == devOrgDBDataSet.FileTags.Rows[i].ItemArray[1].ToString())
                    {
                        MessageBox.Show("Error: File Already in Database");
                        return;
                    }
                }
            }
            

            string tagEntry = "";
            
            if (tagsListBox.Items.Count > 0)
            {
                tagEntry = tagsListBox.Items[0].ToString();
                if (tagsListBox.Items.Count > 1)
                {
                    for (int i = 1; i < tagsListBox.Items.Count; i++)
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
                this.pathTextBox.Clear();
                this.tagsTextBox.Clear();
                this.authorsTextBox.Clear();
                this.descriptionTextBox.Clear();
                this.tagsListBox.Items.Clear();
                this.authorsListBox.Items.Clear();
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
           // string newFilePath = row.Cells[0].Value.ToString();
            string newTags = row.Cells[1].Value.ToString();
            string newAuthor = row.Cells[2].Value.ToString();
            string newDescription = row.Cells[3].Value.ToString();
            string oldFilePath = row.Cells[0].Value.ToString();

            //string oldFilePath = devOrgDBDataSet.FileTags.Rows[e.RowIndex].ItemArray[1].ToString();
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
                if (dataGridView1.CurrentCell.ColumnIndex == 0)
                {

                    string s = dataGridView1.CurrentCell.Value.ToString();
                    if (s.Contains('.')&&System.IO.Directory.Exists(s))
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = s,
                            UseShellExecute = true,
                            Verb = "open"
                        });
                    }
                    else if (System.IO.Directory.Exists(s))
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = s,
                            UseShellExecute = true,
                            Verb = "open"
                        });
                    }

                    else MessageBox.Show("Not a valid path.");
                }
            }
            else MessageBox.Show("Incorrect Number of cells");
        }

        private void copyClipboard_Click(object sender, EventArgs e)
        {
                string selection = "";
                for (int i = 0; i < dataGridView1.SelectedCells.Count-1; i++)
                {
                    selection += dataGridView1.SelectedCells[i].Value.ToString(); //= dataGridView1.CurrentCell.Value.ToString();
                    selection += ",";
                }
                selection += dataGridView1.SelectedCells[dataGridView1.SelectedCells.Count-1].Value.ToString();
                Clipboard.SetText(selection);
                copiedLabel.Text = "Copied";
                copiedLabel.ForeColor = Color.Black;
                timer1.Start();
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



        private void SearchBox_onEnter(object sender, EventArgs e)
        {
            if (SearchBox.ForeColor == Color.Gray)
            {
                SearchBox.ForeColor = Color.Black;
                SearchBox.Text = "";
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Update database
            foreach (DataRow dr in this.devOrgDBDataSet.Tables[0].Rows)
            {
                String path = dr["filepath"].ToString();
                if (File.Exists(path) || Directory.Exists(path))
                    this.fileTagsTableAdapter.UpdateSync("true", path);
                else
                    this.fileTagsTableAdapter.UpdateSync("false", path);
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                String path = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (File.Exists(path) || Directory.Exists(path))
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                else
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void SearchBox_onLeave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                SearchBox.Text = GreyedText;
                SearchBox.ForeColor = Color.Gray;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 16;

            if (copiedLabel.ForeColor.R >= copiedLabel.BackColor.R)
            {
                timer1.Stop();
                copiedLabel.ForeColor = copiedLabel.BackColor;
                return;
            }
            copiedLabel.ForeColor = Color.FromArgb(copiedLabel.ForeColor.R + fadingSpeed-1, copiedLabel.ForeColor.G + fadingSpeed-1, copiedLabel.ForeColor.B + fadingSpeed-1);


        }

        private void timerOnMenuItem_Click(object sender, EventArgs e)
        {
            this.timerOnMenuItem.CheckState = CheckState.Checked;
            this.timerOffMenuItem.CheckState = CheckState.Unchecked;
            this.updateTimer.Enabled = true;
        }

        private void timerOffMenuItem_Click(object sender, EventArgs e)
        {
            this.timerOnMenuItem.CheckState = CheckState.Unchecked;
            this.timerOffMenuItem.CheckState = CheckState.Checked;
            this.updateTimer.Enabled = false;
        }

        // This doesn't actually work...
        private void timerInterval_Click(object sender, EventArgs e, String interval)
        {
            //for (int i = 0; i < this.timerIntervalMenuItem.DropDownItems.Count; i++ )
            //{
            //    if (this.timerIntervalMenuItem.DropDownItems[i].Text != interval)
            //    {
            //        int j = this.timerIntervalMenuItem.DropDownItems.Count;//this.timerIntervalMenuItem.DropDownItems[i].CheckState = 
            //        j++;
            //    }
            //}
        }

        private void minutesMenuItem_5_Click(object sender, EventArgs e)
        {
            minutesMenuItem_5.CheckState = CheckState.Checked;
            minutesMenuItem_10.CheckState = CheckState.Unchecked;
            minutesMenuItem_15.CheckState = CheckState.Unchecked;
            minutesMenuItem_30.CheckState = CheckState.Unchecked;
            hourMenuItem_1.CheckState = CheckState.Unchecked;
            hoursMenuItem_5.CheckState = CheckState.Unchecked;
            hoursMenuItem_10.CheckState = CheckState.Unchecked;
            hoursMenuItem_15.CheckState = CheckState.Unchecked;
            hoursMenuItem_24.CheckState = CheckState.Unchecked;

            updateTimer.Interval = 300000;
        }

        private void minutesMenuItem_10_Click(object sender, EventArgs e)
        {
            minutesMenuItem_5.CheckState = CheckState.Unchecked;
            minutesMenuItem_10.CheckState = CheckState.Checked;
            minutesMenuItem_15.CheckState = CheckState.Unchecked;
            minutesMenuItem_30.CheckState = CheckState.Unchecked;
            hourMenuItem_1.CheckState = CheckState.Unchecked;
            hoursMenuItem_5.CheckState = CheckState.Unchecked;
            hoursMenuItem_10.CheckState = CheckState.Unchecked;
            hoursMenuItem_15.CheckState = CheckState.Unchecked;
            hoursMenuItem_24.CheckState = CheckState.Unchecked;

            updateTimer.Interval = 600000;
        }

        private void minutesMenuItem_15_Click(object sender, EventArgs e)
        {
            minutesMenuItem_5.CheckState = CheckState.Unchecked;
            minutesMenuItem_10.CheckState = CheckState.Unchecked;
            minutesMenuItem_15.CheckState = CheckState.Checked;
            minutesMenuItem_30.CheckState = CheckState.Unchecked;
            hourMenuItem_1.CheckState = CheckState.Unchecked;
            hoursMenuItem_5.CheckState = CheckState.Unchecked;
            hoursMenuItem_10.CheckState = CheckState.Unchecked;
            hoursMenuItem_15.CheckState = CheckState.Unchecked;
            hoursMenuItem_24.CheckState = CheckState.Unchecked;

            updateTimer.Interval = 900000;
        }

        private void minutesMenuItem_30_Click(object sender, EventArgs e)
        {
            minutesMenuItem_5.CheckState = CheckState.Unchecked;
            minutesMenuItem_10.CheckState = CheckState.Unchecked;
            minutesMenuItem_15.CheckState = CheckState.Unchecked;
            minutesMenuItem_30.CheckState = CheckState.Checked;
            hourMenuItem_1.CheckState = CheckState.Unchecked;
            hoursMenuItem_5.CheckState = CheckState.Unchecked;
            hoursMenuItem_10.CheckState = CheckState.Unchecked;
            hoursMenuItem_15.CheckState = CheckState.Unchecked;
            hoursMenuItem_24.CheckState = CheckState.Unchecked;

            updateTimer.Interval = 1800000;
        }

        private void hourMenuItem_1_Click(object sender, EventArgs e)
        {
            minutesMenuItem_5.CheckState = CheckState.Unchecked;
            minutesMenuItem_10.CheckState = CheckState.Unchecked;
            minutesMenuItem_15.CheckState = CheckState.Unchecked;
            minutesMenuItem_30.CheckState = CheckState.Unchecked;
            hourMenuItem_1.CheckState = CheckState.Checked;
            hoursMenuItem_5.CheckState = CheckState.Unchecked;
            hoursMenuItem_10.CheckState = CheckState.Unchecked;
            hoursMenuItem_15.CheckState = CheckState.Unchecked;
            hoursMenuItem_24.CheckState = CheckState.Unchecked;

            updateTimer.Interval = 3600000;
        }

        private void hoursMenuItem_5_Click(object sender, EventArgs e)
        {
            minutesMenuItem_5.CheckState = CheckState.Unchecked;
            minutesMenuItem_10.CheckState = CheckState.Unchecked;
            minutesMenuItem_15.CheckState = CheckState.Unchecked;
            minutesMenuItem_30.CheckState = CheckState.Unchecked;
            hourMenuItem_1.CheckState = CheckState.Unchecked;
            hoursMenuItem_5.CheckState = CheckState.Checked;
            hoursMenuItem_10.CheckState = CheckState.Unchecked;
            hoursMenuItem_15.CheckState = CheckState.Unchecked;
            hoursMenuItem_24.CheckState = CheckState.Unchecked;

            updateTimer.Interval = 18000000;
        }

        private void hoursMenuItem_10_Click(object sender, EventArgs e)
        {
            minutesMenuItem_5.CheckState = CheckState.Unchecked;
            minutesMenuItem_10.CheckState = CheckState.Unchecked;
            minutesMenuItem_15.CheckState = CheckState.Unchecked;
            minutesMenuItem_30.CheckState = CheckState.Unchecked;
            hourMenuItem_1.CheckState = CheckState.Unchecked;
            hoursMenuItem_5.CheckState = CheckState.Unchecked;
            hoursMenuItem_10.CheckState = CheckState.Checked;
            hoursMenuItem_15.CheckState = CheckState.Unchecked;
            hoursMenuItem_24.CheckState = CheckState.Unchecked;

            updateTimer.Interval = 36000000;
        }

        private void hoursMenuItem_15_Click(object sender, EventArgs e)
        {
            minutesMenuItem_5.CheckState = CheckState.Unchecked;
            minutesMenuItem_10.CheckState = CheckState.Unchecked;
            minutesMenuItem_15.CheckState = CheckState.Unchecked;
            minutesMenuItem_30.CheckState = CheckState.Unchecked;
            hourMenuItem_1.CheckState = CheckState.Unchecked;
            hoursMenuItem_5.CheckState = CheckState.Unchecked;
            hoursMenuItem_10.CheckState = CheckState.Unchecked;
            hoursMenuItem_15.CheckState = CheckState.Checked;
            hoursMenuItem_24.CheckState = CheckState.Unchecked;

            updateTimer.Interval = 54000000;
        }

        private void hoursMenuItem_24_Click(object sender, EventArgs e)
        {
            minutesMenuItem_5.CheckState = CheckState.Unchecked;
            minutesMenuItem_10.CheckState = CheckState.Unchecked;
            minutesMenuItem_15.CheckState = CheckState.Unchecked;
            minutesMenuItem_30.CheckState = CheckState.Unchecked;
            hourMenuItem_1.CheckState = CheckState.Unchecked;
            hoursMenuItem_5.CheckState = CheckState.Unchecked;
            hoursMenuItem_10.CheckState = CheckState.Unchecked;
            hoursMenuItem_15.CheckState = CheckState.Unchecked;
            hoursMenuItem_24.CheckState = CheckState.Checked;

            updateTimer.Interval = 86400000;
        }

        private void tagsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (tagsListBox.SelectedItem == null)
                {
                    var item = tagsListBox.IndexFromPoint(e.Location);
                    if (item >= 0)
                        tagsListBox.SelectedIndex = item;
                }
                this.newTagsContextMenu.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tagsListBox.Items.Remove(tagsListBox.SelectedItem);
        }

        private void authorsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (authorsListBox.SelectedItem == null)
                {
                    var item = authorsListBox.IndexFromPoint(e.Location);
                    if (item >= 0)
                        authorsListBox.SelectedIndex = item;                    
                }
                this.authorsContextMenu.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            authorsListBox.Items.Remove(authorsListBox.SelectedItem);
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = "UserManual.pdf",
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void editFilepathButton_Click(object sender, EventArgs e)
        {
            string fileStr = dataGridView1.SelectedCells[0].Value.ToString();
            string tagsStr = dataGridView1.SelectedCells[1].Value.ToString();
            string authStr = dataGridView1.SelectedCells[2].Value.ToString();
            string descStr = dataGridView1.SelectedCells[3].Value.ToString();

            string promptStr = "Current filepath: " + fileStr + "\n\nEnter a new filepath:";

            string promptValue = Prompt.ShowDialog(promptStr, "Edit Filepath");

            this.fileTagsTableAdapter.InsertTuple("1", promptValue, tagsStr, authStr, descStr);
            fileTagsTableAdapter.DeleteFilepath(fileStr);

            this.devOrgDBDataSet.Clear();
            this.fileTagsTableAdapter.Fill(this.devOrgDBDataSet.FileTags); 
        }

    }
}
