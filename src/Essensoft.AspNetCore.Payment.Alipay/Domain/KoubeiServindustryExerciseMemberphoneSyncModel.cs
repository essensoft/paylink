using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberphoneSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseMemberphoneSyncModel : AlipayObject
    {
        /// <summary>
        /// 存量健身会员手机号
        /// </summary>
        [JsonProperty("phone_list")]
        public List<string> PhoneList { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
