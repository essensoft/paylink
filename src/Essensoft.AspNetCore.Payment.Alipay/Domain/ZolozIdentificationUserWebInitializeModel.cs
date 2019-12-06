using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationUserWebInitializeModel Data Structure.
    /// </summary>
    public class ZolozIdentificationUserWebInitializeModel : AlipayObject
    {
        /// <summary>
        /// 商户请求的唯一标识，该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 预留扩展业务参数
        /// </summary>
        [JsonPropertyName("extern_param")]
        public string ExternParam { get; set; }

        /// <summary>
        /// 用户身份信息
        /// </summary>
        [JsonPropertyName("identity_param")]
        public IdentityParam IdentityParam { get; set; }

        /// <summary>
        /// 环境参数
        /// </summary>
        [JsonPropertyName("metainfo")]
        public string Metainfo { get; set; }
    }
}
