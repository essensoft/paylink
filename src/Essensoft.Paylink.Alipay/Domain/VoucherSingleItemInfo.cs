using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherSingleItemInfo Data Structure.
    /// </summary>
    public class VoucherSingleItemInfo : AlipayObject
    {
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

        /// <summary>
        /// 单品id列表
        /// </summary>
        [JsonPropertyName("item_sku_id_list")]
        public List<string> ItemSkuIdList { get; set; }
    }
}
