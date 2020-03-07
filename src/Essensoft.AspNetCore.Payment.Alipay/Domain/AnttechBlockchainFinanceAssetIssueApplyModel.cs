using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetIssueApplyModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceAssetIssueApplyModel : AlipayObject
    {
        /// <summary>
        /// 资产类型，依赖业务对接时约定的枚举值
        /// </summary>
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 当asset_type为RECEIVABLE时必填，应收账款信息
        /// </summary>
        [JsonPropertyName("receivable_info")]
        public FinanceReceivableInfo ReceivableInfo { get; set; }
    }
}
