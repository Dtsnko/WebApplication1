using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using System.Data.OleDb;

namespace WebApplication1.Interfaces.Mocks
{
    public class MockMenu : IMenu
    {
        

        public IEnumerable<Menu> AllMenu
        {
            get
            {

                return DBGetMenu();
            }
        }
        private List<Menu> DBGetMenu()
        {
            List<Menu> list = new List<Menu>();
            string connectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Projects\WebApplication1\WebApplication1\AcDB\MenuDB.accdb";
            OleDbConnection connection = new OleDbConnection(connectString);
            connection.Open();
            string query = "SELECT * FROM Menu";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dbReader = command.ExecuteReader();
            while (dbReader.Read())
            {
                list.Add(new Menu() { Id = Convert.ToInt32(dbReader["Id"]), Code = dbReader["Code"].ToString(), MenuName = dbReader["MenuName"].ToString(), ParentId = Convert.ToInt32(dbReader["ParentId"]), Status = Convert.ToInt32(dbReader["Status"]) });
            }
            return list;
        }
    }
}
