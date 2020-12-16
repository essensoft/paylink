using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceOpenRedCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceOpenRedCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 发票生成的开票申请流水id，查询开票结果使用改值
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }
    }
}
