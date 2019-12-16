/*
 // Author: Khoa L. D. Ho
 // Assignment 2 for Class CS6326, Fall 2019, at UT Dallas
 // using Visual Studio 2017 on OS Windows 8.1
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg2_klh170130
{
    public class AppLogics
    {

        public DataSet dsData;

        public AppLogics()
        {
            this.dsData = new DataSet();
            this.dsData.Tables.Add("RebateRecords");
            this.dsData.Tables["RebateRecords"].Columns.Add("FirstName");
            this.dsData.Tables["RebateRecords"].Columns.Add("MiddleInitial");
            this.dsData.Tables["RebateRecords"].Columns.Add("LastName");
            this.dsData.Tables["RebateRecords"].Columns.Add("Address1");
            this.dsData.Tables["RebateRecords"].Columns.Add("Address2");
            this.dsData.Tables["RebateRecords"].Columns.Add("City");
            this.dsData.Tables["RebateRecords"].Columns.Add("State");
            this.dsData.Tables["RebateRecords"].Columns.Add("Zip");
            this.dsData.Tables["RebateRecords"].Columns.Add("Gender");
            this.dsData.Tables["RebateRecords"].Columns.Add("Phone");
            this.dsData.Tables["RebateRecords"].Columns.Add("Email");
            this.dsData.Tables["RebateRecords"].Columns.Add("Proof");
            this.dsData.Tables["RebateRecords"].Columns.Add("DateReceived");
            this.dsData.Tables["RebateRecords"].Columns.Add("EntryTime");
            this.dsData.Tables["RebateRecords"].Columns.Add("SaveTime");
            this.dsData.Tables["RebateRecords"].Columns.Add("BackspaceCount");

            //object[] obData = new object[this.dsData.Tables["RebateRecords"].Columns.Count];
            //for(int i = 0; i<this.dsData.Tables["RebateRecords"].Columns.Count; i++)
            //{
            //    obData[i] = (i + 10).ToString();
            //}

            //this.dsData.Tables["RebateRecords"].Rows.Add(obData);
        }

        public DataRow getRow(string tableName, int rowIndex)
        {
            return this.dsData.Tables[tableName].Rows[rowIndex];
        }

        public bool addRow(string tableName, DataRow drRecord)
        {
            bool rowAdded = false;
            if(!this.checkDuplicateAdd(tableName, drRecord) )
            {
                // no duplicate, add
                this.dsData.Tables[tableName].Rows.Add(drRecord);
                rowAdded = true;
            }
            else
            {
                // duplicate exists, do not add
                rowAdded = false;
            }

            return rowAdded;
        }

        private bool checkDuplicateAdd(string tableName, DataRow drNewRow)
        {
            bool recordExists = false;
            int rowsCount = this.dsData.Tables[tableName].Rows.Count;
            string newFName = drNewRow["FirstName"].ToString();
            string newLName = drNewRow["LastName"].ToString();
            string newPhone = drNewRow["Phone"].ToString();

            for (int i = 0; i < rowsCount; i++)
            {
                if ( (this.dsData.Tables[tableName].Rows[i]["FirstName"].ToString() == newFName) && 
                    (this.dsData.Tables[tableName].Rows[i]["LastName"].ToString() == newLName) &&
                    (this.dsData.Tables[tableName].Rows[i]["Phone"].ToString() == newPhone) )
                {
                    recordExists = true;
                    break;
                }
            }
            return recordExists;
        }

        public bool modifyRow(string tableName, DataRow drRecord, int rowIndex)
        {
            bool rowModified = false;

            if(!this.checkDuplicateModify(tableName, drRecord, rowIndex) )
            {
                this.dsData.Tables[tableName].Rows[rowIndex]["FirstName"] = drRecord["FirstName"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["MiddleInitial"] = drRecord["MiddleInitial"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["LastName"] = drRecord["LastName"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["Address1"] = drRecord["Address1"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["Address2"] = drRecord["Address2"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["City"] = drRecord["City"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["State"] = drRecord["State"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["Zip"] = drRecord["Zip"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["Gender"] = drRecord["Gender"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["Phone"] = drRecord["Phone"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["Email"] = drRecord["Email"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["Proof"] = drRecord["Proof"].ToString();
                this.dsData.Tables[tableName].Rows[rowIndex]["DateReceived"] = drRecord["DateReceived"].ToString();


                rowModified = true;
            }
            else
            {
                // duplicate exists, do not modify
                rowModified = false;
                
            }

            return rowModified;
        }

        private bool checkDuplicateModify(string tableName, DataRow drNewRow, int rowIndex)
        {
            bool duplicateExists = false;

            int rowsCount = this.dsData.Tables[tableName].Rows.Count;
            string newFName = drNewRow["FirstName"].ToString();
            string newLName = drNewRow["LastName"].ToString();
            string newPhone = drNewRow["Phone"].ToString();

            for (int i = 0; i < rowsCount; i++)
            {
                if (i != rowIndex)
                {
                    if ((this.dsData.Tables[tableName].Rows[i]["FirstName"].ToString() == newFName) &&
                    (this.dsData.Tables[tableName].Rows[i]["LastName"].ToString() == newLName) &&
                    (this.dsData.Tables[tableName].Rows[i]["Phone"].ToString() == newPhone))
                    {
                        duplicateExists = true;
                        break;
                    }
                }
            }
            return duplicateExists;
        }
        
        public void deleteRow(string tableName, int rowIndex)
        {
            bool rowDeleted = false;

            this.dsData.Tables[tableName].Rows.RemoveAt(rowIndex);

            return;
        }

    }
}
