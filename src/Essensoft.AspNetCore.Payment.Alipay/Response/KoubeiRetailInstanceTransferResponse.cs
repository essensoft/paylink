using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailInstanceTransferResponse.
    /// </summary>
    public class KoubeiRetailInstanceTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 请求的id信息
        /// </summary>
        [JsonPropertyName("instance_id_list")]
        public List<string> InstanceIdList { get; set; }
    }
}
