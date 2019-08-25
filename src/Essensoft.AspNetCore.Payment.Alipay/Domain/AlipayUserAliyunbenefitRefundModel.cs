using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAliyunbenefitRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAliyunbenefitRefundModel : AlipayObject
    {
        /// <summary>
        /// 业务流水号，用来映射需要回退积分的订单号，与权益兑换时传入的值一致。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单所属支付宝用户的uid，与兑换接口中传入的值保持一致
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
