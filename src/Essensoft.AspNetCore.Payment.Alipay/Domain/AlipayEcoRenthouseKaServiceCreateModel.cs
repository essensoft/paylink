using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseKaServiceCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseKaServiceCreateModel : AlipayObject
    {
        /// <summary>
        /// 地址-对应在网关注册时候的接口标识
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// kaCode唯一标识
        /// </summary>
        [JsonPropertyName("ka_code")]
        public string KaCode { get; set; }

        /// <summary>
        /// 类型：1:预约看房， 2:确认租约 ，3:拨号记录， 4:支付页面url
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
