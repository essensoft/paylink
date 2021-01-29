using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付 - H5下单API - 返回参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_4.shtml">H5下单API</a></para>
    /// 最新更新时间：2020.05.26
    /// </summary>
    public class WeChatPayTransactionsH5Response : WeChatPayResponse
    {
        /// <summary>
        /// 支付跳转链接
        /// h5_url为拉起微信支付收银台的中间页面，可通过访问该url来拉起微信客户端，完成支付，h5_url的有效期为5分钟。
        /// 示例值：https://wx.tenpay.com/cgi-bin/mmpayweb-bin/checkmweb?prepay_id=wx2016121516420242444321ca0631331346&package=1405458241
        /// </summary>
        [JsonPropertyName("h5_url")]
        public string H5Url { get; set; }
    }
}
