using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCdpAdvertiseOperateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCdpAdvertiseOperateModel : AlipayObject
    {
        /// <summary>
        /// 广告ID，唯一标识一条广告
        /// </summary>
        [JsonProperty("ad_id")]
        [XmlElement("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// 操作类型，目前包括上线和下线，分别传入：online(ONLINE)和offline(OFFLINE)
        /// </summary>
        [JsonProperty("operate_type")]
        [XmlElement("operate_type")]
        public string OperateType { get; set; }
    }
}
