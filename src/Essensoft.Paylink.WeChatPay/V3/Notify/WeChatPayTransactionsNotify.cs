using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Notify
{
    /// <summary>
    /// 基础支付 - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 支付结果通知
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_5.shtml">JSAPI支付 - 支付通知API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_5.shtml">APP支付 - 支付通知API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_5.shtml">H5支付 - 支付通知API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_5.shtml">Native支付 - 支付通知API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_5.shtml">小程序支付 - 支付通知API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayTransactionsNotify : WeChatPayNotify
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 直连商户申请的公众号或移动应用appid。
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
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
        /// 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一，详见【商户订单号】。
        /// 特殊规则：最小字符长度为6
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 微信支付订单号
        /// </summary>
        /// <remarks>
        /// 微信支付系统生成的订单号。
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        /// <remarks>
        /// 交易类型，枚举值：
        /// JSAPI：公众号支付
        /// NATIVE：扫码支付
        /// APP：APP支付
        /// MICROPAY：付款码支付
        /// MWEB：H5支付
        /// FACEPAY：刷脸支付
        /// <para>示例值：MICROPAY</para>
        /// </remarks>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        /// <remarks>
        /// 交易状态，枚举值：
        /// SUCCESS：支付成功
        /// REFUND：转入退款
        /// NOTPAY：未支付
        /// CLOSED：已关闭
        /// REVOKED：已撤销（付款码支付）
        /// USERPAYING：用户支付中（付款码支付）
        /// PAYERROR：支付失败(其他原因，如银行返回失败)
        /// <para>示例值：SUCCESS</para>
        /// </remarks>
        [JsonPropertyName("trade_state")]
        public string TradeState { get; set; }

        /// <summary>
        /// 交易状态描述
        /// </summary>
        /// <remarks>
        /// 交易状态描述
        /// <para>示例值：支付失败，请重新下单支付</para>
        /// </remarks>
        [JsonPropertyName("trade_state_desc")]
        public string TradeStateDesc { get; set; }

        /// <summary>
        /// 付款银行
        /// </summary>
        /// <remarks>
        /// 银行类型，采用字符串类型的银行标识。
        /// <para>示例值：CMC</para>
        /// </remarks>
        [JsonPropertyName("bank_type")]
        public string BankType { get; set; }

        /// <summary>
        /// 附加数据
        /// </summary>
        /// <remarks>
        /// 附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用
        /// <para>示例值：自定义数据</para>
        /// </remarks>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 支付完成时间
        /// </summary>
        /// <remarks>
        /// 支付完成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// <para>示例值：2018-06-08T10:34:56+08:00</para>
        /// </remarks>
        [JsonPropertyName("success_time")]
        public string SuccessTime { get; set; }

        /// <summary>
        /// 支付者
        /// </summary>
        /// <remarks>
        /// <para>示例值：见请求示例</para>
        /// </remarks>
        [JsonPropertyName("payer")]
        public PayerInfo Payer { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        /// <remarks>
        /// 订单金额信息
        /// </remarks>
        [JsonPropertyName("amount")]
        public Amount Amount { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        /// <remarks>
        /// 支付场景描述
        /// </remarks>
        [JsonPropertyName("scene_info")]
        public SceneInfo SceneInfo { get; set; }

        /// <summary>
        /// 优惠功能
        /// </summary>
        /// <remarks>
        /// 优惠功能，享受优惠时返回该字段。
        /// </remarks>
        [JsonPropertyName("promotion_detail")]
        public List<PromotionDetail> PromotionDetail { get; set; }
    }
}
