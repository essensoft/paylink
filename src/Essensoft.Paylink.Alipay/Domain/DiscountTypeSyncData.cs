using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DiscountTypeSyncData Data Structure.
    /// </summary>
    public class DiscountTypeSyncData : AlipayObject
    {
        /// <summary>
        /// 商户回传的优惠金额，如用户享受的红包金额，单位元
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 商户数据回传的优惠信息的名称。
        /// </summary>
        [JsonPropertyName("discount_desc")]
        public string DiscountDesc { get; set; }
    }
}
