using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrizeCustomMenu Data Structure.
    /// </summary>
    public class PrizeCustomMenu : AlipayObject
    {
        /// <summary>
        /// 菜单详情
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
