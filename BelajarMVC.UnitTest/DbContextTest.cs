using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BelajarMVC.Model.Context;
using System.Data;

namespace BelajarMVC.UnitTest
{
   [TestClass]
   public class DbContextTest
   {
      private IDbContext _context;

      [TestInitialize]
      public void Initial()
      {
         _context = new DbContext();
      }

      [TestMethod]
      public void TestKoneksi()
      {
         var conn = _context.Conn;

         Assert.IsNotNull(conn);
         Assert.IsTrue(conn.State == ConnectionState.Open);
      }

      [TestCleanup]
      public void Cleanup()
      {
         _context = null;
      }
   }
}
