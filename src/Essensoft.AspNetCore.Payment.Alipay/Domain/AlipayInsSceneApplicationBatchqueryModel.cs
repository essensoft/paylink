using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneApplicationBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
