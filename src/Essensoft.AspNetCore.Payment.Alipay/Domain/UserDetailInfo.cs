using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserDetailInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用户其他详细信息列表，比如商户或者其他平台的信息。
        /// </summary>
        [JsonProperty("ext_profile_list")]
        public List<UserProfileDetail> ExtProfileList { get; set; }
    }
}
