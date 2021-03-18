using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Notify
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 退款结果通知
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_11.shtml">基础支付 - JSAPI支付 - 退款结果通知API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_11.shtml">基础支付 - APP支付 - 退款结果通知API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_11.shtml">基础支付 - H5支付 - 退款结果通知API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_11.shtml">基础支付 - Native支付 - 退款结果通知API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_11.shtml">基础支付 - 小程序支付 - 退款结果通知API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_11.shtml">基础支付(服务商) - JSAPI支付 - 退款结果通知API</a> - 最新更新时间：2020.04.01</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_11.shtml">基础支付(服务商) - APP支付 - 退款结果通知API</a> - 最新更新时间：2020.04.01</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_11.shtml">基础支付(服务商) - H5支付 - 退款结果通知API</a> - 最新更新时间：2020.04.01</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_11.shtml">基础支付(服务商) - Native支付 - 退款结果通知API</a> - 最新更新时间：2020.04.01</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_11.shtml">基础支付(服务商) - 小程序支付 - 退款结果通知API</a> - 最新更新时间：2020.04.01</para>
    /// </remarks>
    public class WeChatPayRefundDomesticRefundsNotify : WeChatPayNotify
    {
        /// <summary>
        /// 服务商户号
        /// </summary>
        /// <remarks>
        /// 服务商户号，由微信支付生成并下发。
        /// <para>示例值：1900000100</para>
        /// </remarks>
        [JsonPropertyName("sp_mchid")]
        public string SpMchId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 子商户的商户号，由微信支付生成并下发。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 直连商户号
        /// </summary>
        /// <remarks>
        /// 直连商户的商户号，由微信支付生成并下发。
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 返回的商户订单号
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        /// <remarks>
        /// 微信支付订单号
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户退款单号
        /// </summary>
        /// <remarks>
        /// 商户退款单号
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 微信退款单号
        /// </summary>
        /// <remarks>
        /// 微信退款单号
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        /// <remarks>
        /// 退款状态，枚举值：
        /// SUCCESS：退款成功
        /// CLOSE：退款关闭
        /// ABNORMAL：退款异常，退款到银行发现用户的卡作废或者冻结了，导致原路退款银行卡失败，可前往【服务商平台—>交易中心】，手动处理此笔退款
        /// <para>示例值：SUCCESS</para>
        /// </remarks>
        [JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款成功时间
        /// </summary>
        /// <remarks>
        /// 1、退款成功时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日13点29分35秒。
        /// 2、当退款状态为退款成功时返回此参数。
        /// <para>示例值：2018-06-08T10:34:56+08:00</para>
        /// </remarks>
        [JsonPropertyName("success_time")]
        public string SuccessTime { get; set; }

        /// <summary>
        /// 退款入账账户
        /// </summary>
        /// <remarks>
        /// 取当前退款单的退款入账方。
        /// 1、退回银行卡：{银行名称}{卡类型}{卡尾号}
        /// 2、退回支付用户零钱: 支付用户零钱
        /// 3、退还商户: 商户基本账户、商户结算银行账户
        /// 4、退回支付用户零钱通：支付用户零钱通
        /// <para>示例值：招商银行信用卡0403</para>
        /// </remarks>
        [JsonPropertyName("user_received_account")]
        public string UserReceivedAccount { get; set; }

        /// <summary>
        /// 金额信息
        /// </summary>
        /// <remarks>
        /// 金额信息
        /// </remarks>
        [JsonPropertyName("amount")]
        public RefundNotifyAmount Amount { get; set; }
    }
}
