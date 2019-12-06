using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OfferObject Data Structure.
    /// </summary>
    public class OfferObject : AlipayObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 分类编码
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 展台ID，这个是唯一主键，这个最重要，作为我方的source_offer_id存在表里，而且是唯一的
        /// </summary>
        [JsonPropertyName("displayapp_id")]
        public string DisplayappId { get; set; }

        /// <summary>
        /// 展台操作备注
        /// </summary>
        [JsonPropertyName("displayapp_memo")]
        public string DisplayappMemo { get; set; }

        /// <summary>
        /// 展台名称
        /// </summary>
        [JsonPropertyName("displayapp_name")]
        public string DisplayappName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("displayapp_status")]
        public string DisplayappStatus { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonPropertyName("displayapp_url")]
        public string DisplayappUrl { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 实际的URL
        /// </summary>
        [JsonPropertyName("service_url")]
        public string ServiceUrl { get; set; }
    }
}
