using System.Data;
using Model.CustomException;
using Model.Interface;
using Model.Repository;

namespace Model.Service
{
    public class AuthService2 : IAuthService
    {
        private readonly IAccountDbRepo _accountDbRepo;

        public AuthService2()
        {
            _accountDbRepo = new AccountDbRepo();
        }
        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new InvalidParameterException("Username/Password cannot be empty.");
            }

            var dt = _accountDbRepo.Login(username, password);
            var dbErrorCode = dt.Rows[0].Field<int>("ErrorCode");
            if (dbErrorCode.Equals(0))
            {
                return true;
            }

            return false;
        }
    }
}