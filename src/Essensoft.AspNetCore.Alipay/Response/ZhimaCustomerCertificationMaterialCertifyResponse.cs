using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerCertificationMaterialCertifyResponse.
    /// </summary>
    public class ZhimaCustomerCertificationMaterialCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 本次认证的唯一标识，商户需要记录，后续的操作都需要用到
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }
    }
}
