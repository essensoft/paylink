using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsHealthGiftBatchGainSumInsuredResult Data Structure.
    /// </summary>
    public class InsHealthGiftBatchGainSumInsuredResult : AlipayObject
    {
        /// <summary>
        /// 是否准入。true标识准入，false标识不准入
        /// </summary>
        [JsonPropertyName("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 赠险业务标志  HEALTH_BEAN_SIMPLE_UPGRADE 免费医疗金、HEALTH_GUARDIAN_GOLD 守护金、HEALTH_DSDB_NEW_OUTPATIENT 多收多宝新门诊
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 本次可领取保额
        /// </summary>
        [JsonPropertyName("delta_sum_insured")]
        public string DeltaSumInsured { get; set; }

        /// <summary>
        /// 赠险产品组类型。 赠险通用产品组 COMMON_GIFT_INSURANCE_PRODUCT_GROUP、 C端赠险产品组 CUSTOMER_GIFT_INSURANCE_PRODUCT_GROUP、 B端赠险产品组 BUSINESS_GIFT_INSURANCE_PRODUCT_GROUP、 相互保赠险产品组 XHB_GIFT_INSURANCE_PRODUCT_GROUP
        /// </summary>
        [JsonPropertyName("product_group_biz_type")]
        public string ProductGroupBizType { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
