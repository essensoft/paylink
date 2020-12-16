using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OcrTrainScanInfo Data Structure.
    /// </summary>
    public class OcrTrainScanInfo : AlipayObject
    {
        /// <summary>
        /// 目的地
        /// </summary>
        [JsonPropertyName("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 乘车日期
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 出发地
        /// </summary>
        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 乘客
        /// </summary>
        [JsonPropertyName("passenger")]
        public string Passenger { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 明细事由
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 座次
        /// </summary>
        [JsonPropertyName("seat_class")]
        public string SeatClass { get; set; }

        /// <summary>
        /// 车次
        /// </summary>
        [JsonPropertyName("train_no")]
        public string TrainNo { get; set; }
    }
}
