using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerCertificationQueryModel Data Structure.
    /// </summary>
    public class ZhimaCustomerCertificationQueryModel : AlipayObject
    {
        /// <summary>
        /// 一次认证的唯一标识，在商户调用认证初始化接口的时候获取
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }
    }
}
