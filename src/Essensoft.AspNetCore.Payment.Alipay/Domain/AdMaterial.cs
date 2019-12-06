using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdMaterial Data Structure.
    /// </summary>
    public class AdMaterial : AlipayObject
    {
        /// <summary>
        /// 物料宽度
        /// </summary>
        [JsonPropertyName("height")]
        public string Height { get; set; }

        /// <summary>
        /// 物料模板位置编号，编号从0开始
        /// </summary>
        [JsonPropertyName("index")]
        public long Index { get; set; }

        /// <summary>
        /// 物料类型，IMG：图片；VIDEO：视频；H5：H5
        /// </summary>
        [JsonPropertyName("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 物料文件签名，天猫业务签名使用MD5算法，使用base64编码，用于物料转储校验
        /// </summary>
        [JsonPropertyName("mt_signature")]
        public string MtSignature { get; set; }

        /// <summary>
        /// 物料播放时长，单位：毫秒
        /// </summary>
        [JsonPropertyName("play_time")]
        public string PlayTime { get; set; }

        /// <summary>
        /// 物料存储URL地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 物料宽度
        /// </summary>
        [JsonPropertyName("width")]
        public string Width { get; set; }
    }
}
