using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// IoTBPaaSDeviceApplyBindInfo Data Structure.
    /// </summary>
    public class IoTBPaaSDeviceApplyBindInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }
    }
}
