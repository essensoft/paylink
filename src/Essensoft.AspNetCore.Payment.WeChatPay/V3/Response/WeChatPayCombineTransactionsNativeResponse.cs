using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 合单下单-Native支付API-返回参数（电商平台、服务商、直连商户）
    /// 最新更新时间：2020.05.14
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/combine/chapter3_10.shtml
    /// </summary>
    public class WeChatPayCombineTransactionsNativeResponse : WeChatPayResponse
    {
        /// <summary>
        /// 二维码链接
        /// 二维码链接
        /// 示例值：weixin://pay.weixin.qq.com/bizpayurl/up?pr=NwY5Mz9&groupid=00
        /// </summary>
        [JsonPropertyName("code_url")]
        public string CodeUrl { get; set; }
    }
}
