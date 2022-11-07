using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterFileProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        // 4.9.	Create a method that will open the Admin Form when the Alt + A keys are pressed.
        // Ensure the General Form sends the currently selected Staff ID and Staff Name to the
        // Admin Form for Update and Delete purposes and is opened as modal. 
        // 5.1.	Create the Admin Form with the following settings: Control Box = false and KeyPreview = True,
        // then add two textboxes. The textbox for the Staff ID should be read-only for Update and Delete purposes.
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        // 4.9 Create modified logic to open the Admin Form to Create a new user when the Staff ID 77
        // and the Staff Name is empty. Read the appropriate criteria in the Admin Form for further information.
        // 5.2.	Create a method that will receive the Staff ID from the general form and then populate textboxes with the related data. 
        public AdminForm(string textboxID)
        {
            InitializeComponent();
            adminFormStaffIIdTextbox.Text = textboxID;
        }
        public AdminForm(string textboxID, string textboxName)
        {
            InitializeComponent();
            adminFormStaffIIdTextbox.Text = textboxID;
            adminFormStaffNameTextbox.Text = textboxName;
            // Positioning the cursor at the end.
            adminFormStaffNameTextbox.Select(adminFormStaffNameTextbox.Text.Length, 0);
        }

        private void AdminForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Keyboard shortcut for Creating new staff details.
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.C)
            {
                GeneralForm.MasterFile.Add(int.Parse(adminFormStaffIIdTextbox.Text), adminFormStaffNameTextbox.Text);
                MessageBox.Show("User added");
            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.D)
            {
                GeneralForm.MasterFile.Remove(int.Parse(adminFormStaffIIdTextbox.Text));

            }
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Q)
            {
                this.Close();
            }
        }
    }
}
