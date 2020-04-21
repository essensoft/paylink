using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsHealthGiftBatchValidGiftResult Data Structure.
    /// </summary>
    public class InsHealthGiftBatchValidGiftResult : AlipayObject
    {
        /// <summary>
        /// 赠险业务标志  HEALTH_BEAN_SIMPLE_UPGRADE 免费医疗金、HEALTH_GUARDIAN_GOLD 守护金、HEALTH_DSDB_NEW_OUTPATIENT 多收多宝新门诊
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 最新保单号码
        /// </summary>
        [JsonPropertyName("latest_policy_no")]
        public string LatestPolicyNo { get; set; }

        /// <summary>
        /// 赠险产品组类型。 赠险通用产品组 COMMON_GIFT_INSURANCE_PRODUCT_GROUP、 C端赠险产品组 CUSTOMER_GIFT_INSURANCE_PRODUCT_GROUP、 B端赠险产品组 BUSINESS_GIFT_INSURANCE_PRODUCT_GROUP、 相互保赠险产品组 XHB_GIFT_INSURANCE_PRODUCT_GROUP
        /// </summary>
        [JsonPropertyName("product_group_biz_type")]
        public string ProductGroupBizType { get; set; }

        /// <summary>
        /// 赠险标准产品编号。6349免费医疗金、6325多收多宝门诊、7169守护金
        /// </summary>
        [JsonPropertyName("sp_no")]
        public string SpNo { get; set; }
    }
}
