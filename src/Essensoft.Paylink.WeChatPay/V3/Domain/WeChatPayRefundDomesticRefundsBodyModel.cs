using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 申请退款 - 请求JSON参数
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
    public class WeChatPayRefundDomesticRefundsBodyModel : WeChatPayObject
    {
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
        /// 微信支付订单号
        /// </summary>
        /// <remarks>
        /// 原支付交易对应的微信订单号。
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
        /// 商户退款单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部的退款单号，商户系统内部唯一，只能是数字、大小写字母_-|*@ ，同一退款单号多次请求只退一笔。
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        /// <remarks>
        /// 若商户传入，会在下发给用户的退款消息中体现退款原因。
        /// <para>示例值：商品已售完</para>
        /// </remarks>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退款结果回调url
        /// </summary>
        /// <remarks>
        /// 异步接收微信支付退款结果通知的回调地址，通知url必须为外网可访问的url，不能携带参数。 如果参数中传了notify_url，则商户平台上配置的回调地址将不会生效，优先回调当前传的这个地址。
        /// <para>示例值：https://weixin.qq.com</para>
        /// </remarks>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 退款资金来源
        /// </summary>
        /// <remarks>
        /// 若传递此参数则使用对应的资金账户退款，否则默认使用未结算资金退款（仅对老资金流商户适用）。
        /// 枚举值：
        /// AVAILABLE：可用余额账户
        /// <para>示例值：AVAILABLE</para>
        /// </remarks>
        [JsonPropertyName("funds_account")]
        public string FundsAccount { get; set; }

        /// <summary>
        /// 金额信息
        /// </summary>
        /// <remarks>
        /// 订单金额信息。
        /// </remarks>
        [JsonPropertyName("amount")]
        public RefundAmount Amount { get; set; }

        /// <summary>
        /// 退款商品
        /// </summary>
        /// <remarks>
        /// 指定商品退款需要传此参数，其他场景无需传递。
        /// </remarks>
        [JsonPropertyName("goods_detail")]
        public List<RefundGoodsDetail> GoodsDetail { get; set; }
    }
}
