namespace Essensoft.AspNetCore.Payment.QPay.Parser
{
    /// <summary>
    /// QPay 解析器。
    /// </summary>
    public interface IQPayParser<T> where T : QPayObject
    {
        T Parse(string body);
    }
}
