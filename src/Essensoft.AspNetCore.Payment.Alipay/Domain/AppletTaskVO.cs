using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppletTaskVO Data Structure.
    /// </summary>
    public class AppletTaskVO : AlipayObject
    {
        /// <summary>
        /// 是否可以报名
        /// </summary>
        [JsonPropertyName("can_access")]
        public bool CanAccess { get; set; }

        /// <summary>
        /// 任务显示信息。
        /// </summary>
        [JsonPropertyName("display")]
        public AppletTaskDisplayVO Display { get; set; }

        /// <summary>
        /// 是否需要报名
        /// </summary>
        [JsonPropertyName("need_sign_up")]
        public string NeedSignUp { get; set; }

        /// <summary>
        /// 报名周期内当前完成次数
        /// </summary>
        [JsonPropertyName("period_current_complete_num")]
        public long PeriodCurrentCompleteNum { get; set; }

        /// <summary>
        /// 报名周期内最大完成次数
        /// </summary>
        [JsonPropertyName("period_total_complete_num")]
        public long PeriodTotalCompleteNum { get; set; }

        /// <summary>
        /// 任务奖品。
        /// </summary>
        [JsonPropertyName("prize_list")]
        public List<AppletTaskPrizeVO> PrizeList { get; set; }

        /// <summary>
        /// 报名开始时间。
        /// </summary>
        [JsonPropertyName("sign_up_begin_time")]
        public string SignUpBeginTime { get; set; }

        /// <summary>
        /// 报名结束时间
        /// </summary>
        [JsonPropertyName("sign_up_end_time")]
        public string SignUpEndTime { get; set; }

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务名称。
        /// </summary>
        [JsonPropertyName("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务状态。NONE_SIGNUP未报名/SIGNUP_EXPIRED报名已失效/PARTLY_DONE未完成/RECEIVE_SUCCESS领奖成功/RECEIVE_FAILED领奖失败/RECEIVE_EXPIRED过期未领奖/SIGNUP_FAILED报名失败/SIGNUP_CANCELED报名已取消/NOT_DONE无需报名的任务未开始
        /// </summary>
        [JsonPropertyName("task_process_status")]
        public string TaskProcessStatus { get; set; }
    }
}
