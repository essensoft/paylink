using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandShopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。本接口中，如果没传shop_id，则本字段与store_id均必填
        /// </summary>
        [JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 蚂蚁店铺id。填写本参数的话，store_id和ip_role_id可以不填
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号。关店接口中，如果没传shop_id，则本字段与ip_role_id均必填
        /// </summary>
        [JsonProperty("store_id")]
        public string StoreId { get; set; }
    }
}
