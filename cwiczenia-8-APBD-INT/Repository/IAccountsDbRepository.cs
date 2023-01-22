using cwiczenia_8_APBD_INT.Helpers;
using cwiczenia_8_APBD_INT.Models.DTO;
using System.Threading.Tasks;

namespace cwiczenia_8_APBD_INT.Repository
{
    public interface IAccountsDbRepository
    {
        public Task<DbAnswer> RegisterAsync(UserDto dto);
        public Task<LoginHelper> LoginAsync(UserDto dto);
        public Task<LoginHelper> UpdateAccessTokenAsync(RefreshTokenDto dto);
    }
}