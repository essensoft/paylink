using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CumulateDataDetail Data Structure.
    /// </summary>
    public class CumulateDataDetail : AlipayObject
    {
        /// <summary>
        /// 数据回传的动作类型，正向或逆向。
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 回传数据发生的实际时间
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 回传数据类型。
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        [JsonPropertyName("discount_desc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 数据回传时传入的外部业务号。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 数据回传时逆向单据记录的对应正向单据的外部业务号。
        /// </summary>
        [JsonPropertyName("refer_out_biz_no")]
        public string ReferOutBizNo { get; set; }

        /// <summary>
        /// 回传数据子类型。
        /// </summary>
        [JsonPropertyName("sub_data_type")]
        public string SubDataType { get; set; }

        /// <summary>
        /// 任务金额
        /// </summary>
        [JsonPropertyName("task_amount")]
        public string TaskAmount { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonPropertyName("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务次数
        /// </summary>
        [JsonPropertyName("task_times")]
        public long TaskTimes { get; set; }
    }
}
