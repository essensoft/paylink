using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerContractDetailQueryModel Data Structure.
    /// </summary>
    public class ZhimaCustomerContractDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 发约单号
        /// </summary>
        [JsonPropertyName("offer_no")]
        public string OfferNo { get; set; }

        /// <summary>
        /// 主体id，一般是user_id
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }
    }
}
