using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceCodeRecoModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceCodeRecoModel : AlipayObject
    {
        /// <summary>
        /// 参数配置：内容包括验证码之类，长度，是否可分割等
        /// </summary>
        [JsonProperty("config")]
        [XmlElement("config")]
        public string Config { get; set; }

        /// <summary>
        /// 图片的内容(以base64位编码)，大小不超过10k
        /// </summary>
        [JsonProperty("content")]
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 策略，目前有2种，机器识别与人工打码（机器：machine；人工打码：manual）
        /// </summary>
        [JsonProperty("strategy")]
        [XmlElement("strategy")]
        public string Strategy { get; set; }
    }
}
