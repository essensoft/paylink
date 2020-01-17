using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InterTradeContractPartner Data Structure.
    /// </summary>
    public class InterTradeContractPartner : AlipayObject
    {
        /// <summary>
        /// 参与方类型（包括：OU、NAME、PID、CID、UID、 MID）
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 根据参与类型来设置具体的值（如：type=NAME, value=网商银行；type=PID, value=2088xxxxxxxx）
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
