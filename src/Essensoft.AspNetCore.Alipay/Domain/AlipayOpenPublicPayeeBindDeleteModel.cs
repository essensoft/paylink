using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPayeeBindDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPayeeBindDeleteModel : AlipayObject
    {
        /// <summary>
        /// 收款账号，需要解除绑定的收款支付宝账号
        /// </summary>
        [JsonProperty("login_id")]
        public string LoginId { get; set; }
    }
}
