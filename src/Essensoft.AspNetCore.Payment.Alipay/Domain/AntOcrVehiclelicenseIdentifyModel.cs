using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntOcrVehiclelicenseIdentifyModel Data Structure.
    /// </summary>
    public class AntOcrVehiclelicenseIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// 正面：face；背面：back
        /// </summary>
        [JsonPropertyName("side")]
        public string Side { get; set; }

        /// <summary>
        /// 图片存储类型，url：图片url地址；aftsId：afts文件服务Id
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
