using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceApplyUploadResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceApplyUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁订单号
        /// </summary>
        [JsonPropertyName("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
