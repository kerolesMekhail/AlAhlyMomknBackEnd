using AlAhlyMomkn.DAL.Models;
using AlAhlyMomkn.Repository.DbContext;
using AlAhlyMomkn.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.Repository.Repository
{
    public class RepositoryItem : IRepositoryItem
    {
        protected readonly ApplicationDbContext _context;
        public RepositoryItem(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Item entity)
        {
            _context.Items.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public void Delete(Item entity)
        {
            _context.Items.Remove(entity);
            _context.SaveChanges();
        }

        public Item GetById(int id)
        {
            return _context.Items.Find(id);
        }

        public bool Update(Item entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return true;
        }
    }
}
