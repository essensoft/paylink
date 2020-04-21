using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeMerchantCreditInitializeResponse.
    /// </summary>
    public class AlipayTradeMerchantCreditInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 卖家可授信分配的额度单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("credit_quota")]
        public string CreditQuota { get; set; }
    }
}
