using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntOcrGeneralIdentifyModel Data Structure.
    /// </summary>
    public class AntOcrGeneralIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// 图片存储类型，url：图片url地址；aftsId：afts文件服务Id
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
