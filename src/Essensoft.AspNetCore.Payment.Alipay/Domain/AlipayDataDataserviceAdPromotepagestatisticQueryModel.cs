using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepagestatisticQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepagestatisticQueryModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 数据查询开始时间，查询时间间隔不能大于30天，点时间格式：yyyyMMdd
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 推广页id,获取推广页接口可以获取pageId
        /// </summary>
        [JsonPropertyName("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// 灯火商家ID
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 数据查询开始时间，查询时间间隔不能大于30天，点时间格式：yyyyMMdd
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
