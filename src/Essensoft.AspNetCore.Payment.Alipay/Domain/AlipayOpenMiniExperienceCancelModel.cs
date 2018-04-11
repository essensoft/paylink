using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniExperienceCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniExperienceCancelModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        [XmlElement("app_version")]
        public string AppVersion { get; set; }
    }
}
