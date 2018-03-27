using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OuterMemberInfo Data Structure.
    /// </summary>
    public class OuterMemberInfo : AlipayObject
    {
        /// <summary>
        /// 商户记录的用户信息
        /// </summary>
        [JsonProperty("user_info")]
        public string UserInfo { get; set; }
    }
}
