using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntpaasTokenidentityQueryResponse.
    /// </summary>
    public class AlipayUserAntpaasTokenidentityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁通行证Id
        /// </summary>
        [JsonPropertyName("ant_id")]
        public string AntId { get; set; }

        /// <summary>
        /// 扩展信息,业务方在创建匿名用户时设置的扩展信息。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 支付宝用户Id，即匿名用户Id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
