using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneProductAccessApplyModel Data Structure.
    /// </summary>
    public class AlipayInsSceneProductAccessApplyModel : AlipayObject
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 外部业务字段，幂等字段
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保险产品码
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
