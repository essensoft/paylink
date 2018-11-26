using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcardEduPublicBindResponse.
    /// </summary>
    public class AlipayEcardEduPublicBindResponse : AlipayResponse
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [JsonProperty("agent_code")]
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [JsonProperty("card_no")]
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [JsonProperty("return_code")]
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }
    }
}
