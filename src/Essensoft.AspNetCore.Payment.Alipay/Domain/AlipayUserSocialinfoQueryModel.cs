using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserSocialinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSocialinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，不可为空，最大一次传递10个
        /// </summary>
        [JsonProperty("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
