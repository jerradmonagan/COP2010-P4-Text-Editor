using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4jmonagan
{
    //Jerrad Monagan
    //COP2010
    //Project4
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//end Form1

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }//end newToolStripMenuItem

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//end exitToolStripMenuItem

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMyFile();
        }//end openToolStripMenuItem

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMyFile();
        }//end saveToolStripMenuItem

        public void LoadMyFile()
        {
            //sets defaults before loading file
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Font = new Font("Arial", 12);

            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.FileName= "COP2010.rtf";
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
            }//end if
        }//end LoadMyFile

        public void SaveMyFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.FileName = "COP2010.rtf";
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
                richTextBox1.SaveFile(saveFileDialog1.FileName);
        }//end SaveMyFile

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }//end undoToolStripMenuItem

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }//end redoToolStripMenuItem

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }//end cutToolStripMenuItem

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }//end copyToolStripMenuItem

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }//end pasteToolStripMenuItem

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }//end selectAllToolStripMenuItem

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
        }//end fontToolStripMenuItem

        private void rBtnBlack_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionColor = Color.Black;
        }//end rBtnBlack

        private void rBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionColor = Color.Blue;
        }//end rBtnBlue

        private void btnFind_Click(object sender, EventArgs e)
        {
            String strSearch = txtSearch.Text;
            int intStartIndex = 0;
            while(intStartIndex < richTextBox1.TextLength)
            {
                int intWordStartIndex = richTextBox1.Find(strSearch, intStartIndex, RichTextBoxFinds.None);
                if (intWordStartIndex != -1)
                {
                    richTextBox1.SelectionStart = intWordStartIndex;
                    richTextBox1.SelectionLength = txtSearch.TextLength;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                }//end if
                else
                    break;
                intStartIndex += intStartIndex + txtSearch.TextLength;
            }//end while
        }

        private void rBtnComicSans_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionFont = new Font("Comic Sans", 12);
        }

        private void rBtnRed_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionColor = Color.Red;
        }

        private void rbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionColor = Color.Green;
        }

        private void rBtnArial_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionFont = new Font("Arial", 12);
        }

        private void rBtnCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionFont = new Font("Courier New", 12);
        }

        private void rBtnTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionFont = new Font("Times New Roman", 12);
        }
    }//end partial class form1
}//end namespace
