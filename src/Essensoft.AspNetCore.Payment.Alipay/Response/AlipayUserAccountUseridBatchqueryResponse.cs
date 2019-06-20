using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAccountUseridBatchqueryResponse.
    /// </summary>
    public class AlipayUserAccountUseridBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        [JsonProperty("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
