using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 资金应用 - 分账 - 删除分账接收方 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_9.shtml">分账 - 删除分账接收方API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_9.shtml">分账(服务商) - 删除分账接收方API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingReceiversDeleteResponse : WeChatPayResponse
    {
        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 微信支付分配的子商户号，即分账的出资商户号。
        /// <para>示例值: 1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 分账接收方类型
        /// </summary>
        /// <remarks>
        /// 1、MERCHANT_ID：商户号
        /// 2、PERSONAL_OPENID：个人openid（由父商户APPID转换得到）
        /// 3、PERSONAL_SUB_OPENID: 个人sub_openid（由子商户APPID转换得到）
        /// <para>示例值: MERCHANT_ID</para>
        /// </remarks>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 分账接收方帐号
        /// </summary>
        /// <remarks>
        /// 类型是MERCHANT_ID时，是商户号 类型是PERSONAL_OPENID时，是个人openid 类型是PERSONAL_SUB_OPENID时，是个人sub_openid
        /// <para>示例值: 86693852</para>
        /// </remarks>
        [JsonPropertyName("account")]
        public string Account { get; set; }
    }
}
