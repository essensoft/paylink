using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentDataCondition Data Structure.
    /// </summary>
    public class InteligentDataCondition : AlipayObject
    {
        /// <summary>
        /// 数据类型，支持枚举：文本：STRING；数值：NUMBER；长整型：LONG；浮点型：DOUBLE；日期：DATE；布尔：BOOLEAN；金额：MONEY
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 数据限制类型，支持枚举：固定值：FIX；单选值：SELECT；区间值：RANGE;
        /// </summary>
        [JsonPropertyName("limit_type")]
        public string LimitType { get; set; }

        /// <summary>
        /// 数据格式值；如：范围值:(1,10)，固定值:1
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
