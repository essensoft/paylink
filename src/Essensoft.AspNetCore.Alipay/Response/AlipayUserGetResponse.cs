using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayUserGetResponse.
    /// </summary>
    public class AlipayUserGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户信息
        /// </summary>
        [JsonProperty("alipay_user_detail")]
        public AlipayUserDetail AlipayUserDetail { get; set; }
    }
}
