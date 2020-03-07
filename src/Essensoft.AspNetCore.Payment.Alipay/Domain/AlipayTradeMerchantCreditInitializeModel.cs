using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeMerchantCreditInitializeModel Data Structure.
    /// </summary>
    public class AlipayTradeMerchantCreditInitializeModel : AlipayObject
    {
        /// <summary>
        /// 卖家可授信分配的额度单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("credit_quota")]
        public string CreditQuota { get; set; }

        /// <summary>
        /// 标识本次授信拆分的业务场景，具体的值由支付宝定义
        /// </summary>
        [JsonPropertyName("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 标识商家授信额度的来源，具体的值由支付宝定义
        /// </summary>
        [JsonPropertyName("merchant_credit_source")]
        public string MerchantCreditSource { get; set; }

        /// <summary>
        /// 卖家用户id
        /// </summary>
        [JsonPropertyName("merchant_user_id")]
        public string MerchantUserId { get; set; }
    }
}
