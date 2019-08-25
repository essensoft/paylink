using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderInfoCancelModel : AlipayObject
    {
        /// <summary>
        /// 关单时间,格式yyyy-mm-dd
        /// </summary>
        [JsonProperty("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [JsonProperty("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }
    }
}
