using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateKeyword Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateKeyword : AlipayObject
    {
        /// <summary>
        /// 模板中占位符的颜色
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// 模板中占位符的值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
