using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ContentPicture Data Structure.
    /// </summary>
    public class ContentPicture : AlipayObject
    {
        /// <summary>
        /// 调用alipay.offline.material.image.upload，将图片上传到素材中心后，生成的ID
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// "DISH"："菜品"，"ENVIRONMENT"："环境"，"SHOPHEAD"："门头照"，"OTHER"："其他"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
