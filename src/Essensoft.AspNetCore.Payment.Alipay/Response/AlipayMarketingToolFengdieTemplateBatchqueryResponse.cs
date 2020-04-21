using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 模板详情列表
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieTemplateListRespModel Data { get; set; }
    }
}
