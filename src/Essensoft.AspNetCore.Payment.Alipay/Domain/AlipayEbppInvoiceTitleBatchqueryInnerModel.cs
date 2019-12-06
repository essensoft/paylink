using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleBatchqueryInnerModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceTitleBatchqueryInnerModel : AlipayObject
    {
        /// <summary>
        /// 抬头所属支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
