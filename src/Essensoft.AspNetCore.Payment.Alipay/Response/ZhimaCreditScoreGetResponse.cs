using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditScoreGetResponse.
    /// </summary>
    public class ZhimaCreditScoreGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户的芝麻分。分值范围[350,950]。如果用户数据不足，无法评分时，返回字符串"N/A"。
        /// </summary>
        [JsonProperty("zm_score")]
        [XmlElement("zm_score")]
        public string ZmScore { get; set; }
    }
}
