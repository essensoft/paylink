using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArticlePicture Data Structure.
    /// </summary>
    public class ArticlePicture : AlipayObject
    {
        /// <summary>
        /// 图片的描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片上传到素材中心后生成的id
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// "DISH"："菜品"，"ENVIRONMENT"："环境"，"SHOPHEAD"："门头照"，"OTHER"："其他"
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
