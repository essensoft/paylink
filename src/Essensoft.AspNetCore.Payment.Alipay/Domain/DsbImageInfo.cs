using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DsbImageInfo Data Structure.
    /// </summary>
    public class DsbImageInfo : AlipayObject
    {
        /// <summary>
        /// 定损图片的afts id
        /// </summary>
        [JsonPropertyName("afts_id")]
        public string AftsId { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [JsonPropertyName("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 拍摄时间
        /// </summary>
        [JsonPropertyName("shoot_time")]
        public string ShootTime { get; set; }
    }
}
