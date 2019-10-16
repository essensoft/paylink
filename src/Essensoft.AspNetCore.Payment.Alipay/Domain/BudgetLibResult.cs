using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BudgetLibResult Data Structure.
    /// </summary>
    [Serializable]
    public class BudgetLibResult : AlipayObject
    {
        /// <summary>
        /// 预算阀值，低于这个数据的时候才预警
        /// </summary>
        [JsonProperty("alert_money")]
        public string AlertMoney { get; set; }

        /// <summary>
        /// 预算库预警标记，Y-预警；N和空位非预警
        /// </summary>
        [JsonProperty("alert_status")]
        public string AlertStatus { get; set; }

        /// <summary>
        /// Y-自动延期 N-非自动延期
        /// </summary>
        [JsonProperty("auto_delay")]
        public string AutoDelay { get; set; }

        /// <summary>
        /// 积分库余额
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 预算库编码
        /// </summary>
        [JsonProperty("budget_code")]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 预算库名称
        /// </summary>
        [JsonProperty("budget_name")]
        public string BudgetName { get; set; }

        /// <summary>
        /// 签约PID
        /// </summary>
        [JsonProperty("contract_pid")]
        public string ContractPid { get; set; }

        /// <summary>
        /// 预算库创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否延期告警 1-告警 0-不告警
        /// </summary>
        [JsonProperty("delay_notice")]
        public string DelayNotice { get; set; }

        /// <summary>
        /// 预算库失效时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 资金来源
        /// </summary>
        [JsonProperty("fund_source")]
        public string FundSource { get; set; }

        /// <summary>
        /// 预算库备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作来源：F-商户前台,B-后台小二
        /// </summary>
        [JsonProperty("operate_channel")]
        public string OperateChannel { get; set; }

        /// <summary>
        /// 最后操作人
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 积分库id
        /// </summary>
        [JsonProperty("point_lib_id")]
        public string PointLibId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 预算库生效时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 状态，有效 暂停 禁用
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 预算库状态，E有效，D暂停，F禁用
        /// </summary>
        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 预算总数额：预算库创建+增容-减容
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }
    }
}
