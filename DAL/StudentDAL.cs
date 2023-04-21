using DAL.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL
    {
        public DataTable FetchSelectedStudents()
        {
            // string sqlCommand = "SELECT * FROM Student WHERE StudentID < 5;";
            // DataSet dataSet = SQLHelper.ExecuteDataSet(SQLHelper.CONN_STRING, CommandType.Text, sqlCommand);

            string query = "SELECT * FROM Student WHERE StudentID < 5;";
            DataTable dataTable = new DataTable();
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(SQLHelper.CONN_STRING))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myReader = myCommand.ExecuteReader();
                    dataTable.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }

            return dataTable;
        }
    }
}
