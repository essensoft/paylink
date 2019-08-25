using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArchiveFaceExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ArchiveFaceExtInfo : AlipayObject
    {
        /// <summary>
        /// 证件提供者的支付宝uid
        /// </summary>
        [JsonProperty("provider_uid")]
        public string ProviderUid { get; set; }
    }
}
