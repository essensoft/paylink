using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniReleaststBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniReleaststBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 20
        /// </summary>
        [JsonProperty("canshu")]
        public string Canshu { get; set; }

        /// <summary>
        /// 测试数据
        /// </summary>
        [JsonProperty("fuza")]
        public GavintestNewLeveaOne Fuza { get; set; }
    }
}
