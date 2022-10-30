using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace MasterFileProject
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }
        // 4.1.	Create a Dictionary data structure with a TKey of type integer
        // and a TValue of type string, name the new structure “MasterFile”.
        static Dictionary<int, string> MasterFile = new Dictionary<int, string>();
        // 4.2.	Create a method that will read the data from the .csv file
        // into the Dictionary data structure when the form loads.
        #region Form Load
        private void GeneralForm_Load(object sender, EventArgs e)
        {
            ReadStaffDetailsFromFile();
        }
        #endregion
        #region Read from cvs file
        private void ReadStaffDetailsFromFile()
        {
            var filePath = @"MalinStaffNamesV2.csv";

            if (File.Exists(filePath))
            {
                string[] staffData = File.ReadAllLines(filePath);
                foreach (var staff in staffData)
                {
                    var splitData = staff.Split(',');
                    if (splitData.Length > 0)
                    {
                        var staffID = splitData[0];
                        var staffName = splitData[1];
                        MasterFile.Add(int.Parse(staffID), staffName);
                    }
                }
                DisplayData(readOnlyListbox);
            }
            else
            {
                MessageBox.Show("File did not load.");
            }
        }
        #endregion
        // 4.3.	Create a method to display the Dictionary data into a non-selectable display only listbox (ie read only).
        #region Display Data
        private void DisplayData(ListBox listbox)
        {
            //readOnlyListbox.Items.Clear();
            listbox.Items.Clear();
            foreach (var staff in MasterFile)
            {
                listbox.Items.Add(staff.Key + "\t" + staff.Value);
                //readOnlyListbox.Items.Add(staff.Key + "\t" + staff.Value);
            }
        }
        #endregion
        // 4.4.	Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable listbox.
        // This method must use a textbox input and update as each character is entered. The listbox must reflect the filtered data in real time.
        #region Filter by Name
        private void FilterStaffName()
        {

            foreach (var staff in MasterFile)
            {
                if (staff.Value.Contains(staffNameTextbox.Text))
                {
                    filteredListbox.Items.Add(staff.Key + "\t" + staff.Value);
                }
            }
        }
        private void staffNameTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            filteredListbox.Items.Clear();
            FilterStaffName();
        }
        #endregion
        // 4.5.	Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box.
        // This method must use a textbox input and update as each number is entered. The listbox must reflect the filtered data in real time.
        #region Filter by ID
        private void FilterStaffId()
        {
            foreach(var staff in MasterFile)
            {
                if (staff.Key.ToString().Contains(staffIdTextbox.Text))
                {
                    filteredListbox.Items.Add(staff.Key + "\t" + staff.Value);
                }
                else
                {
                    MessageBox.Show("Id not found.");
                }
            }    
        }

        private void staffIdTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            filteredListbox.Items.Clear();
            FilterStaffId();
        }
    }
    #endregion
}


