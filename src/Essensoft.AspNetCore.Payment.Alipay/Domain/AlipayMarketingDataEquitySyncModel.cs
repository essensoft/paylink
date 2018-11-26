using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataEquitySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataEquitySyncModel : AlipayObject
    {
        /// <summary>
        /// biz_time
        /// </summary>
        [JsonProperty("biz_time")]
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// equity_code
        /// </summary>
        [JsonProperty("equity_code")]
        [XmlElement("equity_code")]
        public string EquityCode { get; set; }

        /// <summary>
        /// equity_from
        /// </summary>
        [JsonProperty("equity_from")]
        [XmlElement("equity_from")]
        public string EquityFrom { get; set; }

        /// <summary>
        /// equity_id
        /// </summary>
        [JsonProperty("equity_id")]
        [XmlElement("equity_id")]
        public string EquityId { get; set; }

        /// <summary>
        /// equity_info
        /// </summary>
        [JsonProperty("equity_info")]
        [XmlElement("equity_info")]
        public EquityInfo EquityInfo { get; set; }

        /// <summary>
        /// original_biz_no
        /// </summary>
        [JsonProperty("original_biz_no")]
        [XmlElement("original_biz_no")]
        public string OriginalBizNo { get; set; }

        /// <summary>
        /// original_biz_type
        /// </summary>
        [JsonProperty("original_biz_type")]
        [XmlElement("original_biz_type")]
        public string OriginalBizType { get; set; }

        /// <summary>
        /// out_biz_no
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝userid
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
