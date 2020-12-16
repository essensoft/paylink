using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecordDetail Data Structure.
    /// </summary>
    public class RecordDetail : AlipayObject
    {
        /// <summary>
        /// 消费说明
        /// </summary>
        [JsonPropertyName("consume_title")]
        public string ConsumeTitle { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonPropertyName("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 交易时间 yyyy-mm-dd HH:MM:SS
        /// </summary>
        [JsonPropertyName("trans_dt")]
        public string TransDt { get; set; }
    }
}
