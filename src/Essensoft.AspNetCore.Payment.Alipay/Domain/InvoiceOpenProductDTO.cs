using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceOpenProductDTO Data Structure.
    /// </summary>
    public class InvoiceOpenProductDTO : AlipayObject
    {
        /// <summary>
        /// 税控产品发票类型 可选值：电票：0，纸质普票：1，纸质专票：2
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 税控服务商，由服务商在中台入驻后生成
        /// </summary>
        [JsonPropertyName("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 产品类型，产品码由中台定义
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 服务有效周期-结束时间
        /// </summary>
        [JsonPropertyName("serv_end_time")]
        public string ServEndTime { get; set; }

        /// <summary>
        /// 服务有效周期-起始时间
        /// </summary>
        [JsonPropertyName("serv_start_time")]
        public string ServStartTime { get; set; }
    }
}
