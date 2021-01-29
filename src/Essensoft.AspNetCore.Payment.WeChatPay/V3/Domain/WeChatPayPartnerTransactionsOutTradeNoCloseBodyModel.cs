using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付（服务商）- 关闭订单API - 请求JSON参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter5_6.shtml">Native下单API</a></para>
    /// 最新更新时间：2020.05.26
    /// </summary>
    public class WeChatPayPartnerTransactionsOutTradeNoCloseBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 服务商户号
        /// 服务商户号，由微信支付生成并下发
        /// 示例值：1230000109
        /// </summary>
        [JsonPropertyName("sp_mchid")]
        public string SpMchId { get; set; }

        /// <summary>
        /// 子商户号
        /// 子商户的商户号，有微信支付生成并下发。
        /// 示例值：1900000109
        /// </summary>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }
    }
}
