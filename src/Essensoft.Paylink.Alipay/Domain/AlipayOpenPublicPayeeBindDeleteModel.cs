using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPayeeBindDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPayeeBindDeleteModel : AlipayObject
    {
        /// <summary>
        /// 收款账号，需要绑定的收款支付宝账号，请勿与 pid 同时传入。
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头的16位长度字符串，请勿与 login_id 同时传入。
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
