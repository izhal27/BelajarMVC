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
   public interface IPosisiController : IBaseController<Posisi>
   {
      Posisi GetByID(int id);
   }

   public class PosisiController : IPosisiController
   {

      #region >> Fields <<

      private IPosisiRepository _repository;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      public IList<Posisi> GetAll()
      {
         var listPosisi = new List<Posisi>();

         using (IDbContext context = new DbContext())
         {
            _repository = new PosisiRepository(context);
            listPosisi = _repository.GetAll().ToList();
         }

         return listPosisi;
      }

      public Posisi GetByID(int id)
      {
         Posisi obj = null;

         using (IDbContext context = new DbContext())
         {
            _repository = new PosisiRepository(context);
            obj = _repository.GetByID(id);
         }

         return obj;
      }

      public int Save(Posisi obj)
      {
         if (!NamaIsUnique(obj.nama))
         {
            return -1;
         }

         int result = 0;

         using (IDbContext context = new DbContext())
         {
            _repository = new PosisiRepository(context);
            result = _repository.Save(obj);
         }

         return result;
      }

      public int Update(Posisi obj)
      {
         if (!NamaIsUnique(obj.nama, obj.id))
         {
            return -1;
         }

         int result = 0;

         using (IDbContext context = new DbContext())
         {
            _repository = new PosisiRepository(context);
            result = _repository.Update(obj);
         }

         return result;
      }

      public int Delete(Posisi obj)
      {
         int result = 0;

         using (IDbContext context = new DbContext())
         {
            _repository = new PosisiRepository(context);
            result = _repository.Delete(obj);
         }

         return result;
      }

      private bool NamaIsUnique(string nama, int id = 0)
      {
         Posisi obj = null;

         using (IDbContext context = new DbContext())
         {
            _repository = new PosisiRepository(context);
            obj = _repository.GetByNama(nama);
         }

         if (obj == null || obj.id == id)
         {
            return true; // unique
         }

         return false;
      }

      #endregion

   }
}
