using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiContentContentinfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiContentContentinfoDeleteModel : AlipayObject
    {
        /// <summary>
        /// 口碑端内容唯一id，必填
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }
    }
}
