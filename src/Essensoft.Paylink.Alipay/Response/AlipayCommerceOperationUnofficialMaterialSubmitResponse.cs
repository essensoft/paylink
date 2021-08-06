using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceOperationUnofficialMaterialSubmitResponse.
    /// </summary>
    public class AlipayCommerceOperationUnofficialMaterialSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 对应所插入非官方物料数据的唯一凭证
        /// </summary>
        [JsonPropertyName("response_id")]
        public string ResponseId { get; set; }
    }
}
