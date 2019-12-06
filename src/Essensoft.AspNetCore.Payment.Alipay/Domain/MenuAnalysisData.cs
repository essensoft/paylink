using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MenuAnalysisData Data Structure.
    /// </summary>
    public class MenuAnalysisData : AlipayObject
    {
        /// <summary>
        /// 人均点击次数
        /// </summary>
        [JsonPropertyName("avg_click_user_cnt")]
        public string AvgClickUserCnt { get; set; }

        /// <summary>
        /// 菜单点击次数
        /// </summary>
        [JsonPropertyName("click_cnt")]
        public long ClickCnt { get; set; }

        /// <summary>
        /// 菜单点击人数
        /// </summary>
        [JsonPropertyName("click_user_cnt")]
        public long ClickUserCnt { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 菜单类型 ，iconDefault ：图标菜单、default：文字菜单
        /// </summary>
        [JsonPropertyName("menu_type")]
        public string MenuType { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 子菜单名称，文字菜单才有
        /// </summary>
        [JsonPropertyName("sub_name")]
        public string SubName { get; set; }
    }
}
