using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibCreateModel Data Structure.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibCreateModel : AlipayObject
    {
        /// <summary>
        /// 预算库初始积分数
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 预算库名称
        /// </summary>
        [JsonPropertyName("budget_name")]
        public string BudgetName { get; set; }

        /// <summary>
        /// 积分库对应的签约协议Pid
        /// </summary>
        [JsonPropertyName("contract_pid")]
        public string ContractPid { get; set; }

        /// <summary>
        /// 预算库有效期结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 资金来源，设置预算库的出资来源  对应枚举值：支付宝自有资金--1，支付宝垫资资金--2，外部资金--3，阿里资金--4
        /// </summary>
        [JsonPropertyName("fund_source")]
        public long FundSource { get; set; }

        /// <summary>
        /// 预算库备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 积分库操作渠道枚举,对应值：G--集团操作，S--系统操作，B--小二后台操作，F--商户前台
        /// </summary>
        [JsonPropertyName("operate_channel")]
        public string OperateChannel { get; set; }

        /// <summary>
        /// 预算库创建操作人
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 业务号，用于保证幂等。当业务号发生幂等时返回已创建的积分库信息
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 预算库对应的积分库ID
        /// </summary>
        [JsonPropertyName("point_lib_id")]
        public string PointLibId { get; set; }

        /// <summary>
        /// 预算库有效期起始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 是否使用优惠支付，如需使用会开通汇总记账子卡
        /// </summary>
        [JsonPropertyName("use_settle_tool")]
        public bool UseSettleTool { get; set; }
    }
}
