using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BillSyncExtInfo Data Structure.
    /// </summary>
    public class BillSyncExtInfo : AlipayObject
    {
        /// <summary>
        /// 账单类型
        /// </summary>
        [JsonPropertyName("order_pay_type")]
        public string OrderPayType { get; set; }
    }
}
