using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAssetVoucherprodChargeSendResponse.
    /// </summary>
    public class AlipayAssetVoucherprodChargeSendResponse : AlipayResponse
    {
        /// <summary>
        /// 资产id编号
        /// </summary>
        [JsonPropertyName("asset_instance_id")]
        public string AssetInstanceId { get; set; }

        /// <summary>
        /// 支付宝充值订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
