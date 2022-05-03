using AlAhlyMomkn.DAL.Models;
using AlAhlyMomkn.Repository.DbContext;
using AlAhlyMomkn.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.Repository.Repository
{
    public class RepositoryStep : IRepositoryStep
    {
        protected readonly ApplicationDbContext _context;
        public RepositoryStep(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Step entity)
        {
            _context.Steps.Add(entity);
            _context.SaveChanges();
            return true;
        }
        public void Delete(Step entity)
        {
            if(entity != null)
            {
                var Items = _context.Items.Where(x => x.StepId == entity.Id).ToList();
                foreach (var item in Items)
                {
                    _context.Items.Remove(item);
                    _context.SaveChanges();
                }
                _context.Steps.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Step> FindAll()
        {
            IEnumerable<Step> query = _context.Set<Step>().Include(x => x.items);
            return query;
        }

        public Step GetById(int id)
        {
            return _context.Steps.Find(id);
        }
    }
}
