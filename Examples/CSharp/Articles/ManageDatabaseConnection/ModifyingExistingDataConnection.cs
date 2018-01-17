﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Cells.ExternalConnections;

namespace Aspose.Cells.Examples.CSharp.Articles.ManageDatabaseConnection
{
    public class ModifyingExistingDataConnection
    {
        public static void Run()
        {
            //Source directory
            string sourceDir = RunExamples.Get_SourceDirectory();

            //Output directory
            string outputDir = RunExamples.Get_OutputDirectory();

            // Create workbook object
            Workbook workbook = new Workbook(sourceDir + "sampleModifyingExistingDataConnection.xlsx");

            // Access first Data Connection
            ExternalConnection conn = workbook.DataConnections[0];

            // Change the Data Connection Name and Odc file
            conn.Name = "MyConnectionName";
            conn.OdcFile = "C:\\Users\\MyDefaulConnection.odc";

            // Change the Command Type, Command and Connection String
            DBConnection dbConn = conn as DBConnection;
            dbConn.CommandType = OLEDBCommandType.SqlStatement;
            dbConn.Command = "Select * from AdminTable";
            dbConn.ConnectionInfo = "Server=myServerAddress;Database=myDataBase;User ID=myUsername;Password=myPassword;Trusted_Connection=False";

            // Save the workbook
            workbook.Save(outputDir + "outputModifyingExistingDataConnection.xlsx");

            Console.WriteLine("ModifyingExistingDataConnection executed successfully.");
        }
    }
}
