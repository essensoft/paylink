using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMerchantActivityModifyModel : AlipayObject
    {
        /// <summary>
        /// 活动ActivityId
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动是否需要自动续期
        /// </summary>
        [JsonProperty("auto_delay_flag")]
        public bool AutoDelayFlag { get; set; }

        /// <summary>
        /// 活动所属场景，只支持单个场景，目前支持枚举类型：点餐场景：DISH、预点餐场景：PRE_DISH、菜单场景：MENU
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 营销活动描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 活动结束时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息数据，如需要透传信息到口碑，需要结果带回，则传递该值
        /// </summary>
        [JsonProperty("ext_info")]
        public List<MExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 营销活动名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 指定operator字段操作人类型，目前支持枚举：外部商户：MER、商户操作员：MER_OPERATOR、外部服务商：PROVIDER、外部服务商员工：PROVIDER_STAFF
        /// </summary>
        [JsonProperty("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 活动外部业务类型，通过改类型指定营销活动是什么类型的活动，目前支持类型枚举值：会员券：MEMBER_CASH、会员折扣：MEMBER_RATE_DISCOUNT、会员价：MEMBER_DISH_ITEM
        /// </summary>
        [JsonProperty("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 营销活动玩法详细信息设置
        /// </summary>
        [JsonProperty("promo_info_list")]
        public List<MPromoInfo> PromoInfoList { get; set; }

        /// <summary>
        /// 活动开始时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
