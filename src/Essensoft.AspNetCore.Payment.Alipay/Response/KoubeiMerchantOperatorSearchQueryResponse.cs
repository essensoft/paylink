using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorSearchQueryResponse.
    /// </summary>
    public class KoubeiMerchantOperatorSearchQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 根据不同条件查询返回的口碑商家中心操作员列表
        /// </summary>
        [JsonPropertyName("operator_list")]
        public List<OperatorBaseInfo> OperatorList { get; set; }

        /// <summary>
        /// 操作员列表查询结果总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
