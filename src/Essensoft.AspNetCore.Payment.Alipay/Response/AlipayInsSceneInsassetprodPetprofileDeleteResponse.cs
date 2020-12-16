using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofileDeleteResponse.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofileDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 删除档案结果
        /// </summary>
        [JsonPropertyName("delete_flag")]
        public bool DeleteFlag { get; set; }
    }
}
