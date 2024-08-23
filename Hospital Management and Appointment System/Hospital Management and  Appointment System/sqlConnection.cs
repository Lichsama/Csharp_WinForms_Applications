using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Management_and__Appointment_System
{
    internal class sqlConnection
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=LICHSAN\\KAANEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True;");
            connect.Open();
            return connect;
        }

    }
}
