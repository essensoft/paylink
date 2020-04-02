using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetRegisterApplyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetRegisterApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 资产登记申请结果，不同资产类型不同，比如可能包含代签名原始数据等。
        /// </summary>
        [JsonPropertyName("apply_result")]
        public string ApplyResult { get; set; }

        /// <summary>
        /// 登记成功后，返回资产登记中心内部资产编号
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 申请时提交的外部资产编号
        /// </summary>
        [JsonPropertyName("out_asset_id")]
        public string OutAssetId { get; set; }
    }
}
