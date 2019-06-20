using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserloginstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbcloudSubuserloginstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 登录的sessionId；session_id或sub_user_id必须传一个
        /// </summary>
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 子账号id；session_id或sub_user_id必须传一个
        /// </summary>
        [JsonProperty("sub_user_id")]
        public string SubUserId { get; set; }
    }
}
