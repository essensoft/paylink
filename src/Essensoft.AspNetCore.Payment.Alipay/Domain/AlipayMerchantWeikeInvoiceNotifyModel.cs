using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantWeikeInvoiceNotifyModel Data Structure.
    /// </summary>
    public class AlipayMerchantWeikeInvoiceNotifyModel : AlipayObject
    {
        /// <summary>
        /// 申请ID
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 开票拒绝反馈错误码
        /// </summary>
        [JsonPropertyName("feedback_code")]
        public string FeedbackCode { get; set; }

        /// <summary>
        /// 开票拒绝反馈原因
        /// </summary>
        [JsonPropertyName("feedback_msg")]
        public string FeedbackMsg { get; set; }

        /// <summary>
        /// 反馈状态:true开票成功；false开票拒绝
        /// </summary>
        [JsonPropertyName("feedback_result")]
        public bool FeedbackResult { get; set; }

        /// <summary>
        /// 发票种类，0=电子发票，1=纸质发票，2=专票
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public long InvoiceKind { get; set; }

        /// <summary>
        /// isv的物流信息
        /// </summary>
        [JsonPropertyName("logistics_info")]
        public List<IsvLogisticsInfo> LogisticsInfo { get; set; }
    }
}
