namespace Essensoft.AspNetCore.Payment.JdPay.Parser
{
    /// <summary>
    /// 京东支付结果解析
    /// </summary>
    public interface IJdPayParser<T> where T : JdPayObject
    {
        T Parse(JdPayDictionary dic);
    }
}
