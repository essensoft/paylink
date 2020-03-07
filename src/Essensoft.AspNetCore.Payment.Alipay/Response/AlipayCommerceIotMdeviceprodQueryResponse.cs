using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备激活时间
        /// </summary>
        [JsonPropertyName("activate_time")]
        public string ActivateTime { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        [JsonPropertyName("addr_info")]
        public string AddrInfo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 机具唯一id
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 机具名称
        /// </summary>
        [JsonPropertyName("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 机具序列号
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 机具图片信息
        /// </summary>
        [JsonPropertyName("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// isv信息
        /// </summary>
        [JsonPropertyName("isv")]
        public MerchantModel Isv { get; set; }

        /// <summary>
        /// 商户联系信息
        /// </summary>
        [JsonPropertyName("merchant")]
        public MerchantModel Merchant { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        [JsonPropertyName("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// xxx店铺
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 机具状态code
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 设备状态描述
        /// </summary>
        [JsonPropertyName("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 机具生产厂商
        /// </summary>
        [JsonPropertyName("supplier_name")]
        public string SupplierName { get; set; }
    }
}
