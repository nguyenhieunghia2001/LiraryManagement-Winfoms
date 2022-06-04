using LiraryManagerment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiraryManagerment.Repositiorys
{
    public class StaffRepository
    {
        public List<Nhanvien> getAllStaff()
        {
            using(var db = new heroku_c5dfe82f5ebcccfContext())
            {
                return db.Nhanvien.ToList();
            }
        }
    }
}
