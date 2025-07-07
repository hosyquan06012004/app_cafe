using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Example01
{
	internal class DB
	{
		public static SqlConnection Connect() {
			SqlConnection conn = null;
            //conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=cafe;User ID=sa;Password=1234$;MultipleActiveResultSets=true;");
            conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=cafe;Integrated Security=True;MultipleActiveResultSets=true;");

            return conn;
		}
	}
}
