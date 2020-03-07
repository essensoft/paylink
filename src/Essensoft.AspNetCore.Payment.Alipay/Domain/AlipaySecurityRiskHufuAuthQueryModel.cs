using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskHufuAuthQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskHufuAuthQueryModel : AlipayObject
    {
        /// <summary>
        /// 获取虎符结果需要的code
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 获取虎符结果的额外策略信息
        /// </summary>
        [JsonPropertyName("policy")]
        public string Policy { get; set; }

        /// <summary>
        /// 业务系统创建虎符时传入的序列号
        /// </summary>
        [JsonPropertyName("serial")]
        public string Serial { get; set; }
    }
}
