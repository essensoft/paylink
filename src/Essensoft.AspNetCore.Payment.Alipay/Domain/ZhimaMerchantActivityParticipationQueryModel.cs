using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantActivityParticipationQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantActivityParticipationQueryModel : AlipayObject
    {
        /// <summary>
        /// 承诺消费合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }
    }
}
