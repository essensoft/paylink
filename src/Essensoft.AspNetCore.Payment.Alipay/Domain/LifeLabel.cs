using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LifeLabel Data Structure.
    /// </summary>
    public class LifeLabel : AlipayObject
    {
        /// <summary>
        /// 该标签支持的业务列表，menu表示个性化菜单，extension表示个性化扩展区，message表示消息触达
        /// </summary>
        [JsonPropertyName("biz")]
        public string Biz { get; set; }

        /// <summary>
        /// 标签类目
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 标签值数据类型
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 标签英文代码
        /// </summary>
        [JsonPropertyName("label_code")]
        public string LabelCode { get; set; }

        /// <summary>
        /// 标签id，唯一标识一个标签
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [JsonPropertyName("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 该标签支持的运算符
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 每个取值的业务含义
        /// </summary>
        [JsonPropertyName("options")]
        public List<Option> Options { get; set; }

        /// <summary>
        /// 标签类型，目前分为common（通用标签）、custom（生活号自定义标签）、cloud（云实验室标签）
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
