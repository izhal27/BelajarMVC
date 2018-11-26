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
   public interface IPemainRepository : IBaseRepository<Pemain>
   {
      Pemain GetByID(int id);
      Pemain GetByNama(string nama);
   }

   public class PemainRepository : IPemainRepository
   {
      private IDbContext _context;

      public PemainRepository(IDbContext context)
      {
         _context = context;
      }
      
      public IList<Pemain> GetAll()
      {
         var listPosisi = _context.DB.GetAll<Pemain>().ToList();

         return listPosisi;
      }

      public Pemain GetByID(int id)
      {
         Pemain obj = _context.DB.Get<Pemain>(id);

         return obj;
      }

      public Pemain GetByNama(string nama)
      {
         Pemain obj = _context.DB
            .Query<Pemain>("SELECT * FROM pemain WHERE nama = @nama", new { nama = nama })
            .FirstOrDefault();

         return obj;
      }

      public int Save(Pemain obj)
      {
         var result = (int)_context.DB.Insert(obj);

         return result;
      }

      public int Update(Pemain obj)
      {
         var result = _context.DB.Update(obj) ? 1 : 0;

         return result;
      }

      public int Delete(Pemain obj)
      {
         var result = _context.DB.Delete(obj) ? 1 : 0;

         return result;
      }

   }
}
