using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmilepayInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerSmilepayInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
