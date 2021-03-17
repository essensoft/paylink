using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 查询单笔退款 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_10.shtml">基础支付(服务商) - JSAPI支付 - 查询单笔退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_10.shtml">基础支付(服务商) - APP支付 - 查询单笔退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_10.shtml">基础支付(服务商) - H5支付 - 查询单笔退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_10.shtml">基础支付(服务商) - Native支付 - 查询单笔退款API</a> - 最新更新时间：2021.01.15</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_10.shtml">基础支付(服务商) - 小程序支付 - 查询单笔退款API</a> - 最新更新时间：2021.01.15</para>
    /// </remarks>
    public class WeChatPayRefundDomesticRefundsOutRefundNoQueryModel : WeChatPayObject
    {
        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 子商户的商户号，由微信支付生成并下发。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }
    }
}
