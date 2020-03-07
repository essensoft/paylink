using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserMpointPayModel Data Structure.
    /// </summary>
    public class AlipayUserMpointPayModel : AlipayObject
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
        /// 业务流水号，会用于幂等性校验，所以请保证每次请求的业务流水号的唯一性
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 需要扣减的积分数
        /// </summary>
        [JsonPropertyName("point")]
        public string Point { get; set; }
    }
}
