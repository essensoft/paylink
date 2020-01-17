using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MorphoCreateSource Data Structure.
    /// </summary>
    public class MorphoCreateSource : AlipayObject
    {
        /// <summary>
        /// 小程序源码地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 调用闪蝶基于小程序源码创建应用时对应调用方侧应用的唯一标识
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
