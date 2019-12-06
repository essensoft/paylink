using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibReturnModel Data Structure.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibReturnModel : AlipayObject
    {
        /// <summary>
        /// 预算回收数
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 积分库编码
        /// </summary>
        [JsonPropertyName("budget_code")]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 积分库对应的签约协议Pid
        /// </summary>
        [JsonPropertyName("contract_pid")]
        public string ContractPid { get; set; }

        /// <summary>
        /// 预算库预算回收操作人
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 业务号，用于幂等
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 预算库对应的积分库ID
        /// </summary>
        [JsonPropertyName("point_lib_id")]
        public string PointLibId { get; set; }
    }
}
