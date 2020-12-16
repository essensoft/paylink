using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PetPicData Data Structure.
    /// </summary>
    public class PetPicData : AlipayObject
    {
        /// <summary>
        /// 宠物照片类型，如全身照、鼻纹照
        /// </summary>
        [JsonPropertyName("image_type")]
        public string ImageType { get; set; }

        /// <summary>
        /// 宠物照片地址
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }
    }
}
