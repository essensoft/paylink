using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRegisterSubmitModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceAssetRegisterSubmitModel : AlipayObject
    {
        /// <summary>
        /// 资产发现中心内部资产编号，通过apply返回
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型，同apply，为直观，submit也必传。
        /// </summary>
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 资产发行申请后，后续操作提交。
        /// </summary>
        [JsonPropertyName("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 提交的数据，根据operate不同而不同
        /// </summary>
        [JsonPropertyName("submit_data")]
        public string SubmitData { get; set; }
    }
}
