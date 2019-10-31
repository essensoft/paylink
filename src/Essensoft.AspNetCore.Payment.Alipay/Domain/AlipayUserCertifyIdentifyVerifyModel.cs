using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyIdentifyVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyIdentifyVerifyModel : AlipayObject
    {
        /// <summary>
        /// 分配给业务的场景码
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
