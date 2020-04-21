using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 获取云凤蝶站点列表返回值模型
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieSitesListRespModel Data { get; set; }
    }
}
