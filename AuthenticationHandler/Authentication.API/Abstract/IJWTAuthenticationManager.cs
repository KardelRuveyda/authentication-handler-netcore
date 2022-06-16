namespace Authentication.API.Abstract
{
    public interface IJWTAuthenticationManager
    {
        string Authenticate(string username, string password);

    }
}
