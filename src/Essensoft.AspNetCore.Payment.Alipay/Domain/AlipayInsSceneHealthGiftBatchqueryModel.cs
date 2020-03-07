using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneHealthGiftBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneHealthGiftBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 赠险业务标志 HEALTH_BEAN_SIMPLE_UPGRADE 免费医疗金、HEALTH_GUARDIAN_GOLD 守护金、HEALTH_DSDB_NEW_OUTPATIENT 多收多宝新门诊
        /// </summary>
        [JsonPropertyName("biz_type_list")]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// 查询某渠道记录的起期，注意，只对health_send_flow_list、health_gain_flow_list字段生效
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// health_gift_batch_gain_sum_insured_list 健康险赠险待领取权益，目前包含待领取保额，准入 health_gift_batch_valid_gift_list 用户生效赠险查询结果 health_gift_batch_already_opened_list 健康险赠险险种是否已开通查询结果 health_gift_batch_my_sum_insured_list 健康险赠险用户总保额查询结果 health_send_flow_list 赠险发放流水列表 health_gain_flow_list 赠险领取流水列表 gained_sum_insured_by_source 赠险从某个source领取的保额
        /// </summary>
        [JsonPropertyName("operation_list")]
        public List<string> OperationList { get; set; }

        /// <summary>
        /// 赠险产品组类型。 赠险通用产品组 COMMON_GIFT_INSURANCE_PRODUCT_GROUP、 C端赠险产品组 CUSTOMER_GIFT_INSURANCE_PRODUCT_GROUP、 B端赠险产品组 BUSINESS_GIFT_INSURANCE_PRODUCT_GROUP、 相互保赠险产品组 XHB_GIFT_INSURANCE_PRODUCT_GROUP
        /// </summary>
        [JsonPropertyName("product_group_biz_type_list")]
        public List<string> ProductGroupBizTypeList { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 查询某渠道记录的起期，注意，只对health_send_flow_list、health_gain_flow_list字段生效
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
