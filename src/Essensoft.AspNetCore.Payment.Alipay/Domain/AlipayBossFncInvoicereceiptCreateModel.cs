using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvoicereceiptCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoicereceiptCreateModel : AlipayObject
    {
        /// <summary>
        /// 账单金额变更消息事件码  AR_MTHLY_BILL_CREATE:应收账单创建,  AR_MTHLY_BILL_CHANGE:应收金额更新
        /// </summary>
        [JsonProperty("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 账单金额变更消息事件类型  CREATE:创建事件,UPDATE:更新事件
        /// </summary>
        [JsonProperty("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 月帐单信息
        /// </summary>
        [JsonProperty("monthly_bill")]
        public ArMonthlyBillDTO MonthlyBill { get; set; }

        /// <summary>
        /// 事件全局id，可以使用uuid
        /// </summary>
        [JsonProperty("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 消息来源 01:主站，02：芝麻，03:金融云,04:微贷
        /// </summary>
        [JsonProperty("out_biz_type")]
        public string OutBizType { get; set; }
    }
}
