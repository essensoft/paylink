using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskDirectionalRainscoreQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskDirectionalRainscoreQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 风险解释，即本次风险评分中TOP 3风险因子的代码、名称、解释、风险倍数（JSON格式）。详情请参考<a href="https://doc.open.alipay.com/doc2/detail.htm?treeId=214&articleId=104588&docType=1">风险解释</a>
        /// </summary>
        [JsonPropertyName("infocode")]
        public List<InfoCode> Infocode { get; set; }

        /// <summary>
        /// 风险评分，范围为[0,100]，评分越高风险越大；查询不到，返回默认值为-1
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }

        /// <summary>
        /// 调用订单号
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
