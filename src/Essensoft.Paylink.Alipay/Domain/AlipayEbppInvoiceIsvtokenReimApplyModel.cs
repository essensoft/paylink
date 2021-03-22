using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceIsvtokenReimApplyModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceIsvtokenReimApplyModel : AlipayObject
    {
        /// <summary>
        /// 报销软件app对应的isv app code，由支付宝进行分配。详情参见 <a href="https://opendocs.alipay.com/open/017fwh">"推"模式发票报销</a>
        /// </summary>
        [JsonPropertyName("isv_app_code")]
        public string IsvAppCode { get; set; }
    }
}
