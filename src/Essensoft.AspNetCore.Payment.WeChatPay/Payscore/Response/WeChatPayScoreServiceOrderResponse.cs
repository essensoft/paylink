using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response
{
    /// <summary>
    ///  微信支付分 - 创建支付分订单
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_14.shtml">创建支付分订单API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderResponse : WeChatPayScoreResponseBase
    {
        /// <summary>
        /// 服务信息
        /// </summary>
        /// <remarks>
        /// 服务信息，用于介绍本订单所提供的服务 ，当参数长度超过20个字符时，报错处理。
        /// 示例值：某某酒店
        /// </remarks>
        [JsonPropertyName("service_introduction")]
        public string ServiceIntroduction { get; set; }

        /// <summary>
        /// 服务订单状态
        /// </summary>
        /// <remarks>
        /// 表示当前单据状态。
        ///  枚举值：
        ///  1、CREATED：商户已创建服务订单
        ///  2、DOING：服务订单进行中
        ///  3、DONE：服务订单完成
        ///  4、REVOKED：商户取消服务订单
        ///  5、EXPIRED：服务订单已失效
        ///  示例值：CREATED
        /// </remarks>
        [JsonPropertyName("state")]
        public string State { get; set; }

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
        public string StateDescription { get; set; }

        /// <summary>
        /// 后付费项目
        /// </summary>
        /// <remarks>
        /// 后付费项目列表，最多包含100条付费项目。
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("post_payments")]
        public List<PostPayment> PostPayments { get; set; }

        /// <summary>
        /// 后付费商户优惠
        /// </summary>
        /// <remarks>
        /// 后付费商户优惠列表，最多包含30条商户优惠。
        /// 如果传入，用户侧则显示此参数。
        /// </remarks>
        [JsonPropertyName("post_discounts")]
        public List<PostDiscount> PostDiscounts { get; set; }

        /// <summary>
        /// 服务时间范围
        /// </summary>
        [JsonPropertyName("time_range")]
        public TimeRange TimeRange { get; set; }

        /// <summary>
        /// 服务位置信息
        /// 如果传入，用户侧则显示此参数。
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 订单风险金信息
        /// </summary>
        [JsonPropertyName("risk_fund")]
        public RiskFund RiskFund { get; set; }

        /// <summary>
        /// 商户数据包
        /// </summary>
        /// <remarks>
        /// 商户数据包可存放本订单所需信息，需要先urlencode后传入。 当商户数据包总长度超出256字符时，报错处理。
        /// 示例值：Easdfowealsdkjfnlaksjdlfkwqoi&wl3l2sald
        /// </remarks>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 商户回调地址
        /// </summary>
        /// <remarks>
        /// 商户接收用户确认订单和付款成功回调通知的地址。
        /// 示例值：https://api.test.com
        /// </remarks>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 微信支付服务订单号
        /// </summary>
        /// <remarks>
        /// 微信支付服务订单号，每个微信支付服务订单号与商户号下对应的商户服务订单号一一对应。
        /// 示例值：15646546545165651651
        /// </remarks>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 跳转微信侧小程序订单数据
        /// </summary>
        /// <remarks>
        /// 用户跳转到微信侧小程序订单数据，需确认模式特有API中调起支付分-确认订单传入。该数据一小时内有效。
        /// 示例值：DJIOSQPYWDxsjdldeuwhdodwxasd_dDiodnwjh9we
        /// </remarks>
        [JsonPropertyName("package")]
        public string Package { get; set; }
    }
}
