namespace MasterFileProject
{
    partial class AdminForm
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
            this.adminFormStaffIIdTextbox = new System.Windows.Forms.TextBox();
            this.adminFormStaffNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helplistTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adminFormStaffIIdTextbox
            // 
            this.adminFormStaffIIdTextbox.Location = new System.Drawing.Point(19, 42);
            this.adminFormStaffIIdTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminFormStaffIIdTextbox.Name = "adminFormStaffIIdTextbox";
            this.adminFormStaffIIdTextbox.ReadOnly = true;
            this.adminFormStaffIIdTextbox.Size = new System.Drawing.Size(209, 20);
            this.adminFormStaffIIdTextbox.TabIndex = 1;
            // 
            // adminFormStaffNameTextbox
            // 
            this.adminFormStaffNameTextbox.Location = new System.Drawing.Point(19, 90);
            this.adminFormStaffNameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminFormStaffNameTextbox.Name = "adminFormStaffNameTextbox";
            this.adminFormStaffNameTextbox.Size = new System.Drawing.Size(209, 20);
            this.adminFormStaffNameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Staff Name";
            // 
            // helplistTextbox
            // 
            this.helplistTextbox.Location = new System.Drawing.Point(254, 27);
            this.helplistTextbox.Multiline = true;
            this.helplistTextbox.Name = "helplistTextbox";
            this.helplistTextbox.ReadOnly = true;
            this.helplistTextbox.Size = new System.Drawing.Size(208, 127);
            this.helplistTextbox.TabIndex = 2;
            this.helplistTextbox.Text = "Create ( Alt + I )\r\n\r\nUpdate \r\n\r\nDelete";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 195);
            this.ControlBox = false;
            this.Controls.Add(this.helplistTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminFormStaffNameTextbox);
            this.Controls.Add(this.adminFormStaffIIdTextbox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminFormStaffIIdTextbox;
        private System.Windows.Forms.TextBox adminFormStaffNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox helplistTextbox;
    }
}