namespace Essensoft.AspNetCore.Payment.LianLianPay.Parser
{
    /// <summary>
    /// LianLianPay API响应解释器接口。
    /// </summary>
    /// <typeparam name="T">领域对象</typeparam>
    public interface ILianLianPayParser<T> where T : LianLianPayResponse
    {
        /// <summary>
        /// 把响应字符串解释成相应的领域对象。
        /// </summary>
        /// <param name="body">响应字符串</param>
        /// <returns>领域对象</returns>
        T Parse(string body);
    }
}
