using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseBill Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseBill : AlipayObject
    {
        /// <summary>
        /// 账单金额
        /// </summary>
        [JsonProperty("bill_amount")]
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账单创建时间  数据格式: yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("bill_create_time")]
        [XmlElement("bill_create_time")]
        public string BillCreateTime { get; set; }

        /// <summary>
        /// 对描述该笔账单进行具体描述，用于提醒用户。例如：八月房屋租金、八月杂费等。
        /// </summary>
        [JsonProperty("bill_desc")]
        [XmlElement("bill_desc")]
        public string BillDesc { get; set; }

        /// <summary>
        /// 账单编号-ka保证唯一
        /// </summary>
        [JsonProperty("bill_no")]
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单状态  0:正常1:作废2:关闭
        /// </summary>
        [JsonProperty("bill_status")]
        [XmlElement("bill_status")]
        public long BillStatus { get; set; }

        /// <summary>
        /// 账单类型  10001:房屋租金  10002:其他费用  20001:房屋押金  20002:其他押金
        /// </summary>
        [JsonProperty("bill_type")]
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 数据格式: yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("deadline_date")]
        [XmlElement("deadline_date")]
        public string DeadlineDate { get; set; }

        /// <summary>
        /// 定金抵扣金额
        /// </summary>
        [JsonProperty("deduction_amount")]
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonProperty("discount_amount")]
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 结束时间  数据格式：yyyy-mm-dd
        /// </summary>
        [JsonProperty("end_date")]
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 租约编号(KA内部租约业务编号)
        /// </summary>
        [JsonProperty("lease_no")]
        [XmlElement("lease_no")]
        public string LeaseNo { get; set; }

        /// <summary>
        /// 其他未涵盖信息
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 最低支付金额
        /// </summary>
        [JsonProperty("min_pay_amount")]
        [XmlElement("min_pay_amount")]
        public string MinPayAmount { get; set; }

        /// <summary>
        /// 已支付金额
        /// </summary>
        [JsonProperty("paid_amount")]
        [XmlElement("paid_amount")]
        public string PaidAmount { get; set; }

        /// <summary>
        /// 1:禁止tp发起支付
        /// </summary>
        [JsonProperty("pay_lock")]
        [XmlElement("pay_lock")]
        public long PayLock { get; set; }

        /// <summary>
        /// 禁止支付原因-页面提示租客
        /// </summary>
        [JsonProperty("pay_lock_memo")]
        [XmlElement("pay_lock_memo")]
        public string PayLockMemo { get; set; }

        /// <summary>
        /// 支付状态  0:未支付1:已支付
        /// </summary>
        [JsonProperty("pay_status")]
        [XmlElement("pay_status")]
        public long PayStatus { get; set; }

        /// <summary>
        /// 账单支付时间  数据格式: yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("pay_time")]
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 开始时间  数据格式：yyyy-mm-dd
        /// </summary>
        [JsonProperty("start_date")]
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
