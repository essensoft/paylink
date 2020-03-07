using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAccountQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 登录ID，需要跟登录类别（logon_type，EMAIL:邮箱登陆 MOBILE:手机登录）结合
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }
    }
}
