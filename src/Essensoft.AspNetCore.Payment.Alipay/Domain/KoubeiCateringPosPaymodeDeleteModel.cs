using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodeDeleteModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosPaymodeDeleteModel : AlipayObject
    {
        /// <summary>
        /// 支付方式名称
        /// </summary>
        [JsonPropertyName("pay_name")]
        public string PayName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 是否系统（false:否；true:是）
        /// </summary>
        [JsonPropertyName("system")]
        public bool System { get; set; }
    }
}
