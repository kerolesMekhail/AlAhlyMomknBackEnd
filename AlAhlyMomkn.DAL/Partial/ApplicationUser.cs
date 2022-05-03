using AlAhlyMomkn.DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.DAL.Models
{
    public partial class ApplicationUser
    {
        public static ApplicationUser Clone(RegisterModel registerModel)
        {
            ApplicationUser applicationUser = new ApplicationUser()
            {
                UserName = registerModel.Username,
                Email = registerModel.Email,
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName
            };
            return applicationUser;


        }
        public static RegisterModel Clone(ApplicationUser applicationUser)
        {
            RegisterModel registerModel  = new RegisterModel()
            {
                Username = applicationUser.UserName,
                Email = applicationUser.Email,
                FirstName = applicationUser.FirstName,
                LastName = applicationUser.LastName
            };
            return registerModel;
        }
    }
}
