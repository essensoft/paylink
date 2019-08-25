using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAppPageUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAppPageUploadModel : AlipayObject
    {
        /// <summary>
        /// 租户应用服务数据
        /// </summary>
        [JsonProperty("content")]
        public CommerceAppUploadRequestContent Content { get; set; }

        /// <summary>
        /// 租户应用服务名称
        /// </summary>
        [JsonProperty("service_name")]
        public string ServiceName { get; set; }
    }
}
