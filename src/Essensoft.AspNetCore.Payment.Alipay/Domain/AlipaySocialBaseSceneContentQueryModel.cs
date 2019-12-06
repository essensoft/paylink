using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseSceneContentQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseSceneContentQueryModel : AlipayObject
    {
        /// <summary>
        /// 城市id
        /// </summary>
        [JsonPropertyName("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 内容中台提供的运营后台配置场景id
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 返回文章列表的个数，目前最多10条
        /// </summary>
        [JsonPropertyName("top_size")]
        public long TopSize { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
