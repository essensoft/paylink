using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPointRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPointRefundModel : AlipayObject
    {
        /// <summary>
        /// 业务大类，与调用扣减积分接口时传入的值一致。
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务流水号，用来映射需要回退积分的订单号，与调用扣减积分接口时传入的值一致。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务子类型，与调用扣减积分接口时传入的值一致。
        /// </summary>
        [JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 订单所属支付宝用户的uid，与调用扣减积分接口时传入的值一致。
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
