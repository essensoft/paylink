using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogVoiceMediaaudioUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogVoiceMediaaudioUploadModel : AlipayObject
    {
        /// <summary>
        /// base64编码的声音数据
        /// </summary>
        [JsonProperty("data")]
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("extinfo_a")]
        [XmlElement("extinfo_a")]
        public string ExtinfoA { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("extinfo_b")]
        [XmlElement("extinfo_b")]
        public string ExtinfoB { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("extinfo_c")]
        [XmlElement("extinfo_c")]
        public string ExtinfoC { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("extinfo_d")]
        [XmlElement("extinfo_d")]
        public string ExtinfoD { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("labeltime")]
        [XmlElement("labeltime")]
        public string Labeltime { get; set; }

        /// <summary>
        /// 媒体名称
        /// </summary>
        [JsonProperty("vname")]
        [XmlElement("vname")]
        public string Vname { get; set; }

        /// <summary>
        /// 媒体类型
        /// </summary>
        [JsonProperty("vtype")]
        [XmlElement("vtype")]
        public string Vtype { get; set; }
    }
}
