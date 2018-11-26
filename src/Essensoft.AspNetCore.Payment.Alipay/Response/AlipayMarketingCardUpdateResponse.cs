using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardUpdateResponse.
    /// </summary>
    public class AlipayMarketingCardUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 二级错误处理结果（如果公用返回结果为false，则可以看这个接口判断明细原因）  如果公用返回为true，则该字段为空
        /// </summary>
        [JsonProperty("result_code")]
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
