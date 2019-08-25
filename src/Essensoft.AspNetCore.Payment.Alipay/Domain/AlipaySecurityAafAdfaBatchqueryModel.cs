using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityAafAdfaBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityAafAdfaBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
