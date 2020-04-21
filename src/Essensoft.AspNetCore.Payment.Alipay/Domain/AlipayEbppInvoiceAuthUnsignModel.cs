using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceAuthUnsignModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceAuthUnsignModel : AlipayObject
    {
        /// <summary>
        /// 发票授权类型，可选值：INVOICE_AUTO_SYNC（发票自动回传） INVOICE_TWOWAY_AUTO_SYNC（发票双向自动回传）
        /// </summary>
        [JsonPropertyName("authorization_type")]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// 扩展字段，格式为：KEY1=VALUE1,KEY2=VALUE2,KEY3=VALUE3 邮箱地址KEY为EMAIL_ADDRESS
        /// </summary>
        [JsonPropertyName("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 开票商户品牌简称，与商户入驻时的品牌简称保持一致。
        /// </summary>
        [JsonPropertyName("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
