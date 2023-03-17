using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
    public class UserRepository : RepositorBase<User>, IUserRepository
    {
        public UserRepository(OnlineShopContext repositoryContext)
            : base(repositoryContext)
        {

        }
    }
}
