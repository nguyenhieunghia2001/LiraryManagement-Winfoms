using LiraryManagerment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiraryManagerment.Repositiorys
{
    public class ReaderRepository
    {
        public List<Docgia> getAllReader()
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                return db.Docgia.ToList();
            }
        }
        public Docgia getReaderbyEmail(string email)
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                return db.Docgia.Where(x => x.Email.ToLower().Contains(email.ToLower())).FirstOrDefault();
            }
        }
    }
}
