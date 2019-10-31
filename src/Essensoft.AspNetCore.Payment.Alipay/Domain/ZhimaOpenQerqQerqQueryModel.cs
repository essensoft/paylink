using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaOpenQerqQerqQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenQerqQerqQueryModel : AlipayObject
    {
        /// <summary>
        /// 123
        /// </summary>
        [JsonProperty("address")]
        public AgreementParams Address { get; set; }
    }
}
