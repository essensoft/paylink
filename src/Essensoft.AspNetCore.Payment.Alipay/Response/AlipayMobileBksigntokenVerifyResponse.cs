using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileBksigntokenVerifyResponse.
    /// </summary>
    public class AlipayMobileBksigntokenVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值创建时间
        /// </summary>
        [JsonProperty("createtimestamp")]
        [XmlElement("createtimestamp")]
        public string Createtimestamp { get; set; }

        /// <summary>
        /// 返回值logonId
        /// </summary>
        [JsonProperty("loginid")]
        [XmlElement("loginid")]
        public string Loginid { get; set; }

        /// <summary>
        /// 结果说明
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 结果状态码
        /// </summary>
        [JsonProperty("resultcode")]
        [XmlElement("resultcode")]
        public long Resultcode { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 返回值userId
        /// </summary>
        [JsonProperty("userid")]
        [XmlElement("userid")]
        public string Userid { get; set; }
    }
}
