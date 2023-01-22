namespace cwiczenia_8_APBD_INT.Helpers
{
    public enum DbAnswer
    {
        OK = 200,
        PasswordLengthIsNotProper,
        UserIsAlreadyRegistered,
        BadPassword,
        UserNotFound,
        RefreshTokenIsExpired
    }
}