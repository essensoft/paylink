using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageDownloadResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepageDownloadResponse : AlipayResponse
    {
        /// <summary>
        /// 转化事件ID
        /// </summary>
        [JsonPropertyName("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 留资属性实例数据列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<PromotePageData> List { get; set; }

        /// <summary>
        /// 分页参数之页数，从1开始
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数之每页大小，最大1000
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页参数之总数据量
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
