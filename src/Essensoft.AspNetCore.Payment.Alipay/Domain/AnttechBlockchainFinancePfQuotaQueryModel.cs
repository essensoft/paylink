using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinancePfQuotaQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinancePfQuotaQueryModel : AlipayObject
    {
        /// <summary>
        /// 客户号
        /// </summary>
        [JsonPropertyName("client_no")]
        public string ClientNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("crf_type")]
        public string CrfType { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("id_num")]
        public string IdNum { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [JsonPropertyName("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 平台号
        /// </summary>
        [JsonPropertyName("platform_id")]
        public string PlatformId { get; set; }
    }
}
