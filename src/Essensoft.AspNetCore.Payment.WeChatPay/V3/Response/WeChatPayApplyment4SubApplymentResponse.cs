using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 商户进件 - 提交申请单API（普通服务商）- 返回参数
    /// 最新更新时间：2019.04.10
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_1.shtml
    /// </summary>
    public class WeChatPayApplyment4SubApplymentResponse : WeChatPayResponse
    {
        /// <summary>
        /// 微信支付申请单号
        /// 微信支付分配的申请单号。
        /// 示例值：2000002124775691
        /// </summary>
        [JsonPropertyName("applyment_id")]
        public string ApplymentId { get; set; }
    }
}
