using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BrandDetail Data Structure.
    /// </summary>
    public class BrandDetail : AlipayObject
    {
        /// <summary>
        /// 搜索工单详情数据block_type
        /// </summary>
        [JsonPropertyName("block_type")]
        public string BlockType { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("box_version")]
        public string BoxVersion { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// img地址
        /// </summary>
        [JsonPropertyName("img")]
        public string Img { get; set; }

        /// <summary>
        /// 索引信息
        /// </summary>
        [JsonPropertyName("index")]
        public string Index { get; set; }

        /// <summary>
        /// 工单详情数据key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 工单详情数据material_id
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 搜索运营工单详情数据public_bind_app_id
        /// </summary>
        [JsonPropertyName("public_bind_app_id")]
        public string PublicBindAppId { get; set; }

        /// <summary>
        /// 服务码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
