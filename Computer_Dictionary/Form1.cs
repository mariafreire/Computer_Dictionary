using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        bool isNew;

        
        private void EditingMode()
        {
            splitContainer1.Panel1Collapsed = true;
            exitToolStripMenuItem.Enabled = false;
            newToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            doneToolStripMenuItem.Visible = true;
            cancelToolStripMenuItem.Visible = true;
            txtHeadWord.TabStop = true;
            rtbDefinition.TabStop = true;
            txtHeadWord.ReadOnly = false;
            rtbDefinition.ReadOnly = false;
            txtHeadWord.Focus();
        }

        
        private void SearchMode()
        {
            splitContainer1.Panel1Collapsed = false;
            exitToolStripMenuItem.Enabled = true;
            newToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            deleteToolStripMenuItem.Enabled = true;
            doneToolStripMenuItem.Visible = false;
            cancelToolStripMenuItem.Visible = false;
            txtHeadWord.TabStop = false;
            rtbDefinition.TabStop = false;
            txtHeadWord.ReadOnly = true;
            rtbDefinition.ReadOnly = true;
            ComboBoxShowAll();
            cboHeadword.Focus();
        }

        private void ComboBoxShowAll()
        {
            cboHeadword.DataBindings.Clear();
            var query = from word in fOLDOCDataSet.FOLDOC.AsEnumerable()
                        orderby word.Headword
                        select word;
            cboHeadword.DataBindings.Clear();
            cboHeadword.DisplayMember = "Headword";
            cboHeadword.ValueMember = "Key";
            cboHeadword.DataSource = query.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);
            ComboBoxShowAll();
        }

        private void cboHeardword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchBegin.PerformClick();
        }

        private void cboHeadword_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboHeadword.SelectedValue != null)
            {
                try
                {
                    int index = fOLDOCBindingSource.Find("Key", cboHeadword.SelectedValue);
                    fOLDOCBindingSource.Position = index;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboHeadword.DataBindings.Clear();
            if (cboHeadword.Text.Trim().Length > 0)
            {
                var query = from word in fOLDOCDataSet.FOLDOC
                            where word.Headword.ToUpper().StartsWith(cboHeadword.Text.ToUpper())
                            orderby word.Headword
                            select word; // new {word.key, word.Headword};
                cboHeadword.DisplayMember = "Headword";
                cboHeadword.ValueMember = "key";
                cboHeadword.DataSource = query.ToList();
            }
        }

        private void btnSearchBegin_Click(object sender, EventArgs e)
        {
            cboHeadword.DataBindings.Clear();
            if (cboHeadword.Text.Trim().Length > 0)
            {
                var query = from word in fOLDOCDataSet.FOLDOC
                            where word.Headword.ToUpper().EndsWith(cboHeadword.Text.ToUpper())
                            orderby word.Headword
                            select word; // new {word.key, word.Headword};
                cboHeadword.DisplayMember = "Headword";
                cboHeadword.ValueMember = "key";
                cboHeadword.DataSource = query.ToList();
            }
            else
                ComboBoxShowAll();
        }

        private void btnSearchEnd_Click(object sender, EventArgs e)
        {
            cboHeadword.DataBindings.Clear();
            if (cboHeadword.Text.Trim().Length > 0)
            {
                var query = from word in fOLDOCDataSet.FOLDOC
                            where word.Headword.ToUpper().Contains(cboHeadword.Text.ToUpper())
                            orderby word.Headword
                            select word; // new {word.key, word.Headword};
                cboHeadword.DisplayMember = "Headword";
                cboHeadword.ValueMember = "key";
                cboHeadword.DataSource = query.ToList();
            }
        }

        private void btnAnywhere_Click(object sender, EventArgs e)
        {
            if (cboHeadword.Text.Trim().Length > 0)
            {
                var query = from word in fOLDOCDataSet.FOLDOC
                            where word.Headword.ToUpper().Contains(cboHeadword.Text.ToUpper()) ||
                            word.Definition.ToUpper().Contains(cboHeadword.Text.ToUpper())
                            orderby word.Headword
                            select word; // new {word.key, word.Headword};
                cboHeadword.DisplayMember = "Headword";
                cboHeadword.ValueMember = "key";
                cboHeadword.DataSource = query.ToList();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNew = true;
            cboHeadword.DataBindings.Clear();
            fOLDOCBindingSource.AddNew();
            EditingMode();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNew = false;
            int currentPosition = fOLDOCBindingSource.Position;
            cboHeadword.DataBindings.Clear();
            fOLDOCBindingSource.Position = currentPosition;
            EditingMode();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentPosition = fOLDOCBindingSource.Position;
            if (currentPosition > -1)
            {
                string currentHeadWord = cboHeadword.Text;
                DialogResult = MessageBox.Show("Do you really want to delete " +
                    currentHeadWord + "?", "Confirm deletion");
                if (DialogResult == DialogResult.OK)
                {
                    try
                    {
                        fOLDOCBindingSource.RemoveCurrent();
                        fOLDOCBindingSource.EndEdit();
                        fOLDOCTableAdapter.Update(fOLDOCDataSet.FOLDOC);
                        this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);
                        ComboBoxShowAll();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(currentHeadWord + @" not removed.
                            " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show(currentHeadWord + @" not removed. Operation cancelled by user");

                }
            }
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtHeadWord.Text.Trim().Length == 0
                || rtbDefinition.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Headword and/or Defination not completed!
Add more information please.", "Missing information reminder");
            }
            else
            {
                this.Validate();
                this.fOLDOCBindingSource.EndEdit();
                fOLDOCTableAdapter.Update(fOLDOCDataSet.FOLDOC);
                this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);
                SearchMode();
                ComboBoxShowAll();
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //should not shown in editing. Only used for adding new record.
            if (isNew)
            {
                fOLDOCBindingSource.RemoveCurrent();
            }
            else
            {
                fOLDOCBindingSource.ResetBindings(false);
            }
            SearchMode();
            ComboBoxShowAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
