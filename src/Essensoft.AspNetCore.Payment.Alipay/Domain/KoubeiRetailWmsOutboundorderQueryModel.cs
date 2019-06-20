using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsOutboundorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsOutboundorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 是否需要通知单明细，true则返回明细
        /// </summary>
        [JsonProperty("need_detail")]
        public bool NeedDetail { get; set; }

        /// <summary>
        /// 外部业务单号（出库通知单id二选一，必填一个）
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 通知单id（与业务单号二选一，必选一个）
        /// </summary>
        [JsonProperty("outbound_order_id")]
        public string OutboundOrderId { get; set; }
    }
}
