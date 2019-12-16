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
using System.IO;

namespace Asg2_klh170130
{
    public class TechServices
    {

        string fileName = "CS6326Asg2.txt";
        
        public TechServices()
        {
            
        }
        
        // open/load/read file function
        public void loadDataFromFile(AppLogics anAppLogics, string tableName)
        {
            try
            {
                if(File.Exists(fileName))
                // if file exists, read
                {

                    StreamReader srFile = new StreamReader(fileName);

                    int colsCount = anAppLogics.dsData.Tables[tableName].Columns.Count;
                    object[] obData = new object[colsCount];

                    while (!srFile.EndOfStream)
                    {
                        string strDataLine = srFile.ReadLine(); // read a data line
                        string[] dataElements = strDataLine.Split('\t'); // split on tab
                        for(int i = 0; i < dataElements.Length; i++)
                        {
                            obData[i] = dataElements[i]; // assign to corresponding element in memory
                        }
                        anAppLogics.dsData.Tables[tableName].Rows.Add(obData); // add a data row to table

                    }
                    srFile.Close();
                }
                // else, do nothing
                
            }
            catch (IOException e)
            {
                throw;
            }


        }

        // write/save file function
        public void writeDataToFile(AppLogics anAppLogics, string tableName)
        {
            try
            {
                StreamWriter swFile = new StreamWriter(fileName);

                string strDataLine = "";
                int colsCount = anAppLogics.dsData.Tables[tableName].Columns.Count;
                int rowsCount = anAppLogics.dsData.Tables[tableName].Rows.Count;

                for (int i = 0; i < rowsCount; i++)
                {
                    strDataLine = (string)anAppLogics.dsData.Tables[tableName].Rows[i][0];
                    for (int j=1; j < colsCount; j++)
                    {
                        strDataLine += '\t';
                        strDataLine += (string)anAppLogics.dsData.Tables[tableName].Rows[i][j];
                    }
                    swFile.WriteLine(strDataLine);
                    
                }
                swFile.Close();
            }
            catch (IOException e)
            {  }
        }

    }
}
