using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ConditionItemPattern Data Structure.
    /// </summary>
    public class ConditionItemPattern : AlipayObject
    {
        /// <summary>
        /// 智慧餐厅用户规则操作符，EQ表示相等，GT表示大于，GTEQ表示大于等于，LT表示小于，LTEQ表示小于等于
        /// </summary>
        [JsonPropertyName("logical_operator")]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// 操作对应的值; 值>0
        /// </summary>
        [JsonPropertyName("operation_value")]
        public string OperationValue { get; set; }

        /// <summary>
        /// 人群规则项：目前共支持九种标记规则，分别是:用户在商家下的交易金额(30，60，90，180，365)TRADE_AMT(单位：YUAN)   、用户在商家下的交易笔数(30，60，90，180，365)TRADE_CNT(单位：COUNT),   用户在商家下的笔单价(30，60，90，180，365)PCT_AMT(单位：YUAN),   用户在商家下的领券量(30，60，90，180，365)APPLY_VOUCHER_CNT((单位：TICKET),   用户在商家下的核券量(30，60，90，180，365) VERIFY_VOUCHER_CNT(单位：TICKET) 、用户在商家下的最后一次消费距离当前天数 LAST_PAY_DATE(单位：DAY)、用户在商家下最后一次交易金额 LAST_PAY_AMT(单位：YUAN)、用户家庭位置距离该PID下最近门店的距离HOME_SHOP_DIS((单位：KM)、用户工作位置距离该PID下最近门店的距离WORK_SHOP_DIS(单位：KM)
        /// </summary>
        [JsonPropertyName("operator_rule")]
        public string OperatorRule { get; set; }

        /// <summary>
        /// 描述周期字段；30，60，90，180，365；周期字段创建规则：消费金额，消费笔数，笔单价，领券数，核销券数时必填
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 单位描述，DAY("DAY", "天"), KM("KM", "千米"),  COUNT("COUNT","笔数")  TICKET("TICKET","券") YUAN("YUAN","元")
        /// </summary>
        [JsonPropertyName("rule_unit")]
        public string RuleUnit { get; set; }
    }
}
