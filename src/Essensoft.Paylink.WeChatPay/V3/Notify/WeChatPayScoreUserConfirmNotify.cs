using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Notify
{
    /// <summary>
    /// 微信支付分 - 确认订单回调通知
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_21.shtml">微信支付分 - 确认订单回调通知API</a> - 最新更新时间：2020.03.05</para>
    /// </remarks>
    public class WeChatPayScoreUserConfirmNotify : WeChatPayNotify
    {
        /// <summary>
        /// 公众账号ID
        /// </summary>
        /// <remarks>
        /// 调用授权服务接口提交的公众账号ID。
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        /// <remarks>
        /// 调用授权服务接口提交的商户号。
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户服务订单号
        /// </summary>
        /// <remarks>
        /// 调用接口提交的商户服务订单号。
        /// <para>示例值：1234323JKHDFE1243252</para>
        /// </remarks>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        /// <remarks>
        /// 调用授权服务接口提交的服务ID。
        /// <para>示例值：500001</para>
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        /// <remarks>
        /// 微信用户在商户对应appid下的唯一标识。
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
        /// </remarks>
        [JsonPropertyName("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 服务订单状态
        /// </summary>
        /// <remarks>
        /// 表示当前单据状态。
        /// 枚举值：
        /// 1、DOING：服务订单进行中
        /// <para>示例值：DOING</para>
        /// </remarks>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 订单状态说明
        /// </summary>
        /// <remarks>
        /// 对服务订单"进行中"状态的附加说明。
        /// 1、USER_CONFIRM：用户确认
        /// <para>示例值：USER_CONFIRM</para>
        /// </remarks>
        [JsonPropertyName("state_description")]
        public string StateDescription { get; set; }

        /// <summary>
        /// 商户收款总金额
        /// </summary>
        /// <remarks>
        /// 总金额，大于等于0的数字，单位为分，只能为整数，详见支付金额。
        /// 此参数需满足：总金额=后付费项目金额之和-后付费商户优惠项目金额之和，且小于等于订单风险金额。取消订单时，该字段必须为0。
        /// <para>示例值：40000</para>
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public long? TotalAmount { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        /// <remarks>
        /// 服务信息，用于介绍本订单所提供的服务
        /// 不超过20个字符，超出报错处理。
        /// <para>示例值：嗨客餐厅用餐</para>
        /// </remarks>
        [JsonPropertyName("service_introduction")]
        public string ServiceIntroduction { get; set; }

        /// <summary>
        /// 后付费项目
        /// </summary>
        /// <remarks>
        /// 后付费项目列表，最多包含100条付费项目。
        /// </remarks>
        [JsonPropertyName("post_payments")]
        public List<PostPayment> PostPayments { get; set; }

        /// <summary>
        /// 后付费商户优惠
        /// </summary>
        /// <remarks>
        /// 后付费商户优惠列表，最多包含30条商户优惠。
        /// </remarks>
        [JsonPropertyName("post_discounts")]
        public List<PostDiscount> PostDiscounts { get; set; }

        /// <summary>
        /// 订单风险金
        /// </summary>
        /// <remarks>
        /// 订单风险金信息
        /// </remarks>
        [JsonPropertyName("risk_fund")]
        public RiskFund RiskFund { get; set; }

        /// <summary>
        /// 服务时间段
        /// </summary>
        /// <remarks>
        /// 服务使用时间范围
        /// </remarks>
        [JsonPropertyName("time_range")]
        public TimeRange TimeRange { get; set; }

        /// <summary>
        /// 服务位置
        /// </summary>
        /// <remarks>
        /// 服务使用位置信息。
        /// </remarks>
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 商户数据包
        /// </summary>
        /// <remarks>
        /// 商户数据包可存放本订单所需信息，需要先urlencode后传入。
        /// 当商户数据包总长度超出256字符时，报错处理。
        /// <para>示例值：attach</para>
        /// </remarks>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 微信支付服务订单号
        /// </summary>
        /// <remarks>
        /// 微信支付服务订单号，每个微信支付服务订单号与商户号下对应的商户服务订单号一一对应。
        /// <para>示例值：15646546545165651651</para>
        /// </remarks>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否需要收款
        /// </summary>
        /// <remarks>
        /// 是否需要收款。
        /// true：微信支付分代收款
        /// false：无需微信支付分代收款
        /// <para>示例值：true</para>
        /// </remarks>
        [JsonPropertyName("need_collection")]
        public bool NeedCollection { get; set; }
    }
}
