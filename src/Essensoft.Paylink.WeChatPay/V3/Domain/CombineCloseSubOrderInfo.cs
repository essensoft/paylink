using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 合单关闭订单子单信息
    /// </summary>       
    public class CombineCloseSubOrderInfo : WeChatPayObject
    {
        /// <summary>
        /// 子单商户号
        /// </summary>
        /// <remarks>
        /// 子单发起方商户号，必须与发起方appid有绑定关系。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 子单商户订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一。
        /// 特殊规则：最小字符长度为6
        /// <para>示例值：20150806125346</para>
        /// </remarks>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 二级商户号
        /// </summary>
        /// <remarks>
        /// 二级商户商户号，由微信支付生成并下发。
        /// 注意：仅适用于电商平台 服务商
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }
    }
}
