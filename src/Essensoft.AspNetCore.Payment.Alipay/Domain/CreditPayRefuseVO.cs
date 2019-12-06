using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayRefuseVO Data Structure.
    /// </summary>
    public class CreditPayRefuseVO : AlipayObject
    {
        /// <summary>
        /// 拒绝码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 拒绝详情
        /// </summary>
        [JsonPropertyName("msg")]
        public string Msg { get; set; }
    }
}
