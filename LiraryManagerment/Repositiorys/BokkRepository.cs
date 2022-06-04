using LiraryManagerment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiraryManagerment.Repositiorys
{
    public class BokkRepository
    {
        public List<Sach> getAllBook()
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                return db.Sach.ToList();
            }
        }

        public Sach getBookBuId(int id)
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                return db.Sach.Where(b => b.Id == id).FirstOrDefault();
            }
        }
        
        public List<Sach> findBook(string filter)
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                return db.Sach.Where(s => s.TacGia.Contains(filter)
                                            || s.TenSach.Contains(filter))
                              .ToList();
            }
        }
    }
}
