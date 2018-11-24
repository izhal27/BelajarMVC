using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarMVC.Model.Context
{
   public interface IDbContext : IDisposable
   {
      IDbConnection Conn { get; }
   }

   class DbContext : IDbContext
   {
      private IDbConnection _conn;
      private string _connString;

      public DbContext()
      {
         _connString = "server=localhost;database=csmvc;uid=root;pwd=master";
      }

      public IDbConnection Conn
      {
         get
         {
            return _conn ?? (_conn = GetOpenConnection(_connString));
         }
      }

      private IDbConnection GetOpenConnection(string connString)
      {
         IDbConnection conn = null;

         try
         {
            conn = new MySqlConnection(connString);
            conn.Open();
         }
         catch
         {
         }

         return conn;
      }

      public void Dispose()
      {
         if (_conn != null)
         {
            try
            {
               if (_conn.State != ConnectionState.Closed) _conn.Close();
            }
            finally
            {
               _conn.Dispose();
            }
         }

         GC.SuppressFinalize(this);
      }
   }
}
