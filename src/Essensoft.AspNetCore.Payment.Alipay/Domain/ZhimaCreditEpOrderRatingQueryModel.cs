using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpOrderRatingQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpOrderRatingQueryModel : AlipayObject
    {
        /// <summary>
        /// 芝麻企业信用评估订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
