using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// Gavintest Data Structure.
    /// </summary>
    public class Gavintest : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonPropertyName("newid")]
        public long Newid { get; set; }
    }
}
