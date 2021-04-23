using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// UnfreezeExtendParams Data Structure.
    /// </summary>
    public class UnfreezeExtendParams : AlipayObject
    {
        /// <summary>
        /// 退出类型
        /// </summary>
        [JsonPropertyName("quit_type")]
        public string QuitType { get; set; }

        /// <summary>
        /// 芝麻Go开始到到期过程中享受的优惠总金额
        /// </summary>
        [JsonPropertyName("total_discount_amount")]
        public string TotalDiscountAmount { get; set; }

        /// <summary>
        /// 芝麻Go开始到到期过程中任务相关支付的总金额。
        /// </summary>
        [JsonPropertyName("total_real_pay_amount")]
        public string TotalRealPayAmount { get; set; }

        /// <summary>
        /// 芝麻Go开始到到期过程中和任务相关的完成次数
        /// </summary>
        [JsonPropertyName("total_task_count")]
        public string TotalTaskCount { get; set; }
    }
}
