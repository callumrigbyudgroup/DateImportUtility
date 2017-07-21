using System;
using UDGroup.DataAccess;
using UDGroup.General.Sql;

namespace DateImportUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            string tableName = "matrix_tgp_postcodes";
            string path = @"\\udserver\Development\UDMatrix Imports\_____Matrix Files - All Clients\Total Gas and Power\2017-07-20\GEM (UD Group)\postcode lookup.csv";
            string whereClause = "";
            SqlFunctions.BulkInsertToAzure(Constants.AzureBrokerDataConnectionString, "dbo", tableName, path, true, whereClause);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
