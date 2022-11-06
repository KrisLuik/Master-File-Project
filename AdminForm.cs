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
        //public AdminForm(string generalFormID, string generalFormName)
        //{
        //    GeneralForm generalform = new GeneralForm();
        //    adminFormStaffIIdTextbox.Text = generalFormID;
        //    adminFormStaffNameTextbox.Text = generalFormName;
        //}

        private void AdminForm_Load(object sender, EventArgs e)
        {
            adminFormStaffIIdTextbox.Text = GeneralForm.textboxId;
            adminFormStaffNameTextbox.Text = GeneralForm.textboxName;   
        }
    }
}
