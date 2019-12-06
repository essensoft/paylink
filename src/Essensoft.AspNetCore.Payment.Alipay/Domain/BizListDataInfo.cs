using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizListDataInfo Data Structure.
    /// </summary>
    public class BizListDataInfo : AlipayObject
    {
        /// <summary>
        /// 下拉列表编号
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 下拉列表名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
