using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandShopConsultResponse.
    /// </summary>
    public class AntMerchantExpandShopConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 资金账户是否审核。当调用没有报错时，本值才有参考意义
        /// </summary>
        [JsonPropertyName("account_audit")]
        public bool AccountAudit { get; set; }

        /// <summary>
        /// 咨询申请单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否风控审核。当调用没有报错时，本值才有参考意义
        /// </summary>
        [JsonPropertyName("risk_audit")]
        public bool RiskAudit { get; set; }
    }
}
