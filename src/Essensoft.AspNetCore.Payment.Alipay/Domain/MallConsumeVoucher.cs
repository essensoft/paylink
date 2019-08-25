using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MallConsumeVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class MallConsumeVoucher : AlipayObject
    {
        /// <summary>
        /// 券品牌名称
        /// </summary>
        [JsonProperty("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 消费送活动id
        /// </summary>
        [JsonProperty("source_camp")]
        public string SourceCamp { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [JsonProperty("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券面额或者折扣
        /// </summary>
        [JsonProperty("worth_value")]
        public string WorthValue { get; set; }
    }
}
