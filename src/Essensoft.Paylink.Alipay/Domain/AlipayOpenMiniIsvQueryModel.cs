using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniIsvQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniIsvQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务商代商家创建小程序，由支付宝开放平台返回的订单号用于后续查询处理进展。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
