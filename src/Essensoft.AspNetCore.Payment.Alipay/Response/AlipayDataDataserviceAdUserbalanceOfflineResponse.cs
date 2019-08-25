using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOfflineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdUserbalanceOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 操作成功投放账户id列表
        /// </summary>
        [JsonProperty("success_user_id_list")]
        public List<string> SuccessUserIdList { get; set; }
    }
}
