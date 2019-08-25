using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ChildCertInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ChildCertInfo : AlipayObject
    {
        /// <summary>
        /// 儿童业务id
        /// </summary>
        [JsonProperty("child_id")]
        public string ChildId { get; set; }

        /// <summary>
        /// 小宝账户跳转链接
        /// </summary>
        [JsonProperty("url")]
        public NextUrl Url { get; set; }
    }
}
