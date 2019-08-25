using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOnlineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdUserbalanceOnlineResponse : AlipayResponse
    {
        /// <summary>
        /// 操作成功投放账户id列表
        /// </summary>
        [JsonProperty("success_user_id_list")]
        public List<long> SuccessUserIdList { get; set; }
    }
}
