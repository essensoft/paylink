using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 申请退款 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_9.shtml">基础支付 - JSAPI支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_9.shtml">基础支付 - APP支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_9.shtml">基础支付 - H5支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_9.shtml">基础支付 - Native支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_9.shtml">基础支付 - 小程序支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_9.shtml">基础支付(服务商) - JSAPI支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_9.shtml">基础支付(服务商) - APP支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_9.shtml">基础支付(服务商) - H5支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_9.shtml">基础支付(服务商) - Native支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_9.shtml">基础支付(服务商) - 小程序支付 - 申请退款API</a> - 最新更新时间：2021.01.15</para>
    /// </remarks>
    public class WeChatPayRefundDomesticRefundsResponse : WeChatPayResponse
    {
        /// <summary>
        /// 微信支付退款号
        /// </summary>
        /// <remarks>
        /// 微信支付退款号。
        /// <para>示例值：50000000382019052709732678859</para>
        /// </remarks>
        [JsonPropertyName("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 商户退款单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部的退款单号，商户系统内部唯一，只能是数字、大小写字母_-|*@ ，同一退款单号多次请求只退一笔。
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 微信支付订单号
        /// </summary>
        /// <remarks>
        /// 微信支付交易订单号。
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 原支付交易对应的商户订单号。
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款渠道
        /// </summary>
        /// <remarks>
        /// 枚举值：
        /// ORIGINAL：原路退款
        /// BALANCE：退回到余额
        /// OTHER_BALANCE：原账户异常退到其他余额账户
        /// OTHER_BANKCARD：原银行卡异常退到其他银行卡
        /// <para>示例值：ORIGINAL</para>
        /// </remarks>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 退款入账账户
        /// </summary>
        /// <remarks>
        /// 取当前退款单的退款入账方，有以下几种情况：
        /// 1）退回银行卡：{银行名称}{卡类型}{卡尾号}
        /// 2）退回支付用户零钱: 支付用户零钱
        /// 3）退还商户: 商户基本账户商户结算银行账户
        /// 4）退回支付用户零钱通: 支付用户零钱通。
        /// <para>示例值：招商银行信用卡0403</para>
        /// </remarks>
        [JsonPropertyName("user_received_account")]
        public string UserReceivedAccount { get; set; }

        /// <summary>
        /// 退款成功时间
        /// </summary>
        /// <remarks>
        /// 退款成功时间，当退款状态为退款成功时有返回。
        /// <para>示例值：2020-12-01T16:18:12+08:00</para>
        /// </remarks>
        [JsonPropertyName("success_time")]
        public string SuccessTime { get; set; }

        /// <summary>
        /// 退款创建时间
        /// </summary>
        /// <remarks>
        /// 退款受理时间。
        /// <para>示例值：2020-12-01T16:18:12+08:00</para>
        /// </remarks>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        /// <remarks>
        /// 退款到银行发现用户的卡作废或者冻结了，导致原路退款银行卡失败，可前往商户平台-交易中心，手动处理此笔退款。
        /// 枚举值：
        /// SUCCESS：退款成功
        /// CLOSED：退款关闭
        /// PROCESSING：退款处理中
        /// ABNORMAL：退款异常
        /// <para>示例值：SUCCESS</para>
        /// </remarks>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 资金账户
        /// </summary>
        /// <remarks>
        /// 退款所使用资金对应的资金账户类型。 枚举值：
        /// UNSETTLED : 未结算资金
        /// AVAILABLE : 可用余额
        /// UNAVAILABLE : 不可用余额
        /// OPERATION : 运营户
        /// <para>示例值：UNSETTLED</para>
        /// </remarks>
        [JsonPropertyName("funds_account")]
        public string FundsAccount { get; set; }

        /// <summary>
        /// 金额信息
        /// </summary>
        /// <remarks>
        /// 金额详细信息。
        /// </remarks>
        [JsonPropertyName("amount")]
        public RefundAmountResponse Amount { get; set; }

        /// <summary>
        /// 优惠退款信息
        /// </summary>
        /// <remarks>
        /// 优惠退款信息。
        /// </remarks>
        [JsonPropertyName("promotion_detail")]
        public List<RefundPromotionDetail> PromotionDetail { get; set; }
    }
}
