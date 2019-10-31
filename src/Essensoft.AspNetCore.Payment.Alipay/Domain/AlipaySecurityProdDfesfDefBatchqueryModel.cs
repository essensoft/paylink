using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdDfesfDefBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDfesfDefBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }
}
