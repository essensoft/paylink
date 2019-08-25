using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherVO Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherVO : AlipayObject
    {
        /// <summary>
        /// 券生效时间
        /// </summary>
        [JsonProperty("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 券失效时间
        /// </summary>
        [JsonProperty("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 券门槛金额，单位分
        /// </summary>
        [JsonProperty("threshold_amount")]
        public string ThresholdAmount { get; set; }

        /// <summary>
        /// 券面额，单位分
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 券实例id
        /// </summary>
        [JsonProperty("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [JsonProperty("voucher_template_id")]
        public string VoucherTemplateId { get; set; }
    }
}
