using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandShopCloseModel Data Structure.
    /// </summary>
    public class AntMerchantExpandShopCloseModel : AlipayObject
    {
        /// <summary>
        /// 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。若未传入shop_id 则本参数与store_id均必填。
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 支付宝侧蚂蚁店铺 id。传入本参数后可不填 store_id 及 ip_role_id。
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户侧门店编号。表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号。若未传入 shop_id  则本参数与与ip_role_id均必填。
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
