using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - 合单支付 - 合单Native下单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_5.shtml">基础支付 - 合单支付 -  合单Native下单API</a> - 最新更新时间：2020.05.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_5.shtml">基础支付(服务商) - 合单支付 -  合单Native下单API</a> - 最新更新时间：2020.05.14</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsNativeResponse : WeChatPayResponse
    {
        /// <summary>
        /// 二维码链接
        /// </summary>
        /// <remarks>
        /// 二维码链接
        /// <para>示例值：weixin://pay.weixin.qq.com/bizpayurl/up?pr=NwY5Mz9&amp;groupid=00</para>
        /// </remarks>
        [JsonPropertyName("code_url")]
        public string CodeUrl { get; set; }
    }
}
