using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerCertificationQueryModel Data Structure.
    /// </summary>
    public class ZhimaCustomerCertificationQueryModel : AlipayObject
    {
        /// <summary>
        /// 一次认证的唯一标识，在商户调用认证初始化接口的时候获取
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }
    }
}
