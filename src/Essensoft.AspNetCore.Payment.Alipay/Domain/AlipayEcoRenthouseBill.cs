using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseBill Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseBill : AlipayObject
    {
        /// <summary>
        /// 账单金额
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账单创建时间  数据格式: yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("bill_create_time")]
        public string BillCreateTime { get; set; }

        /// <summary>
        /// 对描述该笔账单进行具体描述，用于提醒用户。例如：八月房屋租金、八月杂费等。
        /// </summary>
        [JsonPropertyName("bill_desc")]
        public string BillDesc { get; set; }

        /// <summary>
        /// 账单编号-ka保证唯一
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单状态  0:正常1:作废2:关闭
        /// </summary>
        [JsonPropertyName("bill_status")]
        public long BillStatus { get; set; }

        /// <summary>
        /// 账单类型  10001:房屋租金  10002:其他费用  20001:房屋押金  20002:其他押金
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 数据格式: yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("deadline_date")]
        public string DeadlineDate { get; set; }

        /// <summary>
        /// 定金抵扣金额
        /// </summary>
        [JsonPropertyName("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 结束时间  数据格式：yyyy-mm-dd
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 租约编号(KA内部租约业务编号)
        /// </summary>
        [JsonPropertyName("lease_no")]
        public string LeaseNo { get; set; }

        /// <summary>
        /// 其他未涵盖信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 最低支付金额
        /// </summary>
        [JsonPropertyName("min_pay_amount")]
        public string MinPayAmount { get; set; }

        /// <summary>
        /// 已支付金额
        /// </summary>
        [JsonPropertyName("paid_amount")]
        public string PaidAmount { get; set; }

        /// <summary>
        /// 1:禁止tp发起支付
        /// </summary>
        [JsonPropertyName("pay_lock")]
        public long PayLock { get; set; }

        /// <summary>
        /// 禁止支付原因-页面提示租客
        /// </summary>
        [JsonPropertyName("pay_lock_memo")]
        public string PayLockMemo { get; set; }

        /// <summary>
        /// 支付状态  0:未支付1:已支付
        /// </summary>
        [JsonPropertyName("pay_status")]
        public long PayStatus { get; set; }

        /// <summary>
        /// 账单支付时间  数据格式: yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 开始时间  数据格式：yyyy-mm-dd
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
