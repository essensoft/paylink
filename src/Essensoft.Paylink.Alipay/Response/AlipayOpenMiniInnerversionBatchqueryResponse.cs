using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序版本信息
        /// </summary>
        [JsonPropertyName("version_info_list")]
        public List<MiniAppVersionInfo> VersionInfoList { get; set; }
    }
}
