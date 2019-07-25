using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetLogisticsRecord Data Structure.
    /// </summary>
    [Serializable]
    public class AssetLogisticsRecord : AlipayObject
    {
        /// <summary>
        /// 物流节点详情描述
        /// </summary>
        [JsonProperty("last_logistics_detail")]
        public string LastLogisticsDetail { get; set; }

        /// <summary>
        /// 物流公司Code
        /// </summary>
        [JsonProperty("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流时间
        /// </summary>
        [JsonProperty("logistics_gmt_modified")]
        public string LogisticsGmtModified { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        [JsonProperty("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 物流状态描述
        /// </summary>
        [JsonProperty("logistics_status_desc")]
        public string LogisticsStatusDesc { get; set; }
    }
}
