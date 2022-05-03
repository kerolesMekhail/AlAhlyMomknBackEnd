using AlAhlyMomkn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.Repository.IRepository
{
    public interface IRepositoryItem
    {
        bool Add(Item entity);
        bool Update(Item entity);
        Item GetById(int id);
        void Delete(Item entity);
    }
}
