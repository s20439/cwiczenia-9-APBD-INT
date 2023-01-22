using System;

namespace cwiczenia_8_APBD_INT.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RerfreshTokenExpiration { get; set; }
    }
}