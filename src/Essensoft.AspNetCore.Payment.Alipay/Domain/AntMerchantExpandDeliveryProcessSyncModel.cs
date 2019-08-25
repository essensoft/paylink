using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryProcessSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDeliveryProcessSyncModel : AlipayObject
    {
        /// <summary>
        /// 发货计划反馈信息
        /// </summary>
        [JsonProperty("asset_delivery_process_info")]
        public AssetDeliveryProcessInfo AssetDeliveryProcessInfo { get; set; }
    }
}
