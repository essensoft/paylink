using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataAutodamageEstimateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataAutodamageEstimateQueryModel : AlipayObject
    {
        /// <summary>
        /// 保险公司定损单号，同之前调用的“提交车险图像定损请求”接口中的定损单号。
        /// </summary>
        [JsonProperty("estimate_no")]
        public string EstimateNo { get; set; }
    }
}
