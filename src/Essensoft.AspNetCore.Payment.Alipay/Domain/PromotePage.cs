using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromotePage Data Structure.
    /// </summary>
    public class PromotePage : AlipayObject
    {
        /// <summary>
        /// 留资页页面ID
        /// </summary>
        [JsonPropertyName("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// 留资页名称
        /// </summary>
        [JsonPropertyName("page_name")]
        public string PageName { get; set; }

        /// <summary>
        /// 留资页状态
        /// </summary>
        [JsonPropertyName("page_status")]
        public string PageStatus { get; set; }

        /// <summary>
        /// 推广页类型: TRADE-交易类;COLLECT_INFO-留资类
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
