using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderPayCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderPayCancelModel : AlipayObject
    {
        /// <summary>
        /// 外部支付订单号,唯一标识本次支付的requestID
        /// </summary>
        [JsonProperty("out_pay_no")]
        public string OutPayNo { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [JsonProperty("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }
    }
}
