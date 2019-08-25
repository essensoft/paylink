using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppDetectReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppDetectReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部业务标识
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
