using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOfflineModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdUserbalanceOfflineModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 投放账户id列表
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
