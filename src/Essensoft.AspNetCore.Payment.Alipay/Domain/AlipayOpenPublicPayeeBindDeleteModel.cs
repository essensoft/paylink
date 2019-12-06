using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPayeeBindDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPayeeBindDeleteModel : AlipayObject
    {
        /// <summary>
        /// 收款账号，需要解除绑定的收款支付宝账号，跟pid不要同时传
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头的16位长度字符串，跟login_id不要同时传
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
