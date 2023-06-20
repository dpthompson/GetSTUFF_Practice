using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GetSTUFF
{
    class DB_Connections
    {

         //central place to house sql connections
         public  static class SqlConnections
         {
            public static SqlConnection DB_Conn_SalesLT = new SqlConnection("Server=DESKTOP-JFT4SO7\\HOME_COURT;Database=SalesLT;Trusted_Connection=True");
        }

        //place to house all sql queries
        public static class SqlQueries
        {
            public static string GetFormLoad = "SELECT DISTINCT(City) FROM [SalesLT].[dbo].[Orders] order by City";
            public static string GetDataGridFormLoad = "SELECT orderid, Orderdate, customerName, City,amount FROM [SalesLT].[dbo].[Orders]";
            public static string GetEditFrmData = "SELECT OrderID, CustomerID,OrderDate,TotalAmount FROM [SalesLT].[dbo].[Orders_Test] where OrderID < 100";
        }

        public static class SqlQuerieUpdates
        {
            public static string UpdateOrderAMT = "Update [SalesLT]..[Orders_Test] Set TotalAmount = @newAmount Where OrderID = @OrderId";
        }

    }


}
