using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询返回结果：发票信息
        /// </summary>
        [JsonPropertyName("result_set")]
        public ArInvoiceOpenApiResponse ResultSet { get; set; }
    }
}
