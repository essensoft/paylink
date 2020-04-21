using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringOrderPayResponse.
    /// </summary>
    public class KoubeiCateringOrderPayResponse : AlipayResponse
    {
        /// <summary>
        /// online_pay：表示在线买单跳转地址
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 该支付宝门店对应商家的partnerId号
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 支付宝门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 当前用户操作的桌码
        /// </summary>
        [JsonPropertyName("table_num")]
        public string TableNum { get; set; }

        /// <summary>
        /// 当前操作用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
