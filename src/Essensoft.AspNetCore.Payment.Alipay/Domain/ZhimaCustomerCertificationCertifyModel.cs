using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerCertificationCertifyModel Data Structure.
    /// </summary>
    public class ZhimaCustomerCertificationCertifyModel : AlipayObject
    {
        /// <summary>
        /// 一次认证的唯一标识，在完成芝麻认证初始化后可以获取
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }
    }
}
