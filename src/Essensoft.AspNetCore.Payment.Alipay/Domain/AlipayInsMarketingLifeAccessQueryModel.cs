using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingLifeAccessQueryModel Data Structure.
    /// </summary>
    public class AlipayInsMarketingLifeAccessQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
