using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntpaasTokenidentityQueryModel Data Structure.
    /// </summary>
    public class AlipayUserAntpaasTokenidentityQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务Id，如口碑小程序场景下，该业务Id设置为微信unionId
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }
    }
}
