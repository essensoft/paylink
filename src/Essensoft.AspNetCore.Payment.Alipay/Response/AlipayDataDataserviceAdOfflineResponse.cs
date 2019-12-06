using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdOfflineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 操作成功外部ID列表
        /// </summary>
        [JsonPropertyName("success_id_list")]
        public List<string> SuccessIdList { get; set; }
    }
}
