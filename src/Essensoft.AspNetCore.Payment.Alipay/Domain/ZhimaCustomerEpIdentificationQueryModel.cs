using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerEpIdentificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerEpIdentificationQueryModel : AlipayObject
    {
        /// <summary>
        /// 一次认证的唯一标识,在商户调用认证初始化接口的时候获取。
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }
    }
}
