using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 关单API-请求参数
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_3.shtml
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_3.shtml
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_3.shtml
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_3.shtml
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_3.shtml
    /// </summary>
    public class WeChatPayTransactionsOutTradeNoCloseModel : WeChatPayObject
    {
        /// <summary>
        /// 直连商户号
        /// 直连商户的商户号，由微信支付生成并下发。
        /// 示例值：1230000109
        /// </summary>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }
    }
}
