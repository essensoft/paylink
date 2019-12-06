using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppJfexportBillQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppJfexportBillQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝的业务订单号，具有唯一性和幂等性
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务类型英文名称
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 拓展字段，json串(key-value对)
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }
    }
}
