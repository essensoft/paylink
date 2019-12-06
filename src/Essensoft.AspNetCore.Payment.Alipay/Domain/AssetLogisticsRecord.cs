using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetLogisticsRecord Data Structure.
    /// </summary>
    public class AssetLogisticsRecord : AlipayObject
    {
        /// <summary>
        /// 物流节点详情描述
        /// </summary>
        [JsonPropertyName("last_logistics_detail")]
        public string LastLogisticsDetail { get; set; }

        /// <summary>
        /// 物流公司Code
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流时间
        /// </summary>
        [JsonPropertyName("logistics_gmt_modified")]
        public string LogisticsGmtModified { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        [JsonPropertyName("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 物流状态描述
        /// </summary>
        [JsonPropertyName("logistics_status_desc")]
        public string LogisticsStatusDesc { get; set; }
    }
}
