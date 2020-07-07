using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 合单查询订单API-返回参数（电商平台、服务商、直连商户）
    /// 最新更新时间：2020.03.27
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/combine/chapter3_3.shtml
    /// </summary>
    public class WeChatPayCombineTransactionsOutTradeNoResponse : WeChatPayResponse
    {
        /// 合单商户appid
        /// 合单发起方的appid。
        /// 示例值：wxd678efh567hg6787
        /// </summary>
        [JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; }

        /// <summary>
        /// 合单商户号
        /// 合单发起方商户号。
        /// 示例值：1900000109
        /// </summary>
        [JsonPropertyName("combine_mchid")]
        public string CombineMchId { get; set; }

        /// <summary>
        /// 合单商户订单号
        /// 合单支付总订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一 。
        /// 示例值：P20150806125346
        /// </summary>
        [JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNo { get; set; }

        /// <summary>
        /// 场景信息
        /// 支付场景描述
        /// </summary>
        [JsonPropertyName("scene_info")]
        public CombineSceneInfoResponse SceneInfo { get; set; }

        /// <summary>
        /// 子单信息
        /// 最多支持子单条数：50
        /// </summary>
        [JsonPropertyName("sub_orders")]
        public List<CombineSubOrderInfoResponse> SubOrders { get; set; }

        /// <summary>
        /// 支付者
        /// 支付者信息
        /// </summary>
        [JsonPropertyName("combine_payer_info")]
        public PayerInfo CombinePayerInfo { get; set; }
    }
}
