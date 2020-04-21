using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlgorithmGoodsInfo Data Structure.
    /// </summary>
    public class AlgorithmGoodsInfo : AlipayObject
    {
        /// <summary>
        /// 算法商品Id
        /// </summary>
        [JsonPropertyName("algorithm_goods_id")]
        public string AlgorithmGoodsId { get; set; }

        /// <summary>
        /// gif文件Id
        /// </summary>
        [JsonPropertyName("gif_file_id")]
        public string GifFileId { get; set; }

        /// <summary>
        /// 图片文件Id
        /// </summary>
        [JsonPropertyName("pic_file_id")]
        public string PicFileId { get; set; }

        /// <summary>
        /// 商品三维(单位mm*mm*mm)
        /// </summary>
        [JsonPropertyName("three_dimension")]
        public string ThreeDimension { get; set; }

        /// <summary>
        /// 缩略图fileId表，json
        /// </summary>
        [JsonPropertyName("thumbnails")]
        public string Thumbnails { get; set; }
    }
}
