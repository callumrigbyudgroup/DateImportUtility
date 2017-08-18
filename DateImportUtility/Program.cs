using System;
using UDGroup.DataAccess;
using UDGroup.General.Sql;

namespace DateImportUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string tableName = "matrix_tgp_postcodes";
                string path = @"\\udserver\Development\UDMatrix Imports\_____Matrix Files - All Clients\Total Gas and Power\2017-08-16\Power Solutions\postcode lookup.csv";
                string whereClause = "";
                //SqlFunctions.BulkInsertToAzure(Constants.UDBrokerDataConnectionString, "dbo", tableName, path, true, whereClause, ',');
                //SqlFunctions.BulkInsertToAzure(Constants.AzureBrokerDataConnectionString, "dbo", tableName, path, true, whereClause, ',');
                SqlFunctions.BulkInsertToAzure(Constants.AzureUDPlatformDemoConnectionString.Replace("demoforudswitch", "powersolutionsforudswitch"), "dbo", tableName, path, true, whereClause, ',');
            }
            catch (Exception ex)
            {
                PrintException(ex);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static void PrintException(Exception ex)
        {
            Console.WriteLine(ex.Message);

            if (ex.InnerException != null)
                PrintException(ex.InnerException);
        }
    }
}
