using BelajarMVC.Model.Context;
using BelajarMVC.Model.Entity;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarMVC.Model.Repository
{
   public interface IPosisiRepository : IBaseRepository<Posisi>
   {
      Posisi GetByID(int id);
      Posisi GetByNama(string nama);
   }

   public class PosisiRepository : IPosisiRepository
   {
      private IDbContext _context;

      public PosisiRepository(IDbContext context)
      {
         _context = context;
      }

      public IList<Posisi> GetAll()
      {
         var listPosisi = _context.DB.GetAll<Posisi>().ToList();         

         return listPosisi;
      }

      public Posisi GetByID(int id)
      {
         Posisi obj = _context.DB.Get<Posisi>(id);

         return obj;
      }

      public Posisi GetByNama(string nama)
      {
         Posisi obj = _context.DB
            .Query<Posisi>("SELECT * FROM posisi WHERE nama = @nama", new { nama = nama })
            .FirstOrDefault();

         return obj;
      }

      public int Save(Posisi obj)
      {
         var result = (int)_context.DB.Insert(obj);

         return result;
      }

      public int Update(Posisi obj)
      {
         var result = _context.DB.Update(obj) ? 1 : 0;

         return result;
      }

      public int Delete(Posisi obj)
      {
         var result = _context.DB.Delete(obj) ? 1 : 0;

         return result;
      }

   }
}
