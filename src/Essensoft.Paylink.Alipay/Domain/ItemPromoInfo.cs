using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ItemPromoInfo Data Structure.
    /// </summary>
    public class ItemPromoInfo : AlipayObject
    {
        /// <summary>
        /// 商品咨询列表
        /// </summary>
        [JsonPropertyName("item_consult_list")]
        public List<ItemConsultInfo> ItemConsultList { get; set; }

        /// <summary>
        /// 单品封面图
        /// </summary>
        [JsonPropertyName("item_cover_pic")]
        public string ItemCoverPic { get; set; }

        /// <summary>
        /// 单品描述
        /// </summary>
        [JsonPropertyName("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 单品详情图列表
        /// </summary>
        [JsonPropertyName("item_detail_pic_list")]
        public List<string> ItemDetailPicList { get; set; }

        /// <summary>
        /// 单品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }
    }
}
