using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserApplepayMerchantauthtokenGetModel Data Structure.
    /// </summary>
    public class AlipayUserApplepayMerchantauthtokenGetModel : AlipayObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 支付宝合作伙伴id
        /// </summary>
        [JsonPropertyName("partner_owned_merchant_identifier")]
        public string PartnerOwnedMerchantIdentifier { get; set; }

        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [JsonPropertyName("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// applePay通用请求头
        /// </summary>
        [JsonPropertyName("request_header")]
        public OpenApiAppleRequestHeader RequestHeader { get; set; }

        /// <summary>
        /// wagu公交交易完成后通知标识，由wagu指定，并在交易完成后通知wagu时携带此参数
        /// </summary>
        [JsonPropertyName("transaction_notification_identifier")]
        public string TransactionNotificationIdentifier { get; set; }
    }
}
