namespace TenMinuteMailApi
{
    public interface ITenMinuteMail
    {
        string ObtainEmailBox(bool renew = false);
    }
}
