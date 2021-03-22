using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 特约商户进件 - 提交申请单 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter11_1_1.shtml">特约商户进件 - 提交申请单API</a> - 最新更新时间：2019.04.10</para>
    /// </remarks>
    public class WeChatPayApplyment4SubApplymentResponse : WeChatPayResponse
    {
        /// <summary>
        /// 微信支付申请单号
        /// </summary>
        /// <remarks>
        /// 微信支付分配的申请单号。
        /// <para>示例值：2000002124775691</para>
        /// </remarks>
        [JsonPropertyName("applyment_id")]
        public string ApplymentId { get; set; }
    }
}
