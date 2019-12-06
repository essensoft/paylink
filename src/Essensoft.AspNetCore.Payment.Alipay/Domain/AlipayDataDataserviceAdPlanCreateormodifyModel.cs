using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPlanCreateormodifyModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdPlanCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 日预算，单位：分
        /// </summary>
        [JsonPropertyName("budget")]
        public long Budget { get; set; }

        /// <summary>
        /// 计费方式：  CPC-按点击付费  CPM-按展示次数付费  CPD-按投放天数计费（包段）
        /// </summary>
        [JsonPropertyName("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 投放结束时间：yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 业务扩展参数字段，根据第三方需要使用，投放端只做存储并向检索端透传
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [JsonPropertyName("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 外部计划唯一编号
        /// </summary>
        [JsonPropertyName("plan_outer_id")]
        public string PlanOuterId { get; set; }

        /// <summary>
        /// 计划状态：PLAN_EFFECTIVE-有效；PLAN_PAUSE-暂停。 若此入参字段为空：新建计划时此字段默认有效；修改计划此字段默认为计划当前状态。 若此入参字段不为空：计划状态与其投放开始和结束时间必须保持一致。
        /// </summary>
        [JsonPropertyName("plan_status")]
        public string PlanStatus { get; set; }

        /// <summary>
        /// 广告投放商家id，来自投放商户创建或者修改接口的响应
        /// </summary>
        [JsonPropertyName("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 售卖方式：  GD-保量投放  RTB-竞价交易
        /// </summary>
        [JsonPropertyName("sell_mode")]
        public string SellMode { get; set; }

        /// <summary>
        /// 投放开始时间：yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 投放时段配置，bitmap。规则：7个int用「,」分隔组成的字符串；每个int中第0位表示0点，第1位表示1点。如此类推; 7个int的排序是星期日、星期一、星期二、星期三、星期四、星期五、星期六。例如：523776,8388096,8388096,8388096,8388352,16776960,523776
        /// </summary>
        [JsonPropertyName("time_schema")]
        public string TimeSchema { get; set; }

        /// <summary>
        /// 广告投放账户id，来自投放账户开户接口的响应
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }
    }
}
