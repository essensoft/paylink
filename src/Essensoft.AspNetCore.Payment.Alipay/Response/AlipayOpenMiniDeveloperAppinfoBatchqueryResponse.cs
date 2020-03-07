using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniDeveloperAppinfoBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniDeveloperAppinfoBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 多端应用信息
        /// </summary>
        [JsonPropertyName("app_base_info_list")]
        public List<MiniAppBaseInfoQueryResponse> AppBaseInfoList { get; set; }
    }
}
