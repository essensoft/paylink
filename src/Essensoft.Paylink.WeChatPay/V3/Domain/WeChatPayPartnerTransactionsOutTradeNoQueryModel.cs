using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 查询订单 - 商户订单号查询 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_2.shtml">JSAPI支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">APP支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">H5支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">Native支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_2.shtml">小程序支付 - 查询订单API - 微信支付订单号查询</a> - 最新更新时间：2021.1.14</para>
    /// </remarks>
    public class WeChatPayPartnerTransactionsOutTradeNoQueryModel : WeChatPayObject
    {
        /// <summary>
        /// 服务商户号
        /// </summary>
        /// <remarks>
        /// 服务商户号，由微信支付生成并下发
        /// <para>示例值：1230000109</para>
        /// </remarks>
        [JsonPropertyName("sp_mchid")]
        public string SpMchId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 子商户的商户号，有微信支付生成并下发。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }
    }
}
