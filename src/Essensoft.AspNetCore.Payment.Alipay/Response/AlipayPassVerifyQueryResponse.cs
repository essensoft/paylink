using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassVerifyQueryResponse.
    /// </summary>
    public class AlipayPassVerifyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询成功时返回的结果信息
        /// </summary>
        [JsonProperty("biz_result")]
        [XmlElement("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 返回码。
        /// </summary>
        [JsonProperty("error_code")]
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 查询是否成功的标识
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
