using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataAntlogmngActivitypagespmCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingDataAntlogmngActivitypagespmCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 负责人的工号
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// spma位
        /// </summary>
        [JsonPropertyName("spma")]
        public string Spma { get; set; }

        /// <summary>
        /// 页面的spmb值code
        /// </summary>
        [JsonPropertyName("spmb")]
        public string Spmb { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 凤蝶页面的url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
