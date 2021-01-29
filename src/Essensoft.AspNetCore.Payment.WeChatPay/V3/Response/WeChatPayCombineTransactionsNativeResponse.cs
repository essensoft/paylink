using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付 - 合单支付 - 合单Native支付API（电商平台、服务商、直连商户）- 返回参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_5.shtml">合单Native支付API</a></para>
    /// 最新更新时间：2020.05.14
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
