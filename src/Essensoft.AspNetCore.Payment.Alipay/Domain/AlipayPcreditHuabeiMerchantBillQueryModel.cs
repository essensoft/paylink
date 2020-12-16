using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantBillQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantBillQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户模版ID
        /// </summary>
        [JsonPropertyName("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 账单结束时间，与开始时间不能超过30天
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 账单开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
