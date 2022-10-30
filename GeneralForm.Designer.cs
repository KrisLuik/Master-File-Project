namespace MasterFileProject
{
    partial class GeneralForm
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
            this.readOnlyListbox = new System.Windows.Forms.ListBox();
            this.staffIdTextbox = new System.Windows.Forms.TextBox();
            this.staffNameTextbox = new System.Windows.Forms.TextBox();
            this.filteredListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helplistTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readOnlyListbox
            // 
            this.readOnlyListbox.FormattingEnabled = true;
            this.readOnlyListbox.ItemHeight = 16;
            this.readOnlyListbox.Location = new System.Drawing.Point(16, 46);
            this.readOnlyListbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readOnlyListbox.Name = "readOnlyListbox";
            this.readOnlyListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.readOnlyListbox.Size = new System.Drawing.Size(277, 420);
            this.readOnlyListbox.TabIndex = 3;
            // 
            // staffIdTextbox
            // 
            this.staffIdTextbox.Location = new System.Drawing.Point(319, 46);
            this.staffIdTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffIdTextbox.Name = "staffIdTextbox";
            this.staffIdTextbox.Size = new System.Drawing.Size(277, 22);
            this.staffIdTextbox.TabIndex = 0;
            this.staffIdTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.staffIdTextbox_KeyUp);
            // 
            // staffNameTextbox
            // 
            this.staffNameTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.staffNameTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.staffNameTextbox.Location = new System.Drawing.Point(319, 94);
            this.staffNameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffNameTextbox.Name = "staffNameTextbox";
            this.staffNameTextbox.Size = new System.Drawing.Size(277, 22);
            this.staffNameTextbox.TabIndex = 1;
            this.staffNameTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.staffNameTextbox_KeyUp);
            // 
            // filteredListbox
            // 
            this.filteredListbox.FormattingEnabled = true;
            this.filteredListbox.ItemHeight = 16;
            this.filteredListbox.Location = new System.Drawing.Point(319, 126);
            this.filteredListbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filteredListbox.Name = "filteredListbox";
            this.filteredListbox.Size = new System.Drawing.Size(277, 340);
            this.filteredListbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Staff Name";
            // 
            // helplistTextbox
            // 
            this.helplistTextbox.Location = new System.Drawing.Point(604, 46);
            this.helplistTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.helplistTextbox.Multiline = true;
            this.helplistTextbox.Name = "helplistTextbox";
            this.helplistTextbox.ReadOnly = true;
            this.helplistTextbox.Size = new System.Drawing.Size(220, 182);
            this.helplistTextbox.TabIndex = 6;
            this.helplistTextbox.Text = "Helplist \r\n\r\nClear Staff ID Textbox (Ctrl + R)\r\n\r\nClear Staff Name Textbox (Ctrl " +
    "+ D)\r\n\r\nExit General Form (Ctrl + Shift + Q)\r\n";
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 498);
            this.Controls.Add(this.helplistTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filteredListbox);
            this.Controls.Add(this.staffNameTextbox);
            this.Controls.Add(this.staffIdTextbox);
            this.Controls.Add(this.readOnlyListbox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GeneralForm";
            this.Text = "Master File - General Form";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox readOnlyListbox;
        private System.Windows.Forms.TextBox staffIdTextbox;
        private System.Windows.Forms.TextBox staffNameTextbox;
        private System.Windows.Forms.ListBox filteredListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox helplistTextbox;
    }
}

