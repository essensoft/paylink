using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 资金应用 - 分账 - 查询最大分账比例 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_7.shtml">分账(服务商) - 查询最大分账比例API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingMerchantConfigsSubMchidResponse : WeChatPayResponse
    {
        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 参考请求参数
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchid { get; set; }

        /// <summary>
        /// 最大分账比例
        /// </summary>
        /// <remarks>
        /// 子商户允许父商户分账的最大比例，单位万分比，比如2000表示20%
        /// <para>示例值：2000</para>
        /// </remarks>
        [JsonPropertyName("max_ratio")]
        public int MaxRatio { get; set; }
    }
}
