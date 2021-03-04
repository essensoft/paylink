using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序基本信息
        /// </summary>
        [JsonPropertyName("base_info_list")]
        public List<MiniAppBaseInfoQueryResponse> BaseInfoList { get; set; }
    }
}
