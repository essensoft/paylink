using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserloginstatusQueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserloginstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 登录的sessionId；session_id或sub_user_id必须传一个
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 子账号id；session_id或sub_user_id必须传一个
        /// </summary>
        [JsonPropertyName("sub_user_id")]
        public string SubUserId { get; set; }
    }
}
