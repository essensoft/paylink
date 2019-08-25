using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 创意按条件分页查询结果
        /// </summary>
        [JsonProperty("creative_list")]
        public PageCreative CreativeList { get; set; }
    }
}
