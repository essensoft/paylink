using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付(服务商) - H5支付 - 统一下单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_1.shtml">H5支付 - 统一下单API</a> - 最新更新时间：2020.11.12</para>
    /// </remarks>
    public class WeChatPayPartnerTransactionsH5Response : WeChatPayResponse
    {
        /// <summary>
        /// 支付跳转链接
        /// </summary>
        /// <remarks>
        /// h5_url为拉起微信支付收银台的中间页面，可通过访问该url来拉起微信客户端，完成支付，h5_url的有效期为5分钟。
        /// <para>示例值：https://wx.tenpay.com/cgi-bin/mmpayweb-bin/checkmweb?prepay_id=wx2016121516420242444321ca0631331346&amp;package=1405458241</para>
        /// </remarks>
        [JsonPropertyName("h5_url")]
        public string H5Url { get; set; }
    }
}
