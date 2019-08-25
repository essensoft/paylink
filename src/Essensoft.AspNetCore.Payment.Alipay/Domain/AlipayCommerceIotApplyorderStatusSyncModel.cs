using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotApplyorderStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotApplyorderStatusSyncModel : AlipayObject
    {
        /// <summary>
        /// 申请单状态
        /// </summary>
        [JsonProperty("apply_order_status")]
        public string ApplyOrderStatus { get; set; }

        /// <summary>
        /// 物料申请单号
        /// </summary>
        [JsonProperty("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
