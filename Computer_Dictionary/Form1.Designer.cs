namespace Computer_Dictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableAdapterManager = new Computer_Dictionary.FOLDOCDataSetTableAdapters.TableAdapterManager();
            this.fOLDOCTableAdapter = new Computer_Dictionary.FOLDOCDataSetTableAdapters.FOLDOCTableAdapter();
            this.fOLDOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOLDOCDataSet = new Computer_Dictionary.FOLDOCDataSet();
            this.rtbDefinition = new System.Windows.Forms.TextBox();
            this.txtHeadWord = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchBegin = new System.Windows.Forms.Button();
            this.btnSearchEnd = new System.Windows.Forms.Button();
            this.btnAnywhere = new System.Windows.Forms.Button();
            this.cboHeadword = new System.Windows.Forms.ComboBox();
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FOLDOCTableAdapter = this.fOLDOCTableAdapter;
            this.tableAdapterManager.UpdateOrder = Computer_Dictionary.FOLDOCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fOLDOCTableAdapter
            // 
            this.fOLDOCTableAdapter.ClearBeforeFill = true;
            // 
            // fOLDOCBindingSource
            // 
            this.fOLDOCBindingSource.DataMember = "FOLDOC";
            this.fOLDOCBindingSource.DataSource = this.fOLDOCDataSet;
            // 
            // fOLDOCDataSet
            // 
            this.fOLDOCDataSet.DataSetName = "FOLDOCDataSet";
            this.fOLDOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtbDefinition
            // 
            this.rtbDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDefinition.BackColor = System.Drawing.SystemColors.Control;
            this.rtbDefinition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLDOCBindingSource, "Definition", true));
            this.rtbDefinition.Location = new System.Drawing.Point(0, 26);
            this.rtbDefinition.Multiline = true;
            this.rtbDefinition.Name = "rtbDefinition";
            this.rtbDefinition.Size = new System.Drawing.Size(611, 272);
            this.rtbDefinition.TabIndex = 0;
            // 
            // txtHeadWord
            // 
            this.txtHeadWord.BackColor = System.Drawing.SystemColors.Control;
            this.txtHeadWord.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLDOCBindingSource, "Headword", true));
            this.txtHeadWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHeadWord.Location = new System.Drawing.Point(0, 0);
            this.txtHeadWord.Name = "txtHeadWord";
            this.txtHeadWord.Size = new System.Drawing.Size(611, 20);
            this.txtHeadWord.TabIndex = 0;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.cboHeadword);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbDefinition);
            this.splitContainer1.Panel2.Controls.Add(this.txtHeadWord);
            this.splitContainer1.Panel2MinSize = 193;
            this.splitContainer1.Size = new System.Drawing.Size(611, 458);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnSearchBegin);
            this.flowLayoutPanel1.Controls.Add(this.btnSearchEnd);
            this.flowLayoutPanel1.Controls.Add(this.btnAnywhere);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(484, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 153);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Search*";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchBegin
            // 
            this.btnSearchBegin.Location = new System.Drawing.Point(3, 32);
            this.btnSearchBegin.Name = "btnSearchBegin";
            this.btnSearchBegin.Size = new System.Drawing.Size(111, 23);
            this.btnSearchBegin.TabIndex = 4;
            this.btnSearchBegin.TabStop = false;
            this.btnSearchBegin.Text = "*Search";
            this.btnSearchBegin.UseVisualStyleBackColor = true;
            this.btnSearchBegin.Click += new System.EventHandler(this.btnSearchBegin_Click);
            // 
            // btnSearchEnd
            // 
            this.btnSearchEnd.Location = new System.Drawing.Point(3, 61);
            this.btnSearchEnd.Name = "btnSearchEnd";
            this.btnSearchEnd.Size = new System.Drawing.Size(111, 23);
            this.btnSearchEnd.TabIndex = 5;
            this.btnSearchEnd.TabStop = false;
            this.btnSearchEnd.Text = "*Search*";
            this.btnSearchEnd.UseVisualStyleBackColor = true;
            this.btnSearchEnd.Click += new System.EventHandler(this.btnSearchEnd_Click);
            // 
            // btnAnywhere
            // 
            this.btnAnywhere.Location = new System.Drawing.Point(3, 90);
            this.btnAnywhere.Name = "btnAnywhere";
            this.btnAnywhere.Size = new System.Drawing.Size(111, 23);
            this.btnAnywhere.TabIndex = 6;
            this.btnAnywhere.TabStop = false;
            this.btnAnywhere.Text = "Anywhere Search";
            this.btnAnywhere.UseVisualStyleBackColor = true;
            this.btnAnywhere.Click += new System.EventHandler(this.btnAnywhere_Click);
            // 
            // cboHeadword
            // 
            this.cboHeadword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHeadword.DataSource = this.fOLDOCBindingSource;
            this.cboHeadword.DisplayMember = "Headword";
            this.cboHeadword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboHeadword.FormattingEnabled = true;
            this.cboHeadword.Location = new System.Drawing.Point(12, 5);
            this.cboHeadword.Name = "cboHeadword";
            this.cboHeadword.Size = new System.Drawing.Size(466, 136);
            this.cboHeadword.TabIndex = 7;
            this.cboHeadword.ValueMember = "key";
            this.cboHeadword.SelectedIndexChanged += new System.EventHandler(this.cboHeadword_SelectedIndexChanged_1);
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.doneToolStripMenuItem.Text = "Done";
            this.doneToolStripMenuItem.Visible = false;
            this.doneToolStripMenuItem.Click += new System.EventHandler(this.doneToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.newToolStripMenuItem,
            this.doneToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(611, 24);
            this.menuStrip3.TabIndex = 7;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(611, 482);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip3);
            this.Name = "Form1";
            this.Text = "Computer Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FOLDOCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FOLDOCDataSetTableAdapters.FOLDOCTableAdapter fOLDOCTableAdapter;
        private System.Windows.Forms.BindingSource fOLDOCBindingSource;
        private FOLDOCDataSet fOLDOCDataSet;
        private System.Windows.Forms.TextBox rtbDefinition;
        private System.Windows.Forms.TextBox txtHeadWord;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchBegin;
        private System.Windows.Forms.Button btnSearchEnd;
        private System.Windows.Forms.Button btnAnywhere;
        private System.Windows.Forms.ComboBox cboHeadword;
        private System.Windows.Forms.ToolStripMenuItem doneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

