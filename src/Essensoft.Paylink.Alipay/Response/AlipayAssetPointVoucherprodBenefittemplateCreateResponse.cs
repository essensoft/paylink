using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateCreateResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 资产id，即创建的权益模板的id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 权益结算平台的流水号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }
    }
}
