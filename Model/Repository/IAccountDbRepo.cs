using System.Data;

namespace Model.Repository
{
    internal interface IAccountDbRepo
    {
        DataTable Login(string username, string password);
    }
}