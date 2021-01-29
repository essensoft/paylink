using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付 - 合单支付 - 合单关闭订单API（电商平台、服务商、直连商户）- 请求JSON参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_12.shtml">合单支付 - 合单关闭订单API</a></para>
    /// 最新更新时间：2020.03.31
    /// </summary>
    public class WeChatPayCombineTransactionsOutTradeNoCloseBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 合单商户appid
        /// 合单发起方的appid。
        /// 示例值：wxd678efh567hg6787
        /// </summary>
        [JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; }

        /// <summary>
        /// 子单信息
        /// 最多支持子单条数：50
        /// </summary>
        [JsonPropertyName("sub_orders")]
        public List<CombineCloseSubOrderInfo> SubOrders { get; set; }
    }
}
