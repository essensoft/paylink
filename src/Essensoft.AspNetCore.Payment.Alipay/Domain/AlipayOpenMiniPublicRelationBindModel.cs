using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPublicRelationBindModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniPublicRelationBindModel : AlipayObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 生活号ID
        /// </summary>
        [JsonPropertyName("public_id")]
        public string PublicId { get; set; }
    }
}
