using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    public class RepoBase
    {
        protected const string CONN_STRING = "Server = TRANSFORMER8\\SQLEXPRESS2017; Database = ATM; Trusted_Connection = True";


        /// <summary>
        /// vráti mi connection do sqlconnection
        /// </summary>
        protected SqlConnection Connection { get { return new SqlConnection(CONN_STRING); } }


    }
}
