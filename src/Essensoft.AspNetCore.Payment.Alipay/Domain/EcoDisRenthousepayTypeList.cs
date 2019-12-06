using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EcoDisRenthousepayTypeList Data Structure.
    /// </summary>
    public class EcoDisRenthousepayTypeList : AlipayObject
    {
        /// <summary>
        /// 押金
        /// </summary>
        [JsonPropertyName("foregift_amount")]
        public string ForegiftAmount { get; set; }

        /// <summary>
        /// 可租期（1：1个月，3：三个月，6：半年，12：一年及以上）
        /// </summary>
        [JsonPropertyName("lease_term")]
        public long LeaseTerm { get; set; }

        /// <summary>
        /// 其他费用
        /// </summary>
        [JsonPropertyName("other_amount")]
        public List<EcoRenthouseOtherAmount> OtherAmount { get; set; }

        /// <summary>
        /// 付款方式（1：付一，2：付二）
        /// </summary>
        [JsonPropertyName("pay_type")]
        public long PayType { get; set; }

        /// <summary>
        /// 租金
        /// </summary>
        [JsonPropertyName("room_amount")]
        public string RoomAmount { get; set; }

        /// <summary>
        /// 服务费
        /// </summary>
        [JsonPropertyName("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 服务费单位（m：月, y：年）
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }
    }
}
