using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 同步服务订单信息
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_20.shtml">同步服务订单信息API</a></para>
    /// </summary>
    public class WeChatPayScoreServiceOrderSyncModel : WeChatPayScoreModelBase
    {
        /// <summary>
        /// 场景类型
        /// </summary>
        /// <remarks>
        /// 场景类型为“Order_Paid”，字符串表示“订单收款成功” 。
        /// 示例值：Order_Paid
        /// </remarks>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 内容信息详情
        /// </summary>
        /// <remarks>
        /// 场景类型为Order_Paid时，为必填项。
        /// </remarks>
        [JsonPropertyName("detail")]
        public SyncDetail Detail { get; set; }
    }
}
