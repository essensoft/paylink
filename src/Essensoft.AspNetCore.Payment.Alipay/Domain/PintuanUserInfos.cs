using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PintuanUserInfos Data Structure.
    /// </summary>
    [Serializable]
    public class PintuanUserInfos : AlipayObject
    {
        /// <summary>
        /// 拼团用户信息列表
        /// </summary>
        [JsonProperty("pintuan_user_info_list")]
        public PintuanUserInfo PintuanUserInfoList { get; set; }
    }
}
