using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayGuaranteeAssetVO Data Structure.
    /// </summary>
    public class CreditPayGuaranteeAssetVO : AlipayObject
    {
        /// <summary>
        /// 信用支付基础视图
        /// </summary>
        [JsonPropertyName("base_info")]
        public CreditPayAssetBaseVO BaseInfo { get; set; }

        /// <summary>
        /// 代偿方案
        /// </summary>
        [JsonPropertyName("compensate_detail")]
        public CreditPayCompensateDetailVO CompensateDetail { get; set; }

        /// <summary>
        /// 担保期限
        /// </summary>
        [JsonPropertyName("guar_term")]
        public long GuarTerm { get; set; }

        /// <summary>
        /// 担保期限类型(D-日，M-月，Y-年)
        /// </summary>
        [JsonPropertyName("guar_term_type")]
        public string GuarTermType { get; set; }
    }
}
