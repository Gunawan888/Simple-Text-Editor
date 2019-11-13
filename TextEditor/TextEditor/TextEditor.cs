using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        private User user;

        public TextEditor(User user)
        {
            InitializeComponent();
            this.user = user;
            // Disable the rich text box if the user is View Only
            if (user.getUserType() == "View"){
                resultTxt.ReadOnly = true;
                ViewOnlyLabel.Visible = true;
            }
            // Fix this part later
            foreach(FontFamily font in FontFamily.Families.ToList()){
                fontFamilyComboBox.Items.Add(font.Name);
            }

            /// Personalise the message based on the login user first name 
            welcomeLbl.Text = "Welcome back, " + user.getFirstName();

            // Set the default value of font box in the beginning
            fontSizeComboBox.SelectedItem = fontSizeComboBox.Items[0];
            fontFamilyComboBox.SelectedItem = fontFamilyComboBox.Items[1];
        }
                ///////////////////
        /////// Structure of code ///////
                //////////////////
                
        //// 1. Menustrip events
        //// 2. Top Toolstrip Events
        //// 3. Left Toolstrip events
        //// 4. Non events re-useable methods


        /////////////////////////////////////////
        /////// 1. Menu strip Events ///////////
        ///////////////////////////////////////

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open a Rich Text File";
            openFile.Filter = "Rich Text File (*.rtf)|*.rtf";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK) {
                string filename = openFile.FileName;
                try
                {
                    resultTxt.Rtf = File.ReadAllText(openFile.FileName);
                    // Get the name of the file with its extension only
                    filenameLbl.Text = openFile.SafeFileName;
                    filenameLbl.Visible = true;
                }
                catch {
                    MessageBox.Show("Sorry, the file should be in either .rtf or .txt. Please select another file", "Incompatible file format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor newPortal = new TextEditor(this.user);
            newPortal.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save RTF file"; 
            saveFileDialog.Filter = "Rich Text File (*.rtf)|*.rtf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, resultTxt.Rtf);

                // Get the filename and extension only
                FileInfo fi = new FileInfo(saveFileDialog.FileName);
                filenameLbl.Text = fi.Name;
                filenameLbl.Visible = true;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save-as RTF file";
            saveFileDialog.Filter = "Rich Text File (*.rtf)|*.rtf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, resultTxt.Rtf);

                // Get the filename and extension only
                FileInfo fi = new FileInfo(saveFileDialog.FileName);
                filenameLbl.Text = fi.Name;
                filenameLbl.Visible = true;
            }
        }


        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultTxt.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultTxt.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultTxt.Paste();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginPortal = new Login();
            loginPortal.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutTextEditor = new About();
            aboutTextEditor.Show();
        }

        //// Under formatting Tab
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkButton(topBoldBtn);
            resultTxt.SelectionFont = new Font(resultTxt.SelectionFont, selectedFontStyle());
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkButton(topItalicBtn);
            resultTxt.SelectionFont = new Font(resultTxt.SelectionFont, selectedFontStyle());
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkButton(topUnderlineBtn);
            resultTxt.SelectionFont = new Font(resultTxt.SelectionFont, selectedFontStyle());
        }

        /////////////////////////////////
        //// 2. Top Toolstrip events /////
        ////////////////////////////////

        private void TopNewBtn_Click(object sender, EventArgs e)
        {
            TextEditor newFile = new TextEditor(this.user);
            newFile.Show();
        }

        private void topBoldBtn_Click(object sender, EventArgs e)
        {
            checkButton(topBoldBtn);
            resultTxt.SelectionFont = new Font(resultTxt.SelectionFont, selectedFontStyle());
        }
        private void topItalicBtn_Click(object sender, EventArgs e)
        {
            checkButton(topItalicBtn);
            resultTxt.SelectionFont = new Font(resultTxt.SelectionFont, selectedFontStyle());
        }

        private void topUnderlineBtn_Click(object sender, EventArgs e)
        {
            checkButton(topUnderlineBtn);
            resultTxt.SelectionFont = new Font(resultTxt.SelectionFont, selectedFontStyle());
        }

        private void topNewBtn_Click_1(object sender, EventArgs e)
        {
            TextEditor newFile = new TextEditor(this.user);
            newFile.Show();
        }

        private void topOpenBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Clear();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open a Rich Text File";
            openFile.Filter = "Rich Text File (*.rtf)|*.rtf";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = openFile.FileName;
                try
                {
                    resultTxt.Rtf = File.ReadAllText(openFile.FileName);
                    filenameLbl.Text = openFile.SafeFileName;
                    filenameLbl.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Sorry, the file should be in .rtf format. Please select another file", "Incompatible file format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void topSaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save a Rich Text File";
            saveFileDialog.Filter = "Rich Text File (*.rtf)|*.rtf";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, resultTxt.Rtf);
                // Get the filename and extension only
                FileInfo fi = new FileInfo(saveFileDialog.FileName);
                filenameLbl.Text = fi.Name;
                filenameLbl.Visible = true;
            }
        }

        private void topSaveasBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save-as a Rich Text File";
            saveFileDialog.Filter = "Rich Text File (*.rtf)|*.rtf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, resultTxt.Rtf);
                // Get the filename and extension only
                FileInfo fi = new FileInfo(saveFileDialog.FileName);
                filenameLbl.Text = fi.Name;
                filenameLbl.Visible = true;
            }
        }

        private void topHelpBtn_Click(object sender, EventArgs e)
        {
            // Open a local html file
            System.Diagnostics.Process.Start("help.html");
        }

        private void fontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontFamilyComboBox.SelectedItem != null && fontSizeComboBox.SelectedItem != null)
            {
                string selectedFont = fontFamilyComboBox.SelectedItem.ToString();
                resultTxt.SelectionFont = new Font(selectedFont, Convert.ToInt32(fontSizeComboBox.SelectedItem.ToString()), selectedFontStyle());
            }
        }

        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontFamilyComboBox.SelectedItem != null && fontSizeComboBox.SelectedItem != null) {
                int fontSize = Convert.ToInt32(fontSizeComboBox.SelectedItem.ToString());
                resultTxt.SelectionFont = new Font(fontFamilyComboBox.SelectedItem.ToString(), fontSize, selectedFontStyle());
            }
        }

        ////////////////////////////////
        //// 3. Left Toolstrip Events ///
        ///////////////////////////////

        private void leftCutBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Cut();
        }

        private void leftCopyBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Copy();
        }

        private void leftPasteBtn_Click(object sender, EventArgs e)
        {
            resultTxt.Paste();
        }

        //////////////////////////////////////
        //// 4. Non-events Reusable functions///
        //////////////////////////////////////

        //// Check and uncheck the button based on its check state
        private void checkButton(ToolStripButton button) {
            if (button.Checked) button.Checked = false;
            else button.Checked = true;
        }

        ///// Get the selected font style based on the checked button
        private FontStyle selectedFontStyle() {
            FontStyle selected = new FontStyle();
            // Check if the button is checked, if yes, append to the existing font style
            if (topUnderlineBtn.Checked) selected = FontStyle.Underline;
            if (topBoldBtn.Checked) selected = selected | FontStyle.Bold;
            if (topItalicBtn.Checked) selected = selected | FontStyle.Italic;
            return selected;
        }
    }
}
