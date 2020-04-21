using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataBillBailQueryModel Data Structure.
    /// </summary>
    public class AlipayDataBillBailQueryModel : AlipayObject
    {
        /// <summary>
        /// 保证金类型，目前支持TMALL_BAIL-天猫保证金，TAOBAO_BAIL-淘宝保证金
        /// </summary>
        [JsonPropertyName("bail_type")]
        public string BailType { get; set; }

        /// <summary>
        /// 业务基础订单号。如果查询参数中指定订单号，则只查询相关的记录
        /// </summary>
        [JsonPropertyName("biz_orig_no")]
        public string BizOrigNo { get; set; }

        /// <summary>
        /// 保证金流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 保证金流水创建时间的起始范围
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 保证金流水号。如果查询参数中指定流水号，则只查询流水号相关的记录
        /// </summary>
        [JsonPropertyName("trans_log_id")]
        public string TransLogId { get; set; }
    }
}
