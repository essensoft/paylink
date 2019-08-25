using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditContractPrincipalQueryResponse.
    /// </summary>
    public class ZhimaCreditContractPrincipalQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否需要授权。仅当mode=1时需要进行处理，此时用户需要手动在手机上完成授权操作，商户可在机具上给出相关提示，如：请在手机上确认。
        /// </summary>
        [JsonProperty("need_auth")]
        public string NeedAuth { get; set; }

        /// <summary>
        /// 扫码模式下返回的url。此时需要商户将该url转换为二维码，用户用支付宝扫码即可进行接下来的业务流程。
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
