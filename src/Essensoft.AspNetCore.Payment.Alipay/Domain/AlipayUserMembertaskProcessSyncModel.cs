using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserMembertaskProcessSyncModel Data Structure.
    /// </summary>
    public class AlipayUserMembertaskProcessSyncModel : AlipayObject
    {
        /// <summary>
        /// 标识目标业务的业务大类
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 计数型任务涉及外围业务计数的金额，格式为以元为单位带角分数值的小数
        /// </summary>
        [JsonPropertyName("money")]
        public string Money { get; set; }

        /// <summary>
        /// 幂等ID，对于交易类业务可为交易流水号，一次性业务可为userId，外围业务控制。在系统异常重试时需要确保传入同样的流水号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 标识目标业务的业务小类
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
