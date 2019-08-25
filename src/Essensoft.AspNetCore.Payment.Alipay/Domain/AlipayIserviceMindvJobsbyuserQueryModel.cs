using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceMindvJobsbyuserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvJobsbyuserQueryModel : AlipayObject
    {
        /// <summary>
        /// 对应账号类型下的唯一账号主键_用以区分对应的填写用户
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 账号类型_用以区分不同账号体系的用户    ALIPAY-支付宝  HEMA-盒马  ALIBABA_INC-内部域账号
        /// </summary>
        [JsonProperty("user_type")]
        public string UserType { get; set; }
    }
}
