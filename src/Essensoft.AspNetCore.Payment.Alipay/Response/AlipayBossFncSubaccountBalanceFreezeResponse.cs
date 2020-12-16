using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncSubaccountBalanceFreezeResponse.
    /// </summary>
    public class AlipayBossFncSubaccountBalanceFreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 子户余额冻结结果open api数据传输对象
        /// </summary>
        [JsonPropertyName("result_set")]
        public SubAccountBalanceFreezeResultOpenApiDTO ResultSet { get; set; }
    }
}
