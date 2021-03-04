using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付 - JSAPI支付、小程序支付 - 统一下单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_1.shtml">JSAPI支付 - 统一下单API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_1.shtml">小程序支付 - 统一下单API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayTransactionsJsApiResponse : WeChatPayResponse
    {
        /// <summary>
        /// 预支付交易会话标识
        /// </summary>
        /// <remarks>
        /// 预支付交易会话标识。
        /// <para>示例值：wx201410272009395522657a690389285100</para>
        /// </remarks>
        [JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }
    }
}
