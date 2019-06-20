using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdUserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdUserCreateModel : AlipayObject
    {
        /// <summary>
        /// 广告主用户信息，参见文档
        /// </summary>
        [JsonProperty("ad_user")]
        public AdUser AdUser { get; set; }
    }
}
