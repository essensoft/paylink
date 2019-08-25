using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceMiniappnearbyQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonProperty("service_code")]
        public string ServiceCode { get; set; }
    }
}
