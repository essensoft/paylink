using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CateringStoreInfo Data Structure.
    /// </summary>
    public class CateringStoreInfo : AlipayObject
    {
        /// <summary>
        /// 门店营业时间
        /// </summary>
        [JsonPropertyName("business_hours")]
        public BusinessHoursInfo BusinessHours { get; set; }

        /// <summary>
        /// 外卖相关参数
        /// </summary>
        [JsonPropertyName("delivery_info")]
        public CateringStoreDeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// 人均消费
        /// </summary>
        [JsonPropertyName("per_consumption")]
        public string PerConsumption { get; set; }

        /// <summary>
        /// 支付宝门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店地址信息
        /// </summary>
        [JsonPropertyName("store_address_info")]
        public StoreAddressInfo StoreAddressInfo { get; set; }

        /// <summary>
        /// 门店城市
        /// </summary>
        [JsonPropertyName("store_city")]
        public string StoreCity { get; set; }

        /// <summary>
        /// 门店扩展字段，key：store_marking，value：pre_authorization
        /// </summary>
        [JsonPropertyName("store_extra_info")]
        public List<ExtraInfo> StoreExtraInfo { get; set; }

        /// <summary>
        /// 商家门店id
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店联系方式
        /// </summary>
        [JsonPropertyName("store_phone")]
        public string StorePhone { get; set; }
    }
}
