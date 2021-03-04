using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeDepositVerifyQueryModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeDepositVerifyQueryModel : AlipayObject
    {
        /// <summary>
        /// 打款验证ID 打款验证受理后生成的一个唯一标识
        /// </summary>
        [JsonPropertyName("verify_id")]
        public string VerifyId { get; set; }
    }
}
