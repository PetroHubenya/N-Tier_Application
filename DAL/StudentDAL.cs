using DAL.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentDAL
    {
        public DataSet FetchSelectedStudents()
        {
            string sqlCommand = "SELECT * FROM Student WHERE StudentID < 5;";
            DataSet dataSet = SQLHelper.ExecuteDataSet(SQLHelper.CONN_STRING, CommandType.Text, sqlCommand);
            return dataSet;
        }
    }
}
