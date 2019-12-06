using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryProcessSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandDeliveryProcessSyncModel : AlipayObject
    {
        /// <summary>
        /// 发货计划反馈信息
        /// </summary>
        [JsonPropertyName("asset_delivery_process_info")]
        public AssetDeliveryProcessInfo AssetDeliveryProcessInfo { get; set; }
    }
}
