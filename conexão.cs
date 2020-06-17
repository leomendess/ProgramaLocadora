using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace aula_09_06
{
   public class conexão
    { 

        public static SqlConnection getConnection()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_rentalcar;Integrated Security=True;Pooling=False");
            return cnn;
        }

    }
}
