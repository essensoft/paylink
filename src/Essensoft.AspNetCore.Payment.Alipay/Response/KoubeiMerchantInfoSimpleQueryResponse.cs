using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantInfoSimpleQueryResponse.
    /// </summary>
    public class KoubeiMerchantInfoSimpleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 操作员登录账号前缀，例如cc123@alitest.com#001
        /// </summary>
        [JsonPropertyName("operator_prefix")]
        public string OperatorPrefix { get; set; }

        /// <summary>
        /// 商户id，2088121509924973
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
