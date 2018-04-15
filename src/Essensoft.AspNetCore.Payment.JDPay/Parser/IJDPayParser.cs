namespace Essensoft.AspNetCore.Payment.JDPay.Parser
{
    /// <summary>
    /// 京东支付结果解析
    /// </summary>
    public interface IJDPayParser<T> where T : JDPayResponse
    {
        T Parse(string body);
    }
}
