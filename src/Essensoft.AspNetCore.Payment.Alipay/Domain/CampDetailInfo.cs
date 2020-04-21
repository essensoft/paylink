using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CampDetailInfo Data Structure.
    /// </summary>
    public class CampDetailInfo : AlipayObject
    {
        /// <summary>
        /// 活动开始时间
        /// </summary>
        [JsonPropertyName("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 业务id，与bizType 一一对应，如：biz_type为消费送，biz_id为消费送活动id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型：CONSUME_SEND：消费送；MRT_DISCOUNT:商户立减；OBTAIN:通用领券
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [JsonPropertyName("camp_desc")]
        public string CampDesc { get; set; }

        /// <summary>
        /// 需要解析该json串，title为标题，details是描述，多个detail需要换行
        /// </summary>
        [JsonPropertyName("camp_guide")]
        public string CampGuide { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展字段信息，用Map对象json串保存
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 活动规则标识列表，列表中存在的标识，代表该活动包含对应的规则。目前只有人群规则一种。标识说明：  CROWD：人群规则
        /// </summary>
        [JsonPropertyName("rule_flag_list")]
        public List<string> RuleFlagList { get; set; }

        /// <summary>
        /// 每人每日参与次数 -1为不限制
        /// </summary>
        [JsonPropertyName("win_limit_daily")]
        public string WinLimitDaily { get; set; }

        /// <summary>
        /// 每人总参与次数 -1 为不限制
        /// </summary>
        [JsonPropertyName("win_limit_life")]
        public string WinLimitLife { get; set; }
    }
}
