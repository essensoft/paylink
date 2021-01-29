using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 账单-下载账单API（电商平台、服务商、直连商户）- 请求URL参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/bill/chapter3_3.shtml">账单-下载账单API</a></para>
    /// 最新更新时间：2019.09.16
    /// </summary>
    public class WeChatPayBillDownloadQueryModel : WeChatPayObject
    {
        /// <summary>
        /// 下载地址
        /// </summary>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }
    }
}
