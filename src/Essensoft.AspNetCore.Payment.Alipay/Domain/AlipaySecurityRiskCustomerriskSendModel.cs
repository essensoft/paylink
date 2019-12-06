using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskCustomerriskSendModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskCustomerriskSendModel : AlipayObject
    {
        /// <summary>
        /// 交易对应的银行卡的卡号（支付宝直连和间连合作伙伴均可回传此参数）
        /// </summary>
        [JsonPropertyName("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 该账号对应的营业执照号码（支付宝直连和间连合作伙伴均可回传此参数）
        /// </summary>
        [JsonPropertyName("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 该用户对应的身份证号码（支付宝直连和间连合作伙伴均可回传此参数）
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 账户注册时填写的邮箱地址(适用于支付宝直连商户回传此信息)
        /// </summary>
        [JsonPropertyName("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 适用于间连业务场景下，商户在银行被分配的ID（适用于支付宝间连合作伙伴回传此信息）
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 该笔风险交易购买的具体商品名称（适用于支付宝直连商户回传此信息）
        /// </summary>
        [JsonPropertyName("merch_name")]
        public string MerchName { get; set; }

        /// <summary>
        /// 手机（支付宝直连和间连合作伙伴均可回传此参数）
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 该账号登录合作伙伴平台时的IP地址（适用于支付宝直连商户回传此信息）
        /// </summary>
        [JsonPropertyName("mobile_ip")]
        public string MobileIp { get; set; }

        /// <summary>
        /// 该账户在商户平台下单时的MAC地址或IP地址（适用于支付宝直连商户回传此信息）
        /// </summary>
        [JsonPropertyName("order_ip")]
        public string OrderIp { get; set; }

        /// <summary>
        /// 适用于直连商户场景下的支付宝合作伙伴ID（适用于支付宝直连合作伙伴回传此信息）
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 指第三方在商户平台注册成功后，平台给予的账户号（适用于支付宝直连商户回传此信息）
        /// </summary>
        [JsonPropertyName("plat_account")]
        public string PlatAccount { get; set; }

        /// <summary>
        /// 直连场景下，商户对该账户采取的措施：  多种处理结果可调用多次，每次回传一种处理结果。  （01：暂停发货；  02：延迟结算；  03：关停账户；  04：暂停发货+关停账户；  05：延迟结算+关停账户；  06：其他；  07：平台进行退款退订；  08：平台跟用户沟通后，用户撤诉。  间连场景下，商户回传处理结果：  对商户的处理情况：  01：已延迟结算，02：关停商户，99：其他  多重处理结果可调用多次，每次回传一种处理结果
        /// </summary>
        [JsonPropertyName("process_code")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 指间连交易场景下商家被支付宝分配的ID（适用于支付宝间连合作伙伴回传此信息）
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 支付宝推送的风险消息中的交易号（支付宝直连和间连合作伙伴均需回传此参数）
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
