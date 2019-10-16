using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandBenefitVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBenefitVerifyModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonProperty("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 外部业务时间
        /// </summary>
        [JsonProperty("out_biz_time")]
        public string OutBizTime { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [JsonProperty("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 权益发放记录ID
        /// </summary>
        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
