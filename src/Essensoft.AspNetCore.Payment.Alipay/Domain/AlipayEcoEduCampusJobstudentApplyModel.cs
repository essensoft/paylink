using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduCampusJobstudentApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduCampusJobstudentApplyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝客户端用户Id
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 备用字段，JSON格式.（可使用单引号或者双引号）
        /// </summary>
        [JsonProperty("content_var")]
        public string ContentVar { get; set; }
    }
}
