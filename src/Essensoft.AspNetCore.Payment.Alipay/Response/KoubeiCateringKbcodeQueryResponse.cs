using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringKbcodeQueryResponse.
    /// </summary>
    public class KoubeiCateringKbcodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑码信息列表
        /// </summary>
        [JsonPropertyName("code_info_list")]
        public List<KbCodeInfoVO> CodeInfoList { get; set; }

        /// <summary>
        /// 当前页码（大于0的整数）
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页返回的记录数（0~100的整数）
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 口碑码总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
