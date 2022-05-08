using MovieSolvex.API.Models;

namespace MovieSolvex.API.Repository
{
    public interface ITokenRepository
    {
        Tokens Authenticate(Users user);
    }
}
