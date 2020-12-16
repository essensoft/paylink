using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceDataCampaignCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceDataCampaignCreateModel : AlipayObject
    {
        /// <summary>
        /// 集点活动任务完成时用户得到的集点奖品名称，用于在服务提醒消息中进行展示
        /// </summary>
        [JsonPropertyName("award_name")]
        public string AwardName { get; set; }

        /// <summary>
        /// 集点活动结束时间。取值精确至秒，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 集点活动配置业务扩展字段，json数组格式。具体值需要和支付宝约定
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 集点活动限制菜品名称，针对部分集点活动与具体菜品有关，用于在服务提醒中进行展示
        /// </summary>
        [JsonPropertyName("limit_product")]
        public string LimitProduct { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 合作者身份ID（PID）是商户与支付宝签约后，商户获得的支付宝商户唯一识别码。当商户把支付宝功能接入商户网站时会用到PID，以便让支付宝认证商户
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 集点活动中里程碑信息，json数组格式，其中：milestone_total_num:小里程碑目标次数 milestone_award:小里程碑奖品名称 小里程碑目标次数需要小于集点任务目标次数； 如果传入小里程碑奖品名称时，小里程碑目标次数必传。
        /// </summary>
        [JsonPropertyName("milestone_list")]
        public string MilestoneList { get; set; }

        /// <summary>
        /// 集点任务目标次数，即当前商户集点活动的任务目标次数
        /// </summary>
        [JsonPropertyName("periodic_total_num")]
        public string PeriodicTotalNum { get; set; }

        /// <summary>
        /// 商家集点活动的集点单位，长度固定1
        /// </summary>
        [JsonPropertyName("push_unit")]
        public string PushUnit { get; set; }

        /// <summary>
        /// 集点活动展示变量，用于在集点通知服务提醒中进行展示
        /// </summary>
        [JsonPropertyName("push_unit_name")]
        public string PushUnitName { get; set; }

        /// <summary>
        /// 集点召回通知规则
        /// </summary>
        [JsonPropertyName("recall_rule")]
        public CampaignExtInfo RecallRule { get; set; }

        /// <summary>
        /// 集点活动开始时间。取值精确至秒，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
