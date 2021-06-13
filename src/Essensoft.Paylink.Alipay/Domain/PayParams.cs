using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PayParams Data Structure.
    /// </summary>
    public class PayParams : AlipayObject
    {
        /// <summary>
        /// 普通异步支付, 传入该参数时，如果满足受理条件，会先同步受理支付，然后在异步调度推进支付  NORMAL_ASYNC: 普通异步，受理成功之后，会在交易关单之前通过一定的策略重试  NEAR_REAL_TIME_ASYNC: 准实时异步，受理成功之后，会准实时发起1次调度
        /// </summary>
        [JsonPropertyName("async_type")]
        public string AsyncType { get; set; }
    }
}
