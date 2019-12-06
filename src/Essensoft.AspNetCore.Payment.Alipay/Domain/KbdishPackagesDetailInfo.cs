using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishPackagesDetailInfo Data Structure.
    /// </summary>
    public class KbdishPackagesDetailInfo : AlipayObject
    {
        /// <summary>
        /// 明细菜品在套餐里的个数, 不填默认为1
        /// </summary>
        [JsonPropertyName("detail_count")]
        public string DetailCount { get; set; }

        /// <summary>
        /// 是否追加可选 Y .N  明细是否追加可选
        /// </summary>
        [JsonPropertyName("detail_is_select")]
        public string DetailIsSelect { get; set; }

        /// <summary>
        /// 明细菜品的会员价格单价
        /// </summary>
        [JsonPropertyName("detail_member_price")]
        public string DetailMemberPrice { get; set; }

        /// <summary>
        /// 明细菜品在套餐里的售卖单价
        /// </summary>
        [JsonPropertyName("detail_sell_price")]
        public string DetailSellPrice { get; set; }

        /// <summary>
        /// 套餐明细的skuId
        /// </summary>
        [JsonPropertyName("detail_sku_id")]
        public string DetailSkuId { get; set; }

        /// <summary>
        /// 排序字段 必输 仅为数字 越小排在前面
        /// </summary>
        [JsonPropertyName("detail_sort")]
        public string DetailSort { get; set; }

        /// <summary>
        /// 明细的类型，dish:单品 还是 group:项目
        /// </summary>
        [JsonPropertyName("detail_type")]
        public string DetailType { get; set; }

        /// <summary>
        /// 套餐组id,如果类型是group 必须要填groupId
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 套餐的sku_code
        /// </summary>
        [JsonPropertyName("packages_sku_id")]
        public string PackagesSkuId { get; set; }
    }
}
