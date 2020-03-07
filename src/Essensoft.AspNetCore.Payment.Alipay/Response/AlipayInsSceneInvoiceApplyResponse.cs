using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneInvoiceApplyResponse.
    /// </summary>
    public class AlipayInsSceneInvoiceApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 发票申请单号
        /// </summary>
        [JsonPropertyName("invoice_apply_no")]
        public string InvoiceApplyNo { get; set; }

        /// <summary>
        /// 商户生成的发票申请请求单号【幂等字段】
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
