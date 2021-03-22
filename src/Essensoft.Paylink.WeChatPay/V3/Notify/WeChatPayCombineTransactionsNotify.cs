using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Notify
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - 合单支付 - 支付通知
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_13.shtml">基础支付 - 合单支付 - 支付通知API</a> - 最新更新时间：2019.09.10</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_13.shtml">基础支付(服务商) - 合单支付 - 支付通知API</a> - 最新更新时间：2019.09.10</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsNotify : WeChatPayNotify
    {
        /// <summary>
        /// 合单商户appid
        /// </summary>
        /// <remarks>
        /// 合单发起方的appid。
        /// <para>示例值：wxd678efh567hg6787</para>
        /// </remarks>
        [JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; }

        /// <summary>
        /// 合单商户号
        /// </summary>
        /// <remarks>
        /// 合单发起方商户号。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("combine_mchid")]
        public string CombineMchId { get; set; }

        /// <summary>
        /// 合单商户订单号
        /// </summary>
        /// <remarks>
        /// 合单支付总订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一 。
        /// <para>示例值：P20150806125346</para>
        /// </remarks>
        [JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNo { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        /// <remarks>
        /// 支付场景描述
        /// </remarks>
        [JsonPropertyName("scene_info")]
        public CombineSceneInfoResponse SceneInfo { get; set; }

        /// <summary>
        /// 子单信息
        /// </summary>
        /// <remarks>
        /// 最多支持子单条数：50
        /// </remarks>
        [JsonPropertyName("sub_orders")]
        public List<CombineSubOrderInfoResponse> SubOrders { get; set; }

        /// <summary>
        /// 支付者
        /// </summary>
        /// <remarks>
        /// 支付者信息
        /// </remarks>
        [JsonPropertyName("combine_payer_info")]
        public PayerInfo CombinePayerInfo { get; set; }
    }
}
