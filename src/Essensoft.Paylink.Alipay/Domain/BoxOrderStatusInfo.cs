using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BoxOrderStatusInfo Data Structure.
    /// </summary>
    public class BoxOrderStatusInfo : AlipayObject
    {
        /// <summary>
        /// 工单数据
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 最新工单状态
        /// </summary>
        [JsonPropertyName("latest_status")]
        public string LatestStatus { get; set; }
    }
}
