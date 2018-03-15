namespace Essensoft.AspNetCore.JdPay.Parser
{
    /// <summary>
    /// 微信支付结果解析
    /// </summary>
    public interface IJdPayParser<T> where T : JdPayObject
    {
        T Parse(JdPayDictionary dic);
    }
}
