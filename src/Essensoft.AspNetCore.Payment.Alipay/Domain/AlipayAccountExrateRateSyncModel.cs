using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateRateSyncModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateRateSyncModel : AlipayObject
    {
        /// <summary>
        /// 通用接口入参，json字符串的形式。比如该openapi绑定客户汇率发布能力，则以json字符串的形式传入客户汇率
        /// </summary>
        [JsonPropertyName("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 客户汇率发布
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }
    }
}
