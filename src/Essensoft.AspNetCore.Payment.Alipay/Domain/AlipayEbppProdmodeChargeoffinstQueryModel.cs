using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeChargeoffinstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeChargeoffinstQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }
    }
}
