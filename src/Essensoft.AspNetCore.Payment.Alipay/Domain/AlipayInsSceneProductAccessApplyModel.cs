using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneProductAccessApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneProductAccessApplyModel : AlipayObject
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [JsonProperty("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 外部业务字段，幂等字段
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保险产品码
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
