using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateSettleResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateSettleResponse : AlipayResponse
    {
        /// <summary>
        /// 资产id，即结算的权益模板的id
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资金单据流水id，权益结算平台的结算流水号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 实际结算的金额
        /// </summary>
        [JsonPropertyName("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 当前结算状态，I：结算已受理，尚未划拨资金；S：划拨资金完成；C： 划拨资金失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
