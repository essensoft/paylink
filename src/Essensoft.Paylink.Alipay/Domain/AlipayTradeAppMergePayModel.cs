using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeAppMergePayModel Data Structure.
    /// </summary>
    public class AlipayTradeAppMergePayModel : AlipayObject
    {
        /// <summary>
        /// 预下单号。通过 alipay.trade.merge.precreate(统一收单合并支付预创建接口)返回。
        /// </summary>
        [JsonPropertyName("pre_order_no")]
        public string PreOrderNo { get; set; }
    }
}
