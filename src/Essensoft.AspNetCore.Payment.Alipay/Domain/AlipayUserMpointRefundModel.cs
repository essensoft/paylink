using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserMpointRefundModel Data Structure.
    /// </summary>
    public class AlipayUserMpointRefundModel : AlipayObject
    {
        /// <summary>
        /// 业务子类型，由会员方面分配
        /// </summary>
        [JsonPropertyName("biz_sub_type")]
        public string BizSubType { get; set; }

        /// <summary>
        /// 业务类型，由会员方面分配
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务流水号，用来映射需要回退积分的订单号，与调用扣减积分接口时传入的值一致。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
