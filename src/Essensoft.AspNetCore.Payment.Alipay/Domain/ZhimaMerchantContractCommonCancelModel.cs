using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantContractCommonCancelModel Data Structure.
    /// </summary>
    public class ZhimaMerchantContractCommonCancelModel : AlipayObject
    {
        /// <summary>
        /// 合约单号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 应约者id(淘宝id/支付宝user_id)
        /// </summary>
        [JsonPropertyName("sign_principal_id")]
        public string SignPrincipalId { get; set; }
    }
}
