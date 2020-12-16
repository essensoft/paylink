using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HuanxuTradeOrderCloseModel Data Structure.
    /// </summary>
    public class HuanxuTradeOrderCloseModel : AlipayObject
    {
        /// <summary>
        /// 支付id，焕旭针对每一笔支付请求生成的唯一支付凭证
        /// </summary>
        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; }
    }
}
