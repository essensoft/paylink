using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AttachmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AttachmentInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝返回的图片在文件存储平台的标识
        /// </summary>
        [JsonProperty("atta_url")]
        [XmlElement("atta_url")]
        public string AttaUrl { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 附件类型,PROMO_PIC:营销物料照
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
