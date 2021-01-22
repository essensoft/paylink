using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 查询订单API - 商户订单号查询- 请求URL参数
    /// 最新更新时间：2021.1.14
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_2.shtml
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_2.shtml
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_2.shtml
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_2.shtml
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_2.shtml
    /// </summary>
    public class WeChatPayTransactionsOutTradeNoQueryModel : WeChatPayObject
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
