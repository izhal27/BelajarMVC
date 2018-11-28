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

      #region >> Fields <<

      private IDbContext _context;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public PosisiRepository(IDbContext context)
      {
         _context = context;
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      public IList<Posisi> GetAll()
      {
         var listPosisi = _context.Conn.Query<Posisi>("SELECT * FROM posisi ORDER BY nama ASC").ToList();

         return listPosisi;
      }

      public Posisi GetByID(int id)
      {
         Posisi obj = _context.Conn.Get<Posisi>(id);

         return obj;
      }

      public Posisi GetByNama(string nama)
      {
         Posisi obj = _context.Conn
            .Query<Posisi>("SELECT * FROM posisi WHERE nama = @nama", new { nama = nama })
            .FirstOrDefault();

         return obj;
      }

      public int Save(Posisi obj)
      {
         var result = 0;

         try
         {
            result = (int)_context.Conn.Insert(obj);
         }
         catch
         {
            return result;
         }

         return result;
      }

      public int Update(Posisi obj)
      {
         var result = 0;

         try
         {
            result = _context.Conn.Update(obj) ? 1 : 0;
         }
         catch
         {
            return result;
         }

         return result;
      }

      public int Delete(Posisi obj)
      {
         var result = 0;

         try
         {
            result = _context.Conn.Delete(obj) ? 1 : 0;
         }
         catch
         {
            return result;
         }

         return result;
      }

      #endregion

   }
}
