using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibQueryResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 集分宝预算库实体模型，包含预算库编码，余额等
        /// </summary>
        [JsonPropertyName("result")]
        public BudgetLibResult Result { get; set; }
    }
}
