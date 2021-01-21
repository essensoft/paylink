using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 查询订单API - 微信支付订单号查询（服务商） - 请求URL参数
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter5_5.shtml
    /// </summary>
    public class WeChatPayPartnerTransactionsIdQueryModel : WeChatPayObject
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
