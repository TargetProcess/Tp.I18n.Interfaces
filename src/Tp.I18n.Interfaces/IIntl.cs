namespace Tp.I18n
{
    public interface IIntl
    {
        IFormattedMessage GetFormattedMessage(string token);
        IFormattedMessage GetFormattedMessage(string token, object data);
    }
}