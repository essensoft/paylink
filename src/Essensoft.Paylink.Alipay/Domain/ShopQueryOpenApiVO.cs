using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ShopQueryOpenApiVO Data Structure.
    /// </summary>
    public class ShopQueryOpenApiVO : AlipayObject
    {
        /// <summary>
        /// 经营地址
        /// </summary>
        [JsonPropertyName("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 店铺经营时间
        /// </summary>
        [JsonPropertyName("business_time")]
        public List<ShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 店铺联系手机
        /// </summary>
        [JsonPropertyName("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固话
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code。类目标准及与原shop_category映射关系参见文档https://ur.alipay.com/3oJ26c0veETkLXgTbtQnYY
        /// </summary>
        [JsonPropertyName("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 蚂蚁店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店状态，01正常，03冻结
        /// </summary>
        [JsonPropertyName("shop_status")]
        public string ShopStatus { get; set; }

        /// <summary>
        /// 店铺经营类型，01表示直营，02表示加盟
        /// </summary>
        [JsonPropertyName("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
