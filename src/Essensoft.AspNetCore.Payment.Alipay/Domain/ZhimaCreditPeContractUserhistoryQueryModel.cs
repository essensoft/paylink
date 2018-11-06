using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeContractUserhistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeContractUserhistoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动名
        /// </summary>
        [JsonProperty("activity_name")]
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 场景类目
        /// </summary>
        [JsonProperty("category")]
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("uid")]
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
