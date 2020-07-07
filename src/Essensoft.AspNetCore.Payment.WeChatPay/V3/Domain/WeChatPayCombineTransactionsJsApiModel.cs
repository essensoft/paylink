using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 合单下单-JSAPI支付API-请求参数（电商平台、服务商、直连商户）
    /// 最新更新时间：2020.05.21
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/combine/chapter3_2.shtml
    /// </summary>
    public class WeChatPayCombineTransactionsJsApiModel : WeChatPayObject
    {
        /// <summary>
        /// 合单商户appid
        /// 合单发起方的appid。
        /// 示例值：wxd678efh567hg6787
        /// </summary>
        [JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; }

        /// <summary>
        /// 合单商户号
        /// 合单发起方商户号。
        /// 示例值：1900000109
        /// </summary>
        [JsonPropertyName("combine_mchid")]
        public string CombineMchId { get; set; }

        /// <summary>
        /// 合单商户订单号
        /// 合单支付总订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一 。
        /// 示例值：P20150806125346
        /// </summary>
        [JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNo { get; set; }

        /// <summary>
        /// 场景信息
        /// 支付场景描述
        /// </summary>
        [JsonPropertyName("scene_info")]
        public CombineSceneInfo SceneInfo { get; set; }

        /// <summary>
        /// 子单信息
        /// 最多支持子单条数：50
        /// </summary>
        [JsonPropertyName("sub_orders")]
        public List<CombineSubOrderInfo> SubOrders { get; set; }

        /// <summary>
        /// 支付者
        /// 支付者信息
        /// </summary>
        [JsonPropertyName("combine_payer_info")]
        public PayerInfo CombinePayerInfo { get; set; }

        /// <summary>
        /// 交易起始时间
        /// 订单生成时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// 示例值：2019-12-31T15:59:60+08:00
        /// </summary>
        [JsonPropertyName("time_start")]
        public DateTimeOffset TimeStart { get; set; }

        /// <summary>
        /// 交易结束时间
        /// 订单失效时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss表示时分秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日 13点29分35秒。
        /// 示例值：2019-12-31T15:59:60+08:00
        /// </summary>
        [JsonPropertyName("time_expire")]
        public DateTimeOffset TimeExpire { get; set; }

        /// <summary>
        /// 通知地址
        /// 接收微信支付异步通知回调地址，通知url必须为直接可访问的URL，不能携带参数。
        /// 格式: URL
        /// 示例值：https://yourapp.com/notify
        /// </summary>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; }
    }
}
