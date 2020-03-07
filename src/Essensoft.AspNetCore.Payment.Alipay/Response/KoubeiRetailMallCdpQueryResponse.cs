using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailMallCdpQueryResponse.
    /// </summary>
    public class KoubeiRetailMallCdpQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 投放内容列表
        /// </summary>
        [JsonPropertyName("cdp_content_list")]
        public List<CdpDisplayContent> CdpContentList { get; set; }
    }
}
