using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class OrderItem : AlipayObject
    {
        /// <summary>
        /// 店铺所在具体位置
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("brand_name")]
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 店铺品类
        /// </summary>
        [JsonProperty("category")]
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 店铺所在的市
        /// </summary>
        [JsonProperty("city")]
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonProperty("city_code")]
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 订购的服务商品ID
        /// </summary>
        [JsonProperty("commodity_id")]
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 订单联系人
        /// </summary>
        [JsonProperty("contacts")]
        [XmlElement("contacts")]
        public string Contacts { get; set; }

        /// <summary>
        /// 门店创建人(已删除)
        /// </summary>
        [JsonProperty("creator")]
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expire_date")]
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonProperty("merchant_name")]
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [JsonProperty("merchant_pid")]
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 小程序APPID，订购实体为小程序的场景该字段必填
        /// </summary>
        [JsonProperty("mini_app_id")]
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序应用名称，订购实体为小程序的场景该字段必填
        /// </summary>
        [JsonProperty("mini_app_name")]
        [XmlElement("mini_app_name")]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [JsonProperty("online_time")]
        [XmlElement("online_time")]
        public string OnlineTime { get; set; }

        /// <summary>
        /// TO_DO-未实施,DOING-实施中,TO_CONFIRM-待商户确认,DONE-已完成,MERCHANT_REJECTED-商户已回绝,MERCHANT_CANCELLED-商户已取消,ISV_REJECTED-服务商已回绝,ISV_CANCELLED-服务商已取消
        /// </summary>
        [JsonProperty("order_status")]
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单所属人联系方式（手机或者座机）
        /// </summary>
        [JsonProperty("phone_no")]
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 店铺所在的省份
        /// </summary>
        [JsonProperty("province")]
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 店铺ID，订购实体为口碑门店的场景该字段必填
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称，订购实体为口碑门店的场景该字段必填
        /// </summary>
        [JsonProperty("shop_name")]
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺状态（ONLINE--已上架 OFFLINE--未上架 AVAILABLE--已开通 INIT--未开通 EXPIRED--已过期）
        /// </summary>
        [JsonProperty("shop_status")]
        [XmlElement("shop_status")]
        public string ShopStatus { get; set; }

        /// <summary>
        /// 待服务商接单
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
