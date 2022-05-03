using AlAhlyMomkn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.Repository.IRepository
{
    public interface IRepositoryStep
    {
        IEnumerable<Step> FindAll();
        void Delete(Step entity);
        bool Add(Step entity);
        Step GetById(int id);
    }
}
