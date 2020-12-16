using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountQueryResponse.
    /// </summary>
    public class AlipayBossFncSubaccountAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询子户结果信息
        /// </summary>
        [JsonPropertyName("result_set")]
        public SubAccountInfoDTO ResultSet { get; set; }
    }
}
