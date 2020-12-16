using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceIsvtokenReimApplyModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceIsvtokenReimApplyModel : AlipayObject
    {
        /// <summary>
        /// 报销软件app对应的isv app code，由支付宝进行分配
        /// </summary>
        [JsonPropertyName("isv_app_code")]
        public string IsvAppCode { get; set; }
    }
}
