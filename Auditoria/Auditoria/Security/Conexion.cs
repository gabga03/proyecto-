using Oracle.ManagedDataAccess.Client;//libreria de conexion a aracle 
using System;
using System.Collections.Generic;
using System.Data.SqlClient; //libreria de conexion 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditoria.Security
{
    class Conexion
    {
        private OracleConnection connOralce;//clase para  conectar a oracle 
        private SqlConnection connSQL;//clase para conectar a sql server 
        private struct stConnDB
        {
            public string CadenaConexion;
            public string ErrorDesc;
            public int ErrorNum;
        }
        private stConnDB info;
        public OracleConnection oracle(string servidor, string usuario, string password)
        {
            info.CadenaConexion = string.Format("Data Source={0};User Id={1};Password={2};", servidor, usuario, password);
            try
            {
                connOralce = new OracleConnection(info.CadenaConexion);
            }
            catch (OracleException ex)
            {

            }
            
            return connOralce;
        }

        /*public SqlConnection sql()
        {
            this.connSQL = new SqlConnection()
            return this.connSQL;
        }*/
    }
}
