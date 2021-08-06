using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// OrderShop Data Structure.
    /// </summary>
    public class OrderShop : AlipayObject
    {
        /// <summary>
        /// 法人身份证
        /// </summary>
        [JsonPropertyName("legal_person_identity_card")]
        public string LegalPersonIdentityCard { get; set; }

        /// <summary>
        /// 店铺所在详细地址
        /// </summary>
        [JsonPropertyName("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 店铺所在市
        /// </summary>
        [JsonPropertyName("shop_city")]
        public string ShopCity { get; set; }

        /// <summary>
        /// 店铺所在区/县
        /// </summary>
        [JsonPropertyName("shop_district")]
        public string ShopDistrict { get; set; }

        /// <summary>
        /// 店铺行业,使用蚂蚁行业分类，可参考https://www.yuque.com/kangxia-ij2dr/kb/ybdoqb#ib45 注意：一级目录与行业使用"-"分隔
        /// </summary>
        [JsonPropertyName("shop_industry")]
        public string ShopIndustry { get; set; }

        /// <summary>
        /// 店铺纬度
        /// </summary>
        [JsonPropertyName("shop_latitude")]
        public string ShopLatitude { get; set; }

        /// <summary>
        /// 店铺营业执照照片
        /// </summary>
        [JsonPropertyName("shop_licence_photo")]
        public string ShopLicencePhoto { get; set; }

        /// <summary>
        /// 店铺联系人电话
        /// </summary>
        [JsonPropertyName("shop_linkman_mobile")]
        public string ShopLinkmanMobile { get; set; }

        /// <summary>
        /// 店铺联系人
        /// </summary>
        [JsonPropertyName("shop_linkman_name")]
        public string ShopLinkmanName { get; set; }

        /// <summary>
        /// 店铺经度
        /// </summary>
        [JsonPropertyName("shop_longitude")]
        public string ShopLongitude { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺营业时间(时间范围 00:00-24:00 )
        /// </summary>
        [JsonPropertyName("shop_open_time")]
        public string ShopOpenTime { get; set; }

        /// <summary>
        /// 店铺所在省
        /// </summary>
        [JsonPropertyName("shop_province")]
        public string ShopProvince { get; set; }
    }
}
