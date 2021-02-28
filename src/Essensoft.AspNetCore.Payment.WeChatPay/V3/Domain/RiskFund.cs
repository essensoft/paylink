using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 订单风险金
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_14.shtml">创建支付分订单API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_14.shtml">创建支付分订单API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_15.shtml">查询支付分订单API</a> - 最新更新时间：2020.05.25</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_17.shtml">修改订单金额API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_18.shtml">完结支付分订单API</a> - 最新更新时间：2020.06.02</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_20.shtml">同步服务订单信息API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_21.shtml">确认订单回调通知API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_22.shtml">支付成功回调通知API</a> - 最新更新时间：2020.05.25</para>
    /// </remarks>
    public class RiskFund : WeChatPayObject
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
