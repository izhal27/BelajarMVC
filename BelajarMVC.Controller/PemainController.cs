using BelajarMVC.Model.Context;
using BelajarMVC.Model.Entity;
using BelajarMVC.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarMVC.Controller
{
   public interface IPemainController : IBaseController<Pemain>
   {
      Pemain GetByID(int id);
   }

   public class PemainController : IPemainController
   {
      IPemainRepository _repository;

      public IList<Pemain> GetAll()
      {
         var lstObj = new List<Pemain>();

         using (IDbContext context = new DbContext())
         {
            _repository = new PemainRepository(context);
            lstObj = _repository.GetAll().ToList();
         }

         return lstObj;
      }

      public Pemain GetByID(int id)
      {
         Pemain obj = null;

         using (IDbContext context = new DbContext())
         {
            _repository = new PemainRepository(context);
            obj = _repository.GetByID(id);
         }

         return obj;
      }

      public int Save(Pemain obj)
      {
         if (!NamaIsUnique(obj.nama))
         {
            return -1;
         }

         int result = 0;

         using (IDbContext context = new DbContext())
         {
            _repository = new PemainRepository(context);
            result = _repository.Save(obj);
         }

         return result;
      }

      public int Update(Pemain obj)
      {
         if (!NamaIsUnique(obj.nama, obj.id))
         {
            return -1;
         }

         int result = 0;

         using (IDbContext context = new DbContext())
         {
            _repository = new PemainRepository(context);
            result = _repository.Update(obj);
         }

         return result;
      }

      public int Delete(Pemain obj)
      {
         int result = 0;

         using (IDbContext context = new DbContext())
         {
            _repository = new PemainRepository(context);
            result = _repository.Delete(obj);
         }

         return result;
      }

      private bool NamaIsUnique(string nama, int id = 0)
      {
         Pemain obj = null;

         using (IDbContext context = new DbContext())
         {
            _repository = new PemainRepository(context);
            obj = _repository.GetByNama(nama);
         }

         if (obj == null || obj.id == id)
         {
            return true; // unique
         }

         return false;
      }

   }
}
