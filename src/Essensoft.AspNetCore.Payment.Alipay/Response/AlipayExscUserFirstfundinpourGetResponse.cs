using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayExscUserFirstfundinpourGetResponse.
    /// </summary>
    public class AlipayExscUserFirstfundinpourGetResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果的业务类型。首次资金流入业务类型 （first_fund_inpour）
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务处理结果   true 无资金流入记录，本次是首次交易   false 已有资金流入记录，本次不是首次交易
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
