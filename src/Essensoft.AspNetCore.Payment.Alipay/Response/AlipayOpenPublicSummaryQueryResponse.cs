using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicSummaryQueryResponse.
    /// </summary>
    public class AlipayOpenPublicSummaryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 生活号摘要信息列表
        /// </summary>
        [JsonPropertyName("public_info_list")]
        public List<SummaryInfo> PublicInfoList { get; set; }
    }
}
