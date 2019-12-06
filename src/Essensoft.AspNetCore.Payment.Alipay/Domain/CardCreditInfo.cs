using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardCreditInfo Data Structure.
    /// </summary>
    public class CardCreditInfo : AlipayObject
    {
        /// <summary>
        /// 是否允许超扣
        /// </summary>
        [JsonPropertyName("allowoverpay")]
        public string Allowoverpay { get; set; }

        /// <summary>
        /// 超扣额度
        /// </summary>
        [JsonPropertyName("creditquota")]
        public string Creditquota { get; set; }
    }
}
