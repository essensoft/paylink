using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantContractOfferModifyModel Data Structure.
    /// </summary>
    public class ZhimaMerchantContractOfferModifyModel : AlipayObject
    {
        /// <summary>
        /// 约定内容描述
        /// </summary>
        [JsonPropertyName("contract_content")]
        public string ContractContent { get; set; }

        /// <summary>
        /// 合约主体描述，用于呈现支付端内约定详情中的主体描述
        /// </summary>
        [JsonPropertyName("contract_principal_desc")]
        public string ContractPrincipalDesc { get; set; }

        /// <summary>
        /// 合约主体图片链接
        /// </summary>
        [JsonPropertyName("contract_principal_logo")]
        public string ContractPrincipalLogo { get; set; }

        /// <summary>
        /// 去履约完成时点击的链接地址
        /// </summary>
        [JsonPropertyName("fufilment_callback_url")]
        public string FufilmentCallbackUrl { get; set; }

        /// <summary>
        /// 履约需要完成的事项描述
        /// </summary>
        [JsonPropertyName("fufilment_desc")]
        public string FufilmentDesc { get; set; }

        /// <summary>
        /// 发约创建者主体id(商户pid/用户芝麻id/支付宝用户id/淘宝用户id)
        /// </summary>
        [JsonPropertyName("offer_creater_id")]
        public string OfferCreaterId { get; set; }

        /// <summary>
        /// 发约创建者类型： MERCHANT:商户 ZHIMA_ROLE:芝麻用户 ALIPAY_ROLE:支付宝用户 TAOBAO_ROLE:淘宝用户
        /// </summary>
        [JsonPropertyName("offer_creater_type")]
        public string OfferCreaterType { get; set; }

        /// <summary>
        /// 发约单号
        /// </summary>
        [JsonPropertyName("offer_no")]
        public string OfferNo { get; set; }

        /// <summary>
        /// 信用服务id，需要与芝麻技术确定此值
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }
    }
}
