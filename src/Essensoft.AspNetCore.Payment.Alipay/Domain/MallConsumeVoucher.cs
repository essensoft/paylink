using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MallConsumeVoucher Data Structure.
    /// </summary>
    public class MallConsumeVoucher : AlipayObject
    {
        /// <summary>
        /// 券品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 消费送活动id
        /// </summary>
        [JsonPropertyName("source_camp")]
        public string SourceCamp { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券面额或者折扣
        /// </summary>
        [JsonPropertyName("worth_value")]
        public string WorthValue { get; set; }
    }
}
