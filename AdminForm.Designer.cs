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
            this.adminFormStaffIIdTextbox.Location = new System.Drawing.Point(25, 52);
            this.adminFormStaffIIdTextbox.Name = "adminFormStaffIIdTextbox";
            this.adminFormStaffIIdTextbox.Size = new System.Drawing.Size(277, 22);
            this.adminFormStaffIIdTextbox.TabIndex = 0;
            // 
            // adminFormStaffNameTextbox
            // 
            this.adminFormStaffNameTextbox.Location = new System.Drawing.Point(25, 111);
            this.adminFormStaffNameTextbox.Name = "adminFormStaffNameTextbox";
            this.adminFormStaffNameTextbox.Size = new System.Drawing.Size(277, 22);
            this.adminFormStaffNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Staff Name";
            // 
            // helplistTextbox
            // 
            this.helplistTextbox.Location = new System.Drawing.Point(339, 33);
            this.helplistTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.helplistTextbox.Multiline = true;
            this.helplistTextbox.Name = "helplistTextbox";
            this.helplistTextbox.ReadOnly = true;
            this.helplistTextbox.Size = new System.Drawing.Size(276, 155);
            this.helplistTextbox.TabIndex = 7;
            this.helplistTextbox.Text = "Create\r\n\r\nUpdate \r\n\r\nDelete";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 240);
            this.Controls.Add(this.helplistTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminFormStaffNameTextbox);
            this.Controls.Add(this.adminFormStaffIIdTextbox);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
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