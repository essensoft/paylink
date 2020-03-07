using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransMergePrecreateResponse.
    /// </summary>
    public class AlipayFundTransMergePrecreateResponse : AlipayResponse
    {
        /// <summary>
        /// 合并转账单据号
        /// </summary>
        [JsonPropertyName("merge_order_id")]
        public string MergeOrderId { get; set; }
    }
}
