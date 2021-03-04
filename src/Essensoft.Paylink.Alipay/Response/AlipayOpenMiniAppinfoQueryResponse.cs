using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAppinfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 应用信息列表
        /// </summary>
        [JsonPropertyName("app_basic_info_response_list")]
        public List<AppBasicInfoResponse> AppBasicInfoResponseList { get; set; }
    }
}
