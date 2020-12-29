using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayAmountQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayAmountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 准入标志
        /// </summary>
        [JsonPropertyName("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 可用额度
        /// </summary>
        [JsonPropertyName("available_amt")]
        public string AvailableAmt { get; set; }

        /// <summary>
        /// 1688买家ID
        /// </summary>
        [JsonPropertyName("buyer_scene_id")]
        public string BuyerSceneId { get; set; }

        /// <summary>
        /// 是否签约
        /// </summary>
        [JsonPropertyName("signed")]
        public bool Signed { get; set; }

        /// <summary>
        /// 授信额度
        /// </summary>
        [JsonPropertyName("total_amt")]
        public string TotalAmt { get; set; }

        /// <summary>
        /// Trace信息
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
