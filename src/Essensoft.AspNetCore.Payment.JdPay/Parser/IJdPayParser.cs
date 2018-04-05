namespace Essensoft.AspNetCore.Payment.JdPay.Parser
{
    /// <summary>
    /// 京东支付结果解析
    /// </summary>
    public interface IJdPayParser<T> where T : JdPayResponse
    {
        T Parse(string body);
    }
}
