using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OcrTaxiScanInfo Data Structure.
    /// </summary>
    public class OcrTaxiScanInfo : AlipayObject
    {
        /// <summary>
        /// 下车时间
        /// </summary>
        [JsonPropertyName("get_off_time")]
        public string GetOffTime { get; set; }

        /// <summary>
        /// 上车时间
        /// </summary>
        [JsonPropertyName("get_on_time")]
        public string GetOnTime { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票时间
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 乘客人
        /// </summary>
        [JsonPropertyName("passenger")]
        public string Passenger { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 乘车距离
        /// </summary>
        [JsonPropertyName("travel_dist")]
        public string TravelDist { get; set; }
    }
}
