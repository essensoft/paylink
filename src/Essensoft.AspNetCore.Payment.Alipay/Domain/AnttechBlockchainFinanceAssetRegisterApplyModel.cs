using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRegisterApplyModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceAssetRegisterApplyModel : AlipayObject
    {
        /// <summary>
        /// 资产详情，不同资产类型格式不同。
        /// </summary>
        [JsonPropertyName("asset_info")]
        public string AssetInfo { get; set; }

        /// <summary>
        /// 资产类型，依赖业务对接时约定的枚举值
        /// </summary>
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 外部资产编号
        /// </summary>
        [JsonPropertyName("out_asset_id")]
        public string OutAssetId { get; set; }
    }
}
