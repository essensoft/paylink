using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - 合单支付 - 合单H5支付 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_2.shtml">基础支付 - 合单支付 -  合单H5下单API</a> - 最新更新时间：2020.06.09</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_2.shtml">基础支付(服务商) - 合单支付 -  合单H5下单API</a> - 最新更新时间：2020.06.09</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsH5Response : WeChatPayResponse
    {
        /// <summary>
        /// 支付跳转链接
        /// </summary>
        /// <remarks>
        /// 支付跳转链接
        /// <para>示例值：https://wx.tenpay.com/cgi-bin/mmpayweb-bin/checkmweb?prepay_id=wx2016121516420242444321ca0631331346&amp;package=1405458241</para>
        /// </remarks>
        [JsonPropertyName("h5_url")]
        public string H5Url { get; set; }
    }
}
