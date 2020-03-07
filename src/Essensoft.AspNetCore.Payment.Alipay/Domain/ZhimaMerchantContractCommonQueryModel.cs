using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantContractCommonQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantContractCommonQueryModel : AlipayObject
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

        /// <summary>
        /// 应约者类型:ZHIMA_ROLE:芝麻用户 ALIPAY_ROLE:支付宝用户 TAOBAO_ROLE:淘宝用户
        /// </summary>
        [JsonPropertyName("sign_principal_type")]
        public string SignPrincipalType { get; set; }
    }
}
