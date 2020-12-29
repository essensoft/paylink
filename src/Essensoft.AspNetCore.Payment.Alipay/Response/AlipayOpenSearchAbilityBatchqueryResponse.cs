using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSearchAbilityBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchAbilityBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 搜索运营分页数据
        /// </summary>
        [JsonPropertyName("data")]
        public AbilityPageQueryDTO Data { get; set; }
    }
}
