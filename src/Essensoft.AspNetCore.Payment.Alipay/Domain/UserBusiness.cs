using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserBusiness Data Structure.
    /// </summary>
    [Serializable]
    public class UserBusiness : AlipayObject
    {
        /// <summary>
        /// 用户权限等级
        /// </summary>
        [JsonProperty("access_level")]
        public long AccessLevel { get; set; }

        /// <summary>
        /// 业务描述
        /// </summary>
        [JsonProperty("business_desc")]
        public string BusinessDesc { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [JsonProperty("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// 业务备注信息
        /// </summary>
        [JsonProperty("business_remark")]
        public string BusinessRemark { get; set; }

        /// <summary>
        /// 业务状态
        /// </summary>
        [JsonProperty("business_status")]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// 是否是owner，是：1；否：0
        /// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 对于该业务的用户状态
        /// </summary>
        [JsonProperty("user_status")]
        public long UserStatus { get; set; }
    }
}
