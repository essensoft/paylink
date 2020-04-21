using System.Text.Json.Serialization;

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
        [JsonPropertyName("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [JsonPropertyName("return_code")]
        public string ReturnCode { get; set; }
    }
}
