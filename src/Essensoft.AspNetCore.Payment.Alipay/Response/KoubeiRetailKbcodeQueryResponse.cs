using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailKbcodeQueryResponse.
    /// </summary>
    public class KoubeiRetailKbcodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑码信息列表
        /// </summary>
        [JsonPropertyName("code_info_list")]
        public List<RetailKbcodeQueryVo> CodeInfoList { get; set; }

        /// <summary>
        /// 口碑码总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
