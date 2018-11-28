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

      #region >> Fields <<

      private IDbContext _context;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public PemainRepository(IDbContext context)
      {
         _context = context;
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      public IList<Pemain> GetAll()
      {
         var sql = "SELECT pemain.id, pemain.nama, pemain.negara, pemain.keterangan, "
            + "pemain.posisi_id, posisi.nama "
            + "FROM pemain INNER JOIN posisi ON pemain.posisi_id = posisi.id ORDER BY pemain.nama ASC";

         var listPosisi = _context.Conn
            .Query<Pemain, Posisi, Pemain>(sql, (pemain, posisi) =>
            {
               if (posisi != null)
               {
                  pemain.posisi = posisi.nama;
               }

               return pemain;
            }, splitOn: "posisi_id")
            .ToList();

         return listPosisi;
      }

      public Pemain GetByID(int id)
      {
         Pemain obj = _context.Conn.Get<Pemain>(id);

         return obj;
      }

      public Pemain GetByNama(string nama)
      {
         Pemain obj = _context.Conn
            .Query<Pemain>("SELECT * FROM pemain WHERE nama = @nama", new { nama = nama })
            .FirstOrDefault();

         return obj;
      }

      public int Save(Pemain obj)
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

      public int Update(Pemain obj)
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

      public int Delete(Pemain obj)
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
