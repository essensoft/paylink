using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingSendResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingSendResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝－中小学－教育缴费的账单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
