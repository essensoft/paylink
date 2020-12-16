using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ConsumeOutputInfo Data Structure.
    /// </summary>
    public class ConsumeOutputInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单分类
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("consume_amount")]
        public string ConsumeAmount { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("consume_date")]
        public string ConsumeDate { get; set; }

        /// <summary>
        /// 交易记录标题
        /// </summary>
        [JsonPropertyName("consume_title")]
        public string ConsumeTitle { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [JsonPropertyName("payee_name")]
        public string PayeeName { get; set; }
    }
}
