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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.adminFormStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminFormStaffIIdTextbox
            // 
            this.adminFormStaffIIdTextbox.Location = new System.Drawing.Point(25, 47);
            this.adminFormStaffIIdTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminFormStaffIIdTextbox.Name = "adminFormStaffIIdTextbox";
            this.adminFormStaffIIdTextbox.ReadOnly = true;
            this.adminFormStaffIIdTextbox.Size = new System.Drawing.Size(209, 20);
            this.adminFormStaffIIdTextbox.TabIndex = 1;
            // 
            // adminFormStaffNameTextbox
            // 
            this.adminFormStaffNameTextbox.Location = new System.Drawing.Point(25, 90);
            this.adminFormStaffNameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminFormStaffNameTextbox.Name = "adminFormStaffNameTextbox";
            this.adminFormStaffNameTextbox.Size = new System.Drawing.Size(209, 20);
            this.adminFormStaffNameTextbox.TabIndex = 0;
            this.adminFormStaffNameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminFormStaffNameTextbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Staff Name";
            // 
            // helplistTextbox
            // 
            this.helplistTextbox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helplistTextbox.Location = new System.Drawing.Point(260, 29);
            this.helplistTextbox.Multiline = true;
            this.helplistTextbox.Name = "helplistTextbox";
            this.helplistTextbox.ReadOnly = true;
            this.helplistTextbox.Size = new System.Drawing.Size(114, 105);
            this.helplistTextbox.TabIndex = 2;
            this.helplistTextbox.Text = "Create (Alt + C)\r\n\r\nUpdate (Alt + E)\r\n\r\nDelete (Alt + D)\r\n\r\nExit (Alt + L)\r\n";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminFormStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 150);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(399, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // adminFormStatusMessage
            // 
            this.adminFormStatusMessage.Name = "adminFormStatusMessage";
            this.adminFormStatusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 172);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.helplistTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminFormStaffNameTextbox);
            this.Controls.Add(this.adminFormStaffIIdTextbox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminFormStaffIIdTextbox;
        private System.Windows.Forms.TextBox adminFormStaffNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox helplistTextbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel adminFormStatusMessage;
    }
}