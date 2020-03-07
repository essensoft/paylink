using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetIssueQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceAssetIssueQueryModel : AlipayObject
    {
        /// <summary>
        /// 资产发行提交时传入的内部资产id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产对应的核心企业信息
        /// </summary>
        [JsonPropertyName("core_business_info")]
        public FinanceMemberInfo CoreBusinessInfo { get; set; }
    }
}
