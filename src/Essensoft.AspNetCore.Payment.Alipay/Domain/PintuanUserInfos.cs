using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PintuanUserInfos Data Structure.
    /// </summary>
    public class PintuanUserInfos : AlipayObject
    {
        /// <summary>
        /// 拼团用户信息列表
        /// </summary>
        [JsonPropertyName("pintuan_user_info_list")]
        public PintuanUserInfo PintuanUserInfoList { get; set; }
    }
}
