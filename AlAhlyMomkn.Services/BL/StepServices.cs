using AlAhlyMomkn.DAL.Models;
using AlAhlyMomkn.DTO.ViewModel;
using AlAhlyMomkn.Repository;
using AlAhlyMomkn.Repository.IRepository;
using AlAhlyMomkn.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.Services.BL
{
    public class StepServices : IStep
    {
        private readonly IRepositoryStep _repository;
        public StepServices(IRepositoryStep repository)
        {
            _repository=repository;
        }

        public bool Add(Step entity)
        {
            try
            {
                if (entity != null)
                {
                    _repository.Add(entity);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Delete(Step entity)
        {
            try
            {
                if (entity != null)
                {
                     _repository.Delete(entity);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public IEnumerable<Step> FindAll()
        {
            try
            {
                var Steps = _repository.FindAll();
                return Steps;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Step GetById(int id)
        {
            try
            {
                var Step = _repository.GetById(id);
                return Step;
            }
            catch (Exception ex)
            {
                return new Step();
            }
        }
    }
}
