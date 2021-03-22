using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodInvoiceDeleteModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfsettleprodInvoiceDeleteModel : AlipayObject
    {
        /// <summary>
        /// 发票操作对象
        /// </summary>
        [JsonPropertyName("invoice_operate_param")]
        public InvoiceOperateParam InvoiceOperateParam { get; set; }
    }
}
