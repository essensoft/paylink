using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationIssueConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationIssueConfirmModel : AlipayObject
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [JsonProperty("application_no")]
        [XmlElement("application_no")]
        public string ApplicationNo { get; set; }
    }
}
