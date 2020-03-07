using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMallScanpurchaseTradeConsultResponse.
    /// </summary>
    public class KoubeiMallScanpurchaseTradeConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 用户实付金额
        /// </summary>
        [JsonPropertyName("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        [JsonPropertyName("discount_detail")]
        public List<MallDiscountDetail> DiscountDetail { get; set; }

        /// <summary>
        /// 请求中的request_id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
