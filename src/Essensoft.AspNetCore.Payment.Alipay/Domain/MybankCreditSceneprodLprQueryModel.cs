using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodLprQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodLprQueryModel : AlipayObject
    {
        /// <summary>
        /// 贷款方案上贷款年利率为16.2%，则查询基于LPR基准利率浮动数据时，参数为0.162
        /// </summary>
        [JsonPropertyName("loan_rate")]
        public string LoanRate { get; set; }
    }
}
