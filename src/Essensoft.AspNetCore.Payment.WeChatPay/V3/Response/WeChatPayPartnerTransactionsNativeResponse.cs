using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// Native下单API-返回参数（服务商）
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter5_3.shtml
    /// </summary>
    public class WeChatPayPartnerTransactionsNativeResponse : WeChatPayResponse
    {
        /// <summary>
        /// 二维码链接
        /// 此URL用于生成支付二维码，然后提供给用户扫码支付。
        /// 注意：code_url并非固定值，使用时按照URL格式转成二维码即可。
        /// 示例值：weixin://wxpay/bizpayurl/up?pr=NwY5Mz9&groupid=00
        /// </summary>
        [JsonPropertyName("code_url")]
        public string CodeUrl { get; set; }
    }
}
