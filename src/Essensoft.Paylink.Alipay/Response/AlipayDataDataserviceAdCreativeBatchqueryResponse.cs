using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 创意按条件分页查询结果
        /// </summary>
        [JsonPropertyName("creative_list")]
        public PageCreative CreativeList { get; set; }
    }
}
