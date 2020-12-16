using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HomeNormalApiContent Data Structure.
    /// </summary>
    public class HomeNormalApiContent : AlipayObject
    {
        /// <summary>
        /// 毫秒时间戳
        /// </summary>
        [JsonPropertyName("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 订单跳转链接
        /// </summary>
        [JsonPropertyName("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 如果线下排队，用户是否扫描小票上的二维码
        /// </summary>
        [JsonPropertyName("is_scan")]
        public string IsScan { get; set; }

        /// <summary>
        /// 商户详细地址
        /// </summary>
        [JsonPropertyName("merchant_address")]
        public string MerchantAddress { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [JsonPropertyName("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 在线点餐地址
        /// </summary>
        [JsonPropertyName("order_url")]
        public string OrderUrl { get; set; }

        /// <summary>
        /// 叫号业务填排队码
        /// </summary>
        [JsonPropertyName("queue_code")]
        public string QueueCode { get; set; }

        /// <summary>
        /// 排队剩余人数
        /// </summary>
        [JsonPropertyName("queue_num")]
        public string QueueNum { get; set; }

        /// <summary>
        /// 排队途径(线上还是线下排队)
        /// </summary>
        [JsonPropertyName("queue_way")]
        public string QueueWay { get; set; }

        /// <summary>
        /// 门店的shop_id(唯一)
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
