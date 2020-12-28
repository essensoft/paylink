using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 合单H5支付API-返回参数（电商平台、服务商、直连商户）
    /// 最新更新时间：2020.06.09
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_2.shtml
    /// </summary>
    public class WeChatPayCombineTransactionsH5Response : WeChatPayResponse
    {
        /// <summary>
        /// 支付跳转链接
        /// 支付跳转链接
        /// 示例值：https://wx.tenpay.com/cgi-bin/mmpayweb-bin/checkmweb?prepay_id=wx2016121516420242444321ca0631331346&package=1405458241
        /// </summary>
        [JsonPropertyName("h5_url")]
        public string H5Url { get; set; }
    }
}
