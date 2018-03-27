using Newtonsoft.Json;

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
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
