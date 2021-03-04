using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付 - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 关闭订单 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_3.shtml">JSAPI支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_3.shtml">APP支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_3.shtml">H5支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_3.shtml">Native支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_3.shtml">小程序支付 - 关单API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayTransactionsOutTradeNoCloseBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 直连商户号
        /// </summary>
        /// <remarks>
        /// 直连商户的商户号，由微信支付生成并下发。
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }
    }
}
