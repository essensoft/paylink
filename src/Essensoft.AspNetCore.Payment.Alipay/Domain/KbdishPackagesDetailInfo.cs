using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishPackagesDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishPackagesDetailInfo : AlipayObject
    {
        /// <summary>
        /// 明细菜品在套餐里的个数, 不填默认为1
        /// </summary>
        [JsonProperty("detail_count")]
        [XmlElement("detail_count")]
        public string DetailCount { get; set; }

        /// <summary>
        /// 是否追加可选 Y .N  明细是否追加可选
        /// </summary>
        [JsonProperty("detail_is_select")]
        [XmlElement("detail_is_select")]
        public string DetailIsSelect { get; set; }

        /// <summary>
        /// 明细菜品的会员价格单价
        /// </summary>
        [JsonProperty("detail_member_price")]
        [XmlElement("detail_member_price")]
        public string DetailMemberPrice { get; set; }

        /// <summary>
        /// 明细菜品在套餐里的售卖单价
        /// </summary>
        [JsonProperty("detail_sell_price")]
        [XmlElement("detail_sell_price")]
        public string DetailSellPrice { get; set; }

        /// <summary>
        /// 套餐明细的skuId
        /// </summary>
        [JsonProperty("detail_sku_id")]
        [XmlElement("detail_sku_id")]
        public string DetailSkuId { get; set; }

        /// <summary>
        /// 排序字段 必输 仅为数字 越小排在前面
        /// </summary>
        [JsonProperty("detail_sort")]
        [XmlElement("detail_sort")]
        public string DetailSort { get; set; }

        /// <summary>
        /// 明细的类型，dish:单品 还是 group:项目
        /// </summary>
        [JsonProperty("detail_type")]
        [XmlElement("detail_type")]
        public string DetailType { get; set; }

        /// <summary>
        /// 套餐组id,如果类型是group 必须要填groupId
        /// </summary>
        [JsonProperty("group_id")]
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 套餐的sku_code
        /// </summary>
        [JsonProperty("packages_sku_id")]
        [XmlElement("packages_sku_id")]
        public string PackagesSkuId { get; set; }
    }
}
