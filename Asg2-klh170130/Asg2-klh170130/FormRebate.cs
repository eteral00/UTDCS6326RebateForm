/*
 // Author: Khoa L. D. Ho
 // Assignment 2 for Class CS6326, Fall 2019, at UT Dallas
 // using Visual Studio 2017 on OS Windows 8.1
 */

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
using System.Text.RegularExpressions;

namespace Asg2_klh170130
{
    public partial class frmRebate : Form
    {

        private bool modeAdd;

        string tableName = "RebateRecords";
        AppLogics myAppLogics = new AppLogics();
        TechServices myTechServices = new TechServices();
        DateTime dtEntryTime;
        DateTime dtSaveTime;
        int intBackspaceCount;
        int lastSelectedIndex;
        

        public frmRebate()
        {
            InitializeComponent();

            this.modeAdd = true;
            
            this.intBackspaceCount = 0;
            this.lastSelectedIndex = -1;
        
        }

        private void frmRebate_Load(object sender, EventArgs e)
        {
            myTechServices.loadDataFromFile(myAppLogics, this.tableName);

            this.populateListView();
        }


        private void populateListView()
        {
            this.lsvData.Items.Clear(); // premptive clear the items in the list view

            int rowsCount = myAppLogics.dsData.Tables[this.tableName].Rows.Count;

            // populate the list view
            for (int i = 0; i < rowsCount; i++)
            {
                DataRow drRecord = myAppLogics.dsData.Tables[this.tableName].Rows[i];
                ListViewItem lviItem = new ListViewItem(drRecord["FirstName"].ToString());
                if (drRecord["MiddleInitial"].ToString() == "*")
                {
                    lviItem.SubItems.Add(""); // blank MI
                }
                else
                {
                    lviItem.SubItems.Add(drRecord["MiddleInitial"].ToString());
                }
                lviItem.SubItems.Add(drRecord["LastName"].ToString());
                lviItem.SubItems.Add(drRecord["Phone"].ToString());

                this.lsvData.Items.Add(lviItem);
            }
        }

