using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSpaceCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieSpaceCreateModel : AlipayObject
    {
        /// <summary>
        /// 欲创建的空间名称。应注意云凤蝶中每个空间有唯一的空间名称，尽量使用自己平台的前缀。另外空间名称只允许是中英文字符数字下划线组成的字符串。
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
