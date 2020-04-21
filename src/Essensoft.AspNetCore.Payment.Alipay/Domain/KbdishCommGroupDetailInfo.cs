using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCommGroupDetailInfo Data Structure.
    /// </summary>
    public class KbdishCommGroupDetailInfo : AlipayObject
    {
        /// <summary>
        /// 明细描述；加料以本身的描述为准，该字段不生效
        /// </summary>
        [JsonPropertyName("detail_desc")]
        public string DetailDesc { get; set; }

        /// <summary>
        /// 存明细的业务id，如果是加料组传入加料id，如果是属性组明细id由口碑生成；更新、删除明细时必填
        /// </summary>
        [JsonPropertyName("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 明细名称；加料以本身的名称为准，该字段不生效
        /// </summary>
        [JsonPropertyName("detail_name")]
        public string DetailName { get; set; }

        /// <summary>
        /// 扩展透穿
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 图片id；加料以本身的图片id为准，该字段不生效
        /// </summary>
        [JsonPropertyName("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 外部isv的明细id；加料以本身的外部id为准，该字段不生效
        /// </summary>
        [JsonPropertyName("out_detail_id")]
        public string OutDetailId { get; set; }

        /// <summary>
        /// 通用组的组明细之间的排序
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; }
    }
}
