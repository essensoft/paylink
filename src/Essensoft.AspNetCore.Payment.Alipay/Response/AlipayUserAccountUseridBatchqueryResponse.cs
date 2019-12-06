using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        [JsonPropertyName("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
