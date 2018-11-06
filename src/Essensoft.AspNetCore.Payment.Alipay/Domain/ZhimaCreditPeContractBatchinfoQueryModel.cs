using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeContractBatchinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractBatchinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动名
        /// </summary>
        [JsonProperty("activity_name")]
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 查询批次号，从1开始计数
        /// </summary>
        [JsonProperty("batch_index")]
        [XmlElement("batch_index")]
        public long BatchIndex { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [JsonProperty("category")]
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 批量查询数据日期
        /// </summary>
        [JsonProperty("query_date")]
        [XmlElement("query_date")]
        public string QueryDate { get; set; }

        /// <summary>
        /// 查询事务号
        /// </summary>
        [JsonProperty("transaction_id")]
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
