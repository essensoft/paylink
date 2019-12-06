using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherStockUseResponse.
    /// </summary>
    public class AlipayMarketingVoucherStockUseResponse : AlipayResponse
    {
        /// <summary>
        /// 返回如果为空，说明没有核销成功；如果不为空，长度一定是28，表示的是核销序号。该值唯一对应一个券码，即入参中的entity_no
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
