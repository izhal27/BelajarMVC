using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BelajarMVC.Controller;
using BelajarMVC.Model.Entity;

namespace BelajarMVC.UnitTest
{
   [TestClass]
   public class PemainControllerTest
   {
      PemainController _controller;

      [TestInitialize]
      public void Initial()
      {
         _controller = new PemainController();
      }

      [TestCleanup]
      public void Cleanup()
      {
         _controller = null;
      }

      [TestMethod]
      public void GetAll()
      {
         var listObj = _controller.GetAll();

         Assert.IsNotNull(listObj);
         Assert.IsTrue(listObj.Count > 0);
      }

      [TestMethod]
      public void GetByID()
      {
         var obj = _controller.GetByID(1);

         Assert.IsNotNull(obj);
         Assert.AreEqual(1, obj.id);
         Assert.AreEqual("Mesut Ozil", obj.nama);
      }

      [TestMethod]
      public void Save()
      {
         Pemain obj = new Pemain
         {
            nama = "Alex Iwobi",
            posisi_id = 6,
            negara = "Jerman"
         };

         var result = _controller.Save(obj);
         Console.WriteLine(result);

         Assert.IsNotNull(result);
         Assert.IsTrue(result > 0);
      }

      [TestMethod]
      public void Update()
      {
         Pemain obj = new Pemain
         {
            id = 2,
            nama = "Henrikh Mkhitaryan",
            posisi_id = 6,
            negara = "Armenia"
         };

         var result = _controller.Update(obj);
         Console.WriteLine(result);

         Assert.IsNotNull(result);
         Assert.IsTrue(result > 0);
      }

      [TestMethod]
      public void Delete()
      {
         Pemain obj = new Pemain
         {
            id = 3
         };

         var result = _controller.Delete(obj);
         Console.WriteLine(result);

         Assert.IsNotNull(result);
         Assert.IsTrue(result > 0);
      }
   }
}
