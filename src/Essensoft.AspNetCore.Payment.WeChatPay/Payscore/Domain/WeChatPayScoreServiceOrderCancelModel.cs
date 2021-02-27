using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 取消支付分订单API
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_16.shtml">取消支付分订单API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderCancelModel : WeChatPayScoreModelBase
    {
        /// <summary>
        /// 取消原因
        /// </summary>
        /// <remarks>
        /// 最多30个字符，每个汉字/数字/英语都按1个字符计算超过长度报错处理。
        /// 示例值：用户投诉
        /// </remarks>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
