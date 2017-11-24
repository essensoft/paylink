namespace Essensoft.AspNetCore.QPay.Parser
{
    /// <summary>
    /// QQ钱包结果解析
    /// </summary>
    public interface IQPayParser<T> where T : QPayObject
    {
        T Parse(string body);
    }
}
