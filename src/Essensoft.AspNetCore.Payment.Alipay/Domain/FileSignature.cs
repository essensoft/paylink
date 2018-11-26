using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FileSignature Data Structure.
    /// </summary>
    [Serializable]
    public class FileSignature : AlipayObject
    {
        /// <summary>
        /// 签约主体证件号，关联principal对象
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 图章id/图章模板id
        /// </summary>
        [JsonProperty("seal_id")]
        [XmlElement("seal_id")]
        public string SealId { get; set; }

        /// <summary>
        /// 签章位置描述
        /// </summary>
        [JsonProperty("seal_position")]
        [XmlElement("seal_position")]
        public SealPosition SealPosition { get; set; }

        /// <summary>
        /// 电子图章类型  1 : 图章模板自动合成  2 : 托管图章编号
        /// </summary>
        [JsonProperty("seal_type")]
        [XmlElement("seal_type")]
        public long SealType { get; set; }

        /// <summary>
        /// 签约原因描述，可展示在PDF签名区
        /// </summary>
        [JsonProperty("sign_reason")]
        [XmlElement("sign_reason")]
        public string SignReason { get; set; }

        /// <summary>
        /// 电子签章类型   1:仅数字证书文档签名  2:仅图章  3:数字证书文档签名，加盖图章
        /// </summary>
        [JsonProperty("signature_type")]
        [XmlElement("signature_type")]
        public long SignatureType { get; set; }
    }
}
