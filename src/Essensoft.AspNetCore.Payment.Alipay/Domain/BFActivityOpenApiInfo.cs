using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BFActivityOpenApiInfo Data Structure.
    /// </summary>
    public class BFActivityOpenApiInfo : AlipayObject
    {
        /// <summary>
        /// 活动收费配置信息
        /// </summary>
        [JsonPropertyName("activity_fund_infos")]
        public List<BFActivityFundInfo> ActivityFundInfos { get; set; }

        /// <summary>
        /// 活动模板ID
        /// </summary>
        [JsonPropertyName("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// true 有效活动/false 失效活动
        /// </summary>
        [JsonPropertyName("available")]
        public bool Available { get; set; }

        /// <summary>
        /// 开始期
        /// </summary>
        [JsonPropertyName("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 时间类型
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonPropertyName("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 活动码信息
        /// </summary>
        [JsonPropertyName("pc_id")]
        public string PcId { get; set; }

        /// <summary>
        /// 权益产品码
        /// </summary>
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 活动费率的版本信息
        /// </summary>
        [JsonPropertyName("rate_version")]
        public string RateVersion { get; set; }
    }
}
