using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付 - 合单支付 - 合单APP支付API（电商平台、服务商、直连商户）- 返回参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_1.shtml">合单APP支付API</a></para>
    /// 最新更新时间：2020.05.21
    /// </summary>
    public class WeChatPayCombineTransactionsAppResponse : WeChatPayResponse
    {
        /// <summary>
        /// 预支付交易会话标识
        /// 数字和字母。微信生成的预支付会话标识，用于后续接口调用使用。
        /// 示例值：wx201410272009395522657a690389285100
        /// </summary>
        [JsonPropertyName("prepay_id")]
        public string PrepayId { get; set; }
    }
}
