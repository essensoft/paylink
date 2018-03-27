using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPayeeBindCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPayeeBindCreateModel : AlipayObject
    {
        /// <summary>
        /// 收款账号，需要绑定的收款支付宝账号
        /// </summary>
        [JsonProperty("login_id")]
        public string LoginId { get; set; }
    }
}
