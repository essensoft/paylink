using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserMpointAuthbasePayModel Data Structure.
    /// </summary>
    public class AlipayUserMpointAuthbasePayModel : AlipayObject
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
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 目标扣减积分数
        /// </summary>
        [JsonPropertyName("point")]
        public string Point { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
