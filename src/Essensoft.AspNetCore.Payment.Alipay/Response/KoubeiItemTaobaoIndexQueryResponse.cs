using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemTaobaoIndexQueryResponse.
    /// </summary>
    public class KoubeiItemTaobaoIndexQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 栏目名称
        /// </summary>
        [JsonPropertyName("column_title")]
        public string ColumnTitle { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<KbItemInfo> ItemList { get; set; }

        /// <summary>
        /// 时段图标
        /// </summary>
        [JsonPropertyName("time_icon")]
        public string TimeIcon { get; set; }

        /// <summary>
        /// 时段名称
        /// </summary>
        [JsonPropertyName("time_title")]
        public string TimeTitle { get; set; }

        /// <summary>
        /// 商品列表页地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
