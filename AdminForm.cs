using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MasterFileProject
{
    public partial class AdminForm : Form
    {
        // 4.9.	Create a method that will open the Admin Form when the Alt + A keys are pressed.
        // Ensure the General Form sends the currently selected Staff ID and Staff Name to the
        // Admin Form for Update and Delete purposes and is opened as modal. 
        // 5.1.	Create the Admin Form with the following settings: Control Box = false and KeyPreview = True,
        // then add two textboxes. The textbox for the Staff ID should be read-only for Update and Delete purposes.
        #region Admin Form Constructors
        public AdminForm()
        {
            InitializeComponent();
        }
        // 4.9 Create modified logic to open the Admin Form to Create a new user when the Staff ID 77
        // and the Staff Name is empty. Read the appropriate criteria in the Admin Form for further information.
        public AdminForm(string textboxID)
        {
            InitializeComponent();
            adminFormStaffIIdTextbox.Text = textboxID;
            adminFormStatusMessage.Text = "Add name to create new staff record.";
        }
        // 5.2.	Create a method that will receive the Staff ID from the general form and then populate textboxes with the related data. 
        public AdminForm(string textboxID, string textboxName)
        {
            InitializeComponent();
            adminFormStaffIIdTextbox.Text = textboxID;
            adminFormStaffNameTextbox.Text = textboxName;
            // Positioning the cursor at the end.
            adminFormStaffNameTextbox.Select(adminFormStaffNameTextbox.Text.Length, 0);
            adminFormStatusMessage.Text = "Staff Details are ready to be modified.";
        }
        #endregion
        #region Keyboard Shortcuts for Admin Form
        private void AdminForm_KeyDown(object sender, KeyEventArgs e)
        {
            adminFormStatusMessage.Text = "";
            // Keyboard shortcut for Creating new staff details.
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.C)
            {
                GeneralForm.MasterFile.Add(int.Parse(adminFormStaffIIdTextbox.Text), adminFormStaffNameTextbox.Text);
                adminFormStatusMessage.Text = "Staff Details Created.";
            }
            // 5.4 Create a method that will Remove the current Staff ID and clear the text boxes.
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.D)
            {
                GeneralForm.MasterFile.Remove(int.Parse(adminFormStaffIIdTextbox.Text));
                adminFormStaffIIdTextbox.Clear();
                adminFormStaffNameTextbox.Clear();
                adminFormStatusMessage.Text = "Staff Details Deleted.";
            }
            // Keyboard shortcut for Editing staff details.
            // 5.1.	Create a method that will Update the name of the current Staff ID.
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.E)
            {
                GeneralForm.MasterFile.Remove(int.Parse(adminFormStaffIIdTextbox.Text));
                GeneralForm.MasterFile.Add(int.Parse(adminFormStaffIIdTextbox.Text), adminFormStaffNameTextbox.Text);
                adminFormStatusMessage.Text = "Staff Details Updated.";
            }
            // 5.7.	Create a method that will close the Admin Form when the Alt + L keys are pressed.
            else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.L)
            {
                this.Close();
            }
        }
        #endregion
        // 5.6.	Create a method that will save changes to the csv file, this method should be called before the Admin Form closes.
        // 5.8.	Add suitable error trapping and user feedback to ensure a fully functional User Experience.
        // Make all methods private and ensure the Dictionary is updated. 
        #region Save changes, Form Closing Method
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stopwatch swAdmin = new Stopwatch();
            //var filePath = @"MalinStaffNamesV2.csv";
            adminFormStatusMessage.Text = "";
            // Write each directory name to a file.
            swAdmin.Start();
            {
                using (StreamWriter sw = new StreamWriter(@"MalinStaffNamesV2.csv"))
                {
                    foreach (var kvp in GeneralForm.MasterFile)
                    {
                        sw.WriteLine(kvp.Key + "," + kvp.Value);
                    }
                }
            }
            swAdmin.Stop();
            Console.WriteLine(String.Format("Writing data to file: " + "{0:0.00} ms", swAdmin.ElapsedMilliseconds));
        }
        #endregion
        #region Staff Name Textbox Input Handling 
        private void adminFormStaffNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Input only accepts keyboard functions and letters.
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                // These characters may pass.
                e.Handled = false;
            }
            else
            {
                // Everything that is not a letter, nor a backspace nor a space will be blocked.
                e.Handled = true;
                adminFormStatusMessage.Text = "Textbox does not accept numbers.";
            }
        }
        #endregion
        #region Admin Form Load
        private void AdminForm_Load(object sender, EventArgs e)
        {
            adminFormStatusMessage.Text = "Refer to helplist on the right to navigate this form.";
        }
        #endregion
    }
}
