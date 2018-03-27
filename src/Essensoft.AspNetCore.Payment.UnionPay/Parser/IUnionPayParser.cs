using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.UnionPay.Parser
{
    /// <summary>
    /// 微信支付结果解析
    /// </summary>
    public interface IUnionPayParser<T> where T : UnionPayObject
    {
        T Parse(Dictionary<string,string> dic);
    }
}