        private void lsvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvData.SelectedIndices.Count > 0)
            {
                ListView.SelectedIndexCollection selectedIndexes = this.lsvData.SelectedIndices;
                this.lastSelectedIndex = selectedIndexes[0];
                // lsvData is set to single select, so the selectedIndices actually contains only 1 index, but it is still contained in a collection
                
                // only act when something is selected, if nothing is selected, make no change
                if (this.modeAdd)
                {
                    // if currently in ADD Mode, switch to EDIT Mode
                    this.modeAdd = false;
                    this.lblMode.Text = "EDIT";
                    this.lblModeSwitch.Text = "(Use the Clear button to switch back to ADD Mode)";
                    this.btnAdd.Enabled = false;
                    this.btnModify.Enabled = true;
                    this.btnDiscard.Enabled = true;
                    this.btnDelete.Enabled = true;
                }

                this.populateFields(this.lastSelectedIndex);
            }
            
        }

        // method to populate controls/fields with data from selected item on list view
        private void populateFields(int sltedIndex)
        {
            DataRow drRecord = this.myAppLogics.dsData.Tables[this.tableName].Rows[sltedIndex];

            this.txtFName.Text = drRecord["FirstName"].ToString();

            if (drRecord["MiddleInitial"].ToString() == "*")
            {
                this.txtMI.Text = ""; // blank Middle Initial
            }
            else
            {
                this.txtMI.Text = drRecord["MiddleInitial"].ToString();
            }

            this.txtLName.Text = drRecord["LastName"].ToString();
            this.txtAddress1.Text = drRecord["Address1"].ToString();

            if (drRecord["Address2"].ToString() == "*")
            {
                this.txtAddress2.Text = ""; // blank Address line 2
            }
            else
            {
                this.txtAddress2.Text = drRecord["Address2"].ToString();
            }

            this.txtCity.Text = drRecord["City"].ToString();
            this.cbbState.SelectedIndex = this.cbbState.FindStringExact(drRecord["State"].ToString());

            this.txtZip.Text = drRecord["Zip"].ToString();
            this.cbbGender.SelectedIndex = this.cbbGender.FindStringExact(drRecord["Gender"].ToString());
            this.txtPhone.Text = drRecord["Phone"].ToString();
            this.txtEmail.Text = drRecord["Email"].ToString();
            this.cbbProof.SelectedIndex = this.cbbProof.FindStringExact(drRecord["Proof"].ToString());

            this.dtpDateReceived.Value = DateTime.Parse(drRecord["DateReceived"].ToString());
            //this.txtDateReceived.Text = drRecord["DateReceived"].ToString(); // change in design, there were issues in parsing
            return;
        }

        // handle key press on form level
        private void frmRebate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.modeAdd)
            {
                // only handle key press in ADD Mode
                if (this.txtFName.Text == string.Empty
                    && this.txtMI.Text == string.Empty
                    && this.txtLName.Text == string.Empty
                    && this.txtAddress1.Text == string.Empty
                    && this.txtAddress2.Text == string.Empty
                    && this.txtCity.Text == string.Empty
                    && this.txtZip.Text == string.Empty
                    && this.txtPhone.Text == string.Empty
                    && this.txtEmail.Text == string.Empty
                    )
                {
                    // all text fields are empty, record first key press time
                    this.dtEntryTime = System.DateTime.Now;
                }

                if (e.KeyChar == 8)
                {
                    // increment back space count
                    this.intBackspaceCount++;

                }

                
            }
        }

        private void frmRebate_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResultExit = MessageBox.Show("Are you sure you want to close the application now?", "Exit", MessageBoxButtons.YesNo);
            if (dlgResultExit == DialogResult.No)
            {          
                e.Cancel = true;
            }
            else if (dlgResultExit == DialogResult.Yes)
            {
                e.Cancel = false;
                //Application.Exit(); // unneeded, as we only had 1 form, and this cause a duplicate display of the exit dialog as it double initiate the form closing event
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close(); // transfer to the form closing event
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.dtSaveTime = System.DateTime.Now; // it updates save time everytime the user clicks the Add button, so if there are multiple unsuccessful saves, only the last save time will be recorded


            bool isValid = this.validateInput(); // validate fields on the form side
            bool rowAdded;

            if (isValid)
            {
                DataRow drRecord = this.myAppLogics.dsData.Tables[this.tableName].NewRow();

                drRecord["FirstName"] = this.txtFName.Text;

                if (this.txtMI.Text.Trim() == string.Empty)
                {
                    drRecord["MiddleInitial"] = "*"; // empty initial, put * as place holder
                }
                else
                {
                    drRecord["MiddleInitial"] = this.txtMI.Text;
                }

                drRecord["LastName"] = this.txtLName.Text;
                drRecord["Address1"] = this.txtAddress1.Text;

                if (this.txtAddress2.Text.Trim() == string.Empty)
                {
                    drRecord["Address2"] = "*"; // use * as place holder
                }
                else
                {
                    drRecord["Address2"] = this.txtAddress2.Text;
                }

                drRecord["City"] = this.txtCity.Text;
                drRecord["State"] = this.cbbState.SelectedItem.ToString();
                drRecord["Zip"] = this.txtZip.Text;
                drRecord["Gender"] = this.cbbGender.SelectedItem.ToString();
                drRecord["Phone"] = this.txtPhone.Text;
                drRecord["Email"] = this.txtEmail.Text;
                drRecord["Proof"] = this.cbbProof.SelectedItem.ToString();
                drRecord["DateReceived"] = this.dtpDateReceived.Value.ToShortDateString();
                drRecord["EntryTime"] = this.dtEntryTime.ToString();
                drRecord["SaveTime"] = this.dtSaveTime.ToString();
                drRecord["BackspaceCount"] = this.intBackspaceCount.ToString();


                rowAdded = myAppLogics.addRow(this.tableName, drRecord); // add to table

                if (rowAdded)
                {
                    // write back to file, there was no specification, so I will let it write back everytime someething was added, modified, or deleted
                    // It is safe but kind of inefficient, though. Should be changed if specifications are given for when to save.
                    this.myTechServices.writeDataToFile(myAppLogics, this.tableName);

                    MessageBox.Show("The record was successfully added!");
                    this.clearForm(); // clear form
                    this.populateListView(); // repopulate list view to show updated data
                }
                else
                {
                    this.txtFName.Focus();
                    MessageBox.Show("Unable to add! There is already a record for this customer in our data (same 'First Name', 'Last Name', and 'Phone'). Please revise and retry!");
                    
                }
                
            }
            
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            bool isValid = this.validateInput(); // validate fields on the form side
            bool rowModified;

            int rowIndex;

            if(isValid)
            {
                rowIndex = this.lastSelectedIndex; 

                DataRow drRecord = this.myAppLogics.dsData.Tables[this.tableName].NewRow();

                drRecord["FirstName"] = this.txtFName.Text;

                if (this.txtMI.Text.Trim() == string.Empty)
                {
                    drRecord["MiddleInitial"] = "*"; // empty initial, put * as place holder
                }
                else
                {
                    drRecord["MiddleInitial"] = this.txtMI.Text;
                }

                drRecord["LastName"] = this.txtLName.Text;
                drRecord["Address1"] = this.txtAddress1.Text;

                if (this.txtAddress2.Text.Trim() == string.Empty)
                {
                    drRecord["Address2"] = "*"; // use * as place holder
                }
                else
                {
                    drRecord["Address2"] = this.txtAddress2.Text;
                }

                drRecord["City"] = this.txtCity.Text;
                drRecord["State"] = this.cbbState.SelectedItem.ToString();
                drRecord["Zip"] = this.txtZip.Text;
                drRecord["Gender"] = this.cbbGender.SelectedItem.ToString();
                drRecord["Phone"] = this.txtPhone.Text;
                drRecord["Email"] = this.txtEmail.Text;
                drRecord["Proof"] = this.cbbProof.SelectedItem.ToString();
                drRecord["DateReceived"] = this.dtpDateReceived.Value.ToShortDateString();

                rowModified = this.myAppLogics.modifyRow(this.tableName, drRecord, rowIndex);

                if (rowModified)
                {
                    // write back to file, there was no specification, so I will let it write back everytime someething was added, modified, or deleted
                    // It is safe but kind of inefficient, though. Should be changed if specifications are given for when to save.
                    this.myTechServices.writeDataToFile(myAppLogics, this.tableName);

                    MessageBox.Show("The record was successfully updated!");
                    this.populateListView(); // repopulate list view to show updated data
                }
                else
                {
                    this.txtFName.Focus();
                    MessageBox.Show("Unable to update record. There is already another record with the same 'First Name', 'Last Name', and 'Phone' in the data. Please revise and retry.");

                }
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearForm();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.populateFields(this.lastSelectedIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlgResultExit = MessageBox.Show("Are you sure you want to delete this record", "Delete", MessageBoxButtons.YesNo);
            if (dlgResultExit == DialogResult.Yes)
            {
                this.myAppLogics.deleteRow(this.tableName, this.lastSelectedIndex);
                this.myTechServices.writeDataToFile(myAppLogics, this.tableName);
                MessageBox.Show("Record successfully deleted!");
                this.clearForm();
                this.populateListView();
            }
            // else do nothing
                        
        }


        // validate fields' input on form side
        private bool validateInput()
        {
            bool isValid = false;
            if (this.txtFName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("First Name cannot be empty.");
                this.txtFName.Focus();
                return isValid;
            }

            if (this.txtLName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Last Name cannot be empty.");
                this.txtLName.Focus();
                return isValid;
            }

            if (this.txtAddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Address line 1 cannot be empty.");
                this.txtAddress1.Focus();
                return isValid;
            }

            if (this.txtCity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("'City' field cannot be empty. Please enter City Name.");
                this.txtCity.Focus();
                return isValid;
            }

            if (this.cbbState.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a State.");
                this.cbbState.Focus();
                return isValid;
            }

            if (this.txtZip.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Zip Code cannot be empty. Please enter a Zip Code (5 or 9 digits).");
                this.txtZip.Focus();
                return isValid;
            }

            if (this.cbbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.");
                this.cbbGender.Focus();
                return isValid;
            }

            if (this.txtPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Phone Number cannot be empty. Please enter Phone Number (7 or 10 digits).");
                this.txtPhone.Focus();
                return isValid; 
            }

            if (this.txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Email Address cannot be empty. Please enter an email address (format: address@domain.something).");
                this.txtEmail.Focus();
                return isValid;
            }
            else if (!Regex.IsMatch(this.txtEmail.Text.Trim(),
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            // Email Address Regex following Microsoft .Net standards
            {
                MessageBox.Show("Please enter a valid email address (format: address@domain.something");
                this.txtEmail.Focus();
                return isValid;
            }

            if (this.cbbProof.SelectedIndex == -1)
            {
                MessageBox.Show("Please select if Proof of Purchase was attached or not.");
                this.cbbProof.Focus();
                return isValid;
            }

            if (this.dtpDateReceived.Value > System.DateTime.Today)
            {
                MessageBox.Show("Date Received cannot be in the future. Please change it.");
                this.dtpDateReceived.Focus();
                return isValid;
            }

            // all validation passed
            isValid = true;
            return isValid;
        }
        



        private void clearForm()
        {
            this.modeAdd = true;

            this.lblMode.Text = "ADD";
            this.lblModeSwitch.Text = "(Select an existing record on the list to enter Edit Mode)";
            this.btnAdd.Enabled = true;
            this.btnModify.Enabled = false;
            this.btnDiscard.Enabled = false;
            this.btnDelete.Enabled = false;

            this.txtFName.Clear();
            this.txtMI.Clear();
            this.txtLName.Clear();
            this.txtAddress1.Clear();
            this.txtAddress2.Clear();
            this.txtCity.Clear();
            this.cbbState.SelectedIndex = -1;
            this.txtZip.Clear();
            this.cbbGender.SelectedIndex = -1;
            this.txtPhone.Clear();
            this.txtEmail.Clear();
            this.cbbProof.SelectedIndex = -1;
            this.dtpDateReceived.Value = System.DateTime.Today;

            this.populateListView();

            this.lastSelectedIndex = -1;
            this.intBackspaceCount = 0;
            this.txtFName.Focus();
            return;
        }


        /* controls/fields validating */
        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.txtFName.Text.Trim() == string.Empty)
            {
                errMsg = "First Name cannot be empty.";
                e.Cancel = true;
                this.txtFName.SelectAll();
                this.erpEP1.SetError(txtFName, errMsg);
                
            }
        }

        private void txtFName_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(txtFName, string.Empty);
        }

        private void txtLName_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.txtLName.Text.Trim() == string.Empty)
            {
                errMsg = "Last Name cannot be empty.";
                e.Cancel = true;
                this.txtLName.SelectAll();
                this.erpEP1.SetError(txtLName, errMsg);
            }

        }

        private void txtLName_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(txtLName, string.Empty);
        }

        private void txtAddress1_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.txtAddress1.Text.Trim() == string.Empty)
            {
                errMsg = "Address line 1 cannot be empty.";
                e.Cancel = true;
                this.txtAddress1.SelectAll();
                this.erpEP1.SetError(txtAddress1, errMsg);
            }
        }

        private void txtAddress1_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(txtAddress1, string.Empty);
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.txtCity.Text.Trim() == string.Empty)
            {
                errMsg = "'City' field cannot be empty. Please enter City Name.";
                e.Cancel = true;
                this.txtCity.SelectAll();
                this.erpEP1.SetError(txtCity, errMsg);
            }
        }

        private void txtCity_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(txtCity, string.Empty);
        }

        private void cbbState_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.cbbState.SelectedIndex == -1)
            {
                errMsg="Please select a State.";
                e.Cancel = true;
                this.cbbState.SelectAll();
                this.erpEP1.SetError(cbbState, errMsg);
            }
        }

        private void cbbState_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(cbbState, string.Empty);
        }

        private void txtZip_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.txtZip.Text.Trim() == string.Empty)
            {
                errMsg = "Zip Code cannot be empty. Please enter a Zip Code (5 or 9 digits).";
                e.Cancel = true;
                this.txtZip.SelectAll();
                this.erpEP1.SetError(this.txtZip, errMsg);
            }
            else if (!Regex.IsMatch(this.txtZip.Text.Trim(), @"^\d{5}(\d{4})?$") )
            {
                errMsg = "Invalid Zip Code. Please enter a Zip Code (5 or 9 digits).";
                e.Cancel = true;
                this.txtZip.SelectAll();
                this.erpEP1.SetError(this.txtZip, errMsg);
            }
        }

        private void txtZip_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(this.txtZip, string.Empty);
        }

        private void cbbGender_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.cbbGender.SelectedIndex == -1)
            {
                errMsg = "Please select a gender.";
                e.Cancel = true;
                this.cbbGender.SelectAll();
                this.erpEP1.SetError(this.cbbGender, errMsg);
            }
        }

        private void cbbGender_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(this.cbbGender, string.Empty);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.txtPhone.Text.Trim() == string.Empty)
            {
                errMsg = "Phone Number cannot be empty. Please enter a valid Phone Number (10 digits).";
                e.Cancel = true;
                this.txtPhone.SelectAll();
                this.erpEP1.SetError(this.txtPhone, errMsg);
            }
            else if (!Regex.IsMatch(this.txtPhone.Text.Trim(), @"^(\d{10})$") )
            {
                errMsg = "Invalid Phone Number. Please enter a valid Phone Number (10 digits).";
                e.Cancel = true;
                this.txtPhone.SelectAll();
                this.erpEP1.SetError(this.txtPhone, errMsg);
            }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(this.txtPhone, string.Empty);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.txtEmail.Text.Trim() == string.Empty)
            {
                errMsg = "Email Address cannot be empty. Please enter an email address (format: address@domain.something).";
                e.Cancel = true;
                this.txtEmail.SelectAll();
                this.erpEP1.SetError(this.txtEmail, errMsg);
            }
            else if (!Regex.IsMatch(this.txtEmail.Text.Trim(),
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                errMsg = "Please enter a valid email address (format: address@domain.something";
                e.Cancel = true;
                this.txtEmail.SelectAll();
                this.erpEP1.SetError(this.txtEmail, errMsg);
            }

        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(this.txtEmail, string.Empty);
        }

        private void cbbProof_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.cbbProof.SelectedIndex == -1)
            {
                errMsg = "Please select if Proof of Purchase was attached or not.";
                e.Cancel = true;
                this.cbbProof.SelectAll();
                this.erpEP1.SetError(this.cbbProof, errMsg);
            }
        }

        private void cbbProof_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(this.cbbProof, string.Empty);
        }

        private void dtpDateReceived_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (this.dtpDateReceived.Value > System.DateTime.Today)
            {
                errMsg = "Date Received cannot be in the future. Please change it.";
                e.Cancel = true;
                this.dtpDateReceived.Select();
                this.erpEP1.SetError(this.dtpDateReceived, errMsg);
            }
        }

        private void dtpDateReceived_Validated(object sender, EventArgs e)
        {
            this.erpEP1.SetError(this.dtpDateReceived, string.Empty);
        }












        /* // this button was removed to avoid confusion
                private void btnSave_Click(object sender, EventArgs e)
                {
                    this.myTechServices.writeDataToFile(myAppLogics, this.tableName);
                    MessageBox.Show("Data successfully saved!", "Data Saved", MessageBoxButtons.OK);
                }
         */

    }
}
