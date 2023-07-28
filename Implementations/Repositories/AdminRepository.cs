using e_commerce.Context;
using e_commerce.Entities;

namespace e_commerce.Implementations.Repositories
{
    public class AdminRepository
    {
        private readonly e_commerceContext _e_commerceContext ;
        public AdminRepository (e_commerceContext e_CommerceContext)
        {
            _e_commerceContext = e_CommerceContext;
        }
        public Admin CreateAdmin(Admin admin)
        {
            _e_commerceContext.Add(admin);
            _e_commerceContext.SaveChanges();
            return(admin);
        }
        public Admin UpdateAdmin(Admin admin)
        {
            _e_commerceContext.Admins.Update(admin);
            _e_commerceContext.SaveChanges();
            return (admin);
        }
        public void ChangePassword(Admin admin)
        {
            _e_commerceContext.Update(admin);
            _e_commerceContext.SaveChanges();
        }
    }
}