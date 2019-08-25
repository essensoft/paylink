using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOnlineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdUserbalanceOnlineModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonProperty("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 投放账户id列表
        /// </summary>
        [JsonProperty("user_id_list")]
        public List<long> UserIdList { get; set; }
    }
}
