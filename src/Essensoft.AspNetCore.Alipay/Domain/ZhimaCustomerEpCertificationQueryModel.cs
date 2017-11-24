using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerEpCertificationQueryModel Data Structure.
    /// </summary>
    public class ZhimaCustomerEpCertificationQueryModel : AlipayObject
    {
        /// <summary>
        /// 一次认证的唯一标识,在商户调用认证初始化接口的时候获取
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }
    }
}
