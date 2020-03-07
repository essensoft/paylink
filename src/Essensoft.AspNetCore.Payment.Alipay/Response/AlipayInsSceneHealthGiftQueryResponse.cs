using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneHealthGiftQueryResponse.
    /// </summary>
    public class AlipayInsSceneHealthGiftQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 赠险是否已开通，true标识已开通，false标识未开通
        /// </summary>
        [JsonPropertyName("already_open")]
        public bool AlreadyOpen { get; set; }

        /// <summary>
        /// 返回当前可领取保额的赠险类型。HEALTH_BEAN_SIMPLE_UPGRADE表示免费医疗金
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 可领取的保额
        /// </summary>
        [JsonPropertyName("delta_sum_insured")]
        public string DeltaSumInsured { get; set; }

        /// <summary>
        /// 某渠道已领取保额
        /// </summary>
        [JsonPropertyName("source_gained_sum_insured")]
        public string SourceGainedSumInsured { get; set; }

        /// <summary>
        /// 当前在保保额
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public string SumInsured { get; set; }
    }
}
