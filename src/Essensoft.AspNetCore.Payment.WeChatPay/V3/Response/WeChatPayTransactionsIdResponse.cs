using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 查询订单API-微信支付订单号查询-返回参数
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_5.shtml
    /// </summary>
    public class WeChatPayTransactionsIdResponse : WeChatPayResponse
    {
        /// <summary>
        /// 公众号ID
        /// 直连商户申请的公众号或移动应用appid。
        /// 示例值：wxd678efh567hg6787
        /// </summary>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 直连商户号
        /// 直连商户的商户号，由微信支付生成并下发。
        /// 示例值：1230000109
        /// </summary>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一，详见【商户订单号】。
        /// 特殊规则：最小字符长度为6
        /// 示例值：1217752501201407033233368018
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 微信支付订单号
        /// 微信支付系统生成的订单号。
        /// 示例值：1217752501201407033233368018
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 交易类型
        /// 交易类型，枚举值：
        /// JSAPI：公众号支付
        /// NATIVE：扫码支付
        /// APP：APP支付
        /// MICROPAY：付款码支付
        /// MWEB：H5支付
        /// FACEPAY：刷脸支付
        /// 示例值：MICROPAY
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 交易状态
        /// 交易状态，枚举值：
        /// SUCCESS：支付成功
        /// REFUND：转入退款
        /// NOTPAY：未支付
        /// CLOSED：已关闭
        /// REVOKED：已撤销（付款码支付）
        /// USERPAYING：用户支付中（付款码支付）
        /// PAYERROR：支付失败(其他原因，如银行返回失败)
        /// 示例值：SUCCESS
        /// </summary>
        [JsonPropertyName("trade_state")]
        public string TradeState { get; set; }

        /// <summary>
        /// 交易状态描述
        /// 交易状态描述
        /// 示例值：支付失败，请重新下单支付
        /// </summary>
        [JsonPropertyName("trade_state_desc")]
        public string TradeStateDesc { get; set; }

        /// <summary>
        /// 付款银行
        /// 银行类型，采用字符串类型的银行标识。
        /// 示例值：CMC
        /// </summary>
        [JsonPropertyName("bank_type")]
        public string BankType { get; set; }

        /// <summary>
        /// 附加数据
        /// 附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用
        /// 示例值：自定义数据
        /// </summary>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 支付完成时间
        /// 支付完成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// 示例值：2018-06-08T10:34:56+08:00
        /// </summary>
        [JsonPropertyName("success_time")]
        public DateTimeOffset SuccessTime { get; set; }

        /// <summary>
        /// 支付者
        /// 示例值：见请求示例
        /// </summary>
        [JsonPropertyName("combine_payer_info")]
        public PayerInfo CombinePayerInfo { get; set; }

        /// <summary>
        /// 订单金额
        /// 订单金额信息
        /// </summary>
        [JsonPropertyName("amount")]
        public AmountResponse Amount { get; set; }

        /// <summary>
        /// 场景信息
        /// 支付场景描述
        /// </summary>
        [JsonPropertyName("scene_info")]
        public SceneInfo SceneInfo { get; set; }

        /// <summary>
        /// 优惠功能
        /// 优惠功能，享受优惠时返回该字段。
        /// </summary>
        [JsonPropertyName("promotion_detail")]
        public List<PromotionDetail> PromotionDetail { get; set; }
    }
}
