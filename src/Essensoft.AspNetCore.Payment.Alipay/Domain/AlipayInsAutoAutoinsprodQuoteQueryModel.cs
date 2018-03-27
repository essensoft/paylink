using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteQueryModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoinsprodQuoteQueryModel : AlipayObject
    {
        /// <summary>
        /// 询价ID
        /// </summary>
        [JsonProperty("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [JsonProperty("quote_biz_id")]
        public string QuoteBizId { get; set; }
    }
}
