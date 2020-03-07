using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantContractOnofferQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantContractOnofferQueryModel : AlipayObject
    {
        /// <summary>
        /// 发约单单号
        /// </summary>
        [JsonPropertyName("offer_no")]
        public string OfferNo { get; set; }

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
