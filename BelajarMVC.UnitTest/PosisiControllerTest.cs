using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BelajarMVC.Controller;
using BelajarMVC.Model.Entity;

namespace BelajarMVC.UnitTest
{
   [TestClass]
   public class PosisiControllerTest
   {
      PosisiController _controller;

      [TestInitialize]
      public void Initial()
      {
         _controller = new PosisiController();
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
         Assert.AreEqual("Penjaga Gawang", obj.nama);
      }

      [TestMethod]
      public void Save()
      {
         Posisi obj = new Posisi
         {
            nama = "Sayap Sayapan",
         };

         var result = _controller.Save(obj);
         Console.WriteLine(result);

         Assert.IsNotNull(result);
         Assert.IsTrue(result > 0);
      }

      [TestMethod]
      public void Update()
      {
         Posisi obj = new Posisi
         {
            id = 2,
            nama = "Bek Sentral",
         };

         var result = _controller.Update(obj);
         Console.WriteLine(result);

         Assert.IsNotNull(result);
         Assert.IsTrue(result > 0);
      }

      [TestMethod]
      public void Delete()
      {
         Posisi obj = new Posisi
         {
            id = 10
         };

         var result = _controller.Delete(obj);
         Console.WriteLine(result);

         Assert.IsNotNull(result);
         Assert.IsTrue(result > 0);
      }
   }
}
