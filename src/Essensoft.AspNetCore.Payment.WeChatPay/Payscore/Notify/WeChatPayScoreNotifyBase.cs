using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Notify
{
    public abstract class WeChatPayScoreNotifyBase : WeChatPayNotify
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public virtual string OutOrderNo { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        [JsonPropertyName("appid")]
        public virtual string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonPropertyName("mchid")]
        public virtual string MchId { get; set; }

        /// <summary>
        /// 支付分服务ID
        /// </summary>
        [JsonPropertyName("service_id")]
        public virtual string ServiceId { get; set; }

        /// <summary>
        /// 微信用户在商户对应appid下的唯一标识
        /// </summary>
        [JsonPropertyName("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 服务订单状态
        /// </summary>
        /// <remarks>
        /// 表示当前单据状态。
        ///  枚举值：
        ///  DOING：服务订单进行中
        ///  DONE：服务订单完成
        ///  示例值：DONE
        /// </remarks>
        [JsonPropertyName("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// 订单状态说明
        /// </summary>
        /// <remarks>
        /// 对服务订单"进行中"状态的附加说明。
        /// 1、USER_CONFIRM：用户确认
        /// 2、MCH_COMPLETE：商户完结
        /// 示例值：MCH_COMPLETE
        /// </remarks>
        [JsonPropertyName("state_description")]
        public virtual string StateDescription { get; set; }

        /// <summary>
        /// 商户收款总金额
        /// </summary>
        /// <remarks>
        /// 总金额，大于等于0的数字，单位为分，只能为整数，详见支付金额。
        /// 此参数需满足：总金额=后付费项目金额之和-后付费商户优惠项目金额之和，且小于等于订单风险金额。取消订单时，该字段必须为0。
        /// 示例值：40000
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public virtual long TotalAmount { get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        /// <remarks>
        /// 服务信息，用于介绍本订单所提供的服务 ，当参数长度超过20个字符时，报错处理。
        /// 示例值：某某酒店
        /// </remarks>
        [JsonPropertyName("service_introduction")]
        public virtual string ServiceIntroduction { get; set; }

        /// <summary>
        /// 后付费项目
        /// </summary>
        /// <remarks>
        /// 后付费项目列表，最多包含100条付费项目。
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("post_payments")]
        public virtual List<PostPayment> PostPayments { get; set; }

        /// <summary>
        /// 后付费商户优惠
        /// </summary>
        /// <remarks>
        /// 后付费商户优惠列表，最多包含30条商户优惠。
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("post_discounts")]
        public virtual List<ModifyPostDiscount> PostDiscounts { get; set; }

        /// <summary>
        /// 服务时间范围
        /// </summary>
        [JsonPropertyName("time_range")]
        public virtual TimeRange TimeRange { get; set; }

        /// <summary>
        /// 服务位置信息
        /// 如果传入，用户侧则显示此参数。
        /// </summary>
        [JsonPropertyName("location")]
        public virtual Location Location { get; set; }

        /// <summary>
        /// 订单风险金信息
        /// </summary>
        [JsonPropertyName("risk_fund")]
        public virtual RiskFund RiskFund { get; set; }

        /// <summary>
        /// 商户数据包
        /// </summary>
        /// <remarks>
        /// 商户数据包可存放本订单所需信息，需要先urlencode后传入。 当商户数据包总长度超出256字符时，报错处理。
        /// 示例值：Easdfowealsdkjfnlaksjdlfkwqoi&wl3l2sald
        /// </remarks>
        [JsonPropertyName("attach")]
        public virtual string Attach { get; set; }

        /// <summary>
        /// 微信支付服务订单号
        /// </summary>
        /// <remarks>
        /// 微信支付服务订单号，每个微信支付服务订单号与商户号下对应的商户服务订单号一一对应。
        /// 示例值：15646546545165651651
        /// </remarks>
        [JsonPropertyName("order_id")]
        public virtual string OrderId { get; set; }

        /// <summary>
        /// 是否需要收款
        /// </summary>
        /// <remarks>
        /// 是否需要收款，非0元完结后返回
        /// true：微信支付分代收款
        /// false：无需微信支付分代收款
        /// 示例值：true
        /// </remarks>
        [JsonPropertyName("need_collection")]
        public virtual bool NeedCollection { get; set; }
    }
}
