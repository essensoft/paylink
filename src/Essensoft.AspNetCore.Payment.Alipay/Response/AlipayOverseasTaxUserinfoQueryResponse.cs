using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTaxUserinfoQueryResponse.
    /// </summary>
    public class AlipayOverseasTaxUserinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户Id:蚂蚁统一会员ID,唯一
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名:用户真实名称
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
