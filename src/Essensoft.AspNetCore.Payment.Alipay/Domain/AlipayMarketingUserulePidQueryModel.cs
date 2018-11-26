using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingUserulePidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingUserulePidQueryModel : AlipayObject
    {
        /// <summary>
        /// 合作伙伴ID，传入ID比如与当前APPID所属合作伙伴ID一致，否则会报权限不足
        /// </summary>
        [JsonProperty("pid")]
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
