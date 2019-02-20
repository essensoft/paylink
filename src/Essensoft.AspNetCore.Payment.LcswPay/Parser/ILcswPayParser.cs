namespace Essensoft.AspNetCore.Payment.LcswPay.Parser
{
    /// <summary>
    /// 利楚商务扫呗支付响应解析器
    /// </summary>
    public interface ILcswPayParser<T> where T:LcswPayResponse
    {
        /// <summary>
        /// 把响应字符串解释成相应的领域对象
        /// </summary>
        /// <param name="body">响应字符串</param>
        /// <returns>领域对象</returns>
        T Parse(string body);
    }
}
