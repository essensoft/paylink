using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaOpenAppDesSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenAppDesSendModel : AlipayObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonProperty("com")]
        public GavintestNewLeveaOne Com { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("test")]
        public string Test { get; set; }
    }
}
