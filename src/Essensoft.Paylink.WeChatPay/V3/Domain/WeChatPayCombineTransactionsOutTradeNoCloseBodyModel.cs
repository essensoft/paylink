using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - 合单支付 - 合单关闭订单 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_12.shtml">基础支付 - 合单支付 -  合单关闭订单API</a> - 最新更新时间：2020.03.31</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter5_1_12.shtml">基础支付(服务商) - 合单支付 -  合单关闭订单API</a> - 最新更新时间：2020.03.31</para>
    /// </remarks>
    public class WeChatPayCombineTransactionsOutTradeNoCloseBodyModel : WeChatPayObject
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
        /// 子单信息
        /// </summary>
        /// <remarks>
        /// 最多支持子单条数：50
        /// </remarks>
        [JsonPropertyName("sub_orders")]
        public List<CombineCloseSubOrderInfo> SubOrders { get; set; }
    }
}
