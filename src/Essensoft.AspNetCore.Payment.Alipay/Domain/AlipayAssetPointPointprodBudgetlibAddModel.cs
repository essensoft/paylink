using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointPointprodBudgetlibAddModel : AlipayObject
    {
        /// <summary>
        /// 预算库追加的积分数
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 预算库编码
        /// </summary>
        [JsonProperty("budget_code")]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 积分库对应的签约协议Pid
        /// </summary>
        [JsonProperty("contract_pid")]
        public string ContractPid { get; set; }

        /// <summary>
        /// 预算库追加备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 预算库追加操作人
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 业务号，用于保证幂等
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 预算库对应的积分库ID
        /// </summary>
        [JsonProperty("point_lib_id")]
        public string PointLibId { get; set; }
    }
}
