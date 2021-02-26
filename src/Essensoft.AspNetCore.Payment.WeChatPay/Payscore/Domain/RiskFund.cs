using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    /// 订单风险金
    /// </summary>
    public class RiskFund
    {
        /// <summary>
        /// 风险金名称       
        /// </summary>
        /// <remarks>
        /// 枚举值：
        ///【先免模式】（评估不通过可交押金）可填名称为
        /// DEPOSIT：押金
        /// ADVANCE：预付款
        /// CASH_DEPOSIT：保证金
        ///【先享模式】（评估不通过不可使用服务）可填名称为
        /// ESTIMATE_ORDER_COST：预估订单费用
        /// 示例值：DEPOSIT
        /// </remarks>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 风险金额 
        /// </summary>
        /// <remarks>
        /// 1、数字，必须>0（单位分）。
        /// 2、风险金额≤每个服务ID的风险金额上限。
        /// 3、当商户优惠字段为空时，付费项目总金额≤服务ID的风险金额上限 （未填写金额的付费项目，视为该付费项目金额为0）。
        /// 4、完结金额可大于、小于或等于风险金额。
        /// 示例值：10000     
        /// </remarks>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 风险说明      
        /// </summary>
        /// <remarks>
        /// 文字，不超过30个字。
        /// 示例值：就餐的预估费用
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
