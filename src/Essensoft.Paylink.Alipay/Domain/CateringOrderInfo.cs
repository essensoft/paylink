using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CateringOrderInfo Data Structure.
    /// </summary>
    public class CateringOrderInfo : AlipayObject
    {
        /// <summary>
        /// 点餐首页
        /// </summary>
        [JsonPropertyName("merchant_home_url")]
        public string MerchantHomeUrl { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [JsonPropertyName("table_num")]
        public string TableNum { get; set; }
    }
}
