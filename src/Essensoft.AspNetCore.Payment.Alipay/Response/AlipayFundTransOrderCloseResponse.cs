using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransOrderCloseResponse.
    /// </summary>
    public class AlipayFundTransOrderCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝转账单据号，查询失败不返回。
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 关单了
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
