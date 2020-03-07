using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringOrderInfoSyncResponse.
    /// </summary>
    public class KoubeiCateringOrderInfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// json结构化对象，部分退款场景：refund_amount=入参请求的退款金额，out_refund_no=入参请求的外部退款单号，buyer_real_amount=买家实际退金额，refund_real_amount=商家实际退款金额。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否需要重试，true-需要，false-不需要
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
