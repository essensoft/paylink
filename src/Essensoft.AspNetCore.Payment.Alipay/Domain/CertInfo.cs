using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CertInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CertInfo : AlipayObject
    {
        /// <summary>
        /// 代发时商家上传的收款方证件号码    biz_scene=LOCAL时忽略该参数。
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 代发时商家上传的收款方证件类型。    biz_scene=LOCAL时忽略该参数。
        /// </summary>
        [JsonProperty("cert_type")]
        [XmlElement("cert_type")]
        public string CertType { get; set; }
    }
}
