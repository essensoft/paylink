using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAssetIssueApplyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAssetIssueApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 申请成功后生成的内部资产id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 提交申请时传入的资产id
        /// </summary>
        [JsonPropertyName("out_asset_id")]
        public string OutAssetId { get; set; }

        /// <summary>
        /// 申请成功后返回，待签名上链的业务信息，base64解码后为utf8编码的原始签名信息，xml格式
        /// </summary>
        [JsonPropertyName("sign_data")]
        public string SignData { get; set; }
    }
}
