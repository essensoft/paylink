using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerEpCertificationCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerEpCertificationCertifyModel : AlipayObject
    {
        /// <summary>
        /// 一次认证的唯一标识，在完成芝麻认证初始化后可以获取
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }
    }
}
