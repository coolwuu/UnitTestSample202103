namespace Model.Interface
{
    public interface IAuthService
    {
        bool Login(string username, string password);
    }
}