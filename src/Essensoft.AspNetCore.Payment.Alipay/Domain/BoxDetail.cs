using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BoxDetail Data Structure.
    /// </summary>
    public class BoxDetail : AlipayObject
    {
        /// <summary>
        /// 品牌box所属biz_id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [JsonPropertyName("block_type")]
        public string BlockType { get; set; }

        /// <summary>
        /// 版本信息
        /// </summary>
        [JsonPropertyName("box_version")]
        public string BoxVersion { get; set; }

        /// <summary>
        /// 详情描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonPropertyName("img")]
        public string Img { get; set; }

        /// <summary>
        /// 品牌box数据索引
        /// </summary>
        [JsonPropertyName("index")]
        public long Index { get; set; }

        /// <summary>
        /// 品牌box所属material_id
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 提报应用名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 品牌box所属sub_service_code
        /// </summary>
        [JsonPropertyName("sub_service_code")]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 跳转url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
