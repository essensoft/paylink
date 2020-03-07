using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationOutsideApplyModel Data Structure.
    /// </summary>
    public class AlipayInsSceneApplicationOutsideApplyModel : AlipayObject
    {
        /// <summary>
        /// 保险干系人
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 业务因子信息
        /// </summary>
        [JsonPropertyName("biz_factor")]
        public string BizFactor { get; set; }

        /// <summary>
        /// 保险止期
        /// </summary>
        [JsonPropertyName("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [JsonPropertyName("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [JsonPropertyName("insureds")]
        public List<InsPerson> Insureds { get; set; }

        /// <summary>
        /// 外部业务号(幂等字段)
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 险种保障期限,数字+"Y/M/D"结尾,非固定期限险种或多固定期限险种必填
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 保费信息，一口价场景可以为空，定价规则较为复杂场景需外部传入用于业务核价，单位(分)
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 产品号
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 保额(单位:分)，可选
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public long SumInsured { get; set; }
    }
}
