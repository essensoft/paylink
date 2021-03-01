using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付 - 合单支付 - JSAPI下单API、小程序下单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_3.shtml">合单支付 - 合单JSAPI下单API</a> - 最新更新时间：2020.05.21</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_4.shtml">合单支付 - 合单小程序下单API</a> - 最新更新时间：2020.05.21</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/combine/chapter3_2.shtml">合单下单 - JSAPI支付/小程序支付API</a> - 最新更新时间：2020.05.21</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsJsApiResponse : WeChatPayResponse
    {
        /// <summary>
        /// 预支付交易会话标识
        /// </summary>
        /// <remarks>
        /// 数字和字母。微信生成的预支付会话标识，用于后续接口调用使用。
        /// <para>示例值：wx201410272009395522657a690389285100</para>
        /// </remarks>
        [JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }
    }
}
