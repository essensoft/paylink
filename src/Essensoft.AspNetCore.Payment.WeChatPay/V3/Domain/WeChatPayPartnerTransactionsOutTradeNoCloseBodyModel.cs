using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付（服务商）- 关闭订单 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter5_6.shtml">关单API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayPartnerTransactionsOutTradeNoCloseBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 服务商户号
        /// </summary>
        /// <remarks>
        /// 服务商户号，由微信支付生成并下发
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("sp_mchid")]
        public string SpMchId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 子商户的商户号，有微信支付生成并下发。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }
    }
}
