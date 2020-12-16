using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinancePfIouQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinancePfIouQueryModel : AlipayObject
    {
        /// <summary>
        /// 客户号
        /// </summary>
        [JsonPropertyName("client_no")]
        public string ClientNo { get; set; }

        /// <summary>
        /// 借据号
        /// </summary>
        [JsonPropertyName("debit_id")]
        public string DebitId { get; set; }

        /// <summary>
        /// 支用Id
        /// </summary>
        [JsonPropertyName("financing_id")]
        public string FinancingId { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [JsonPropertyName("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 平台Id
        /// </summary>
        [JsonPropertyName("platform_id")]
        public string PlatformId { get; set; }
    }
}
