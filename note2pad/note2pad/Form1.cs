using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace note2pad
{
    public partial class MainNotepadfrm : Form
    {
        public MainNotepadfrm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Rights Reserved By the author \nPatel_Rahul", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }

        private void MainrichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MainrichTextBox.Text.Length > 0)
            {
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                italicToolStripMenuItem.Enabled = true;
                wordWrapToolStripMenuItem.Enabled = true;
                italicToolStripMenuItem.Enabled = true;
                underlineToolStripMenuItem.Enabled = true;
                strikeThroughToolStripMenuItem.Enabled = true;
            }
            else {
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
                italicToolStripMenuItem.Enabled =   false;
                wordWrapToolStripMenuItem.Enabled =  false;
                italicToolStripMenuItem.Enabled =    false;
                underlineToolStripMenuItem.Enabled =  false;
                strikeThroughToolStripMenuItem.Enabled =false;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.Text +=  DateTime.Now;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.SelectionFont = new Font(MainrichTextBox.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.SelectionFont = new Font(MainrichTextBox.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.SelectionFont = new Font(MainrichTextBox.Font, FontStyle.Underline);
        }

        private void strikeThroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.SelectionFont = new Font(MainrichTextBox.Font, FontStyle.Strikeout);
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainrichTextBox.SelectionFont = new Font(MainrichTextBox.Font, FontStyle.Regular);
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
