using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 电商收付通 - 二级商户进件申请 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_1_1.shtml">电商收付通 - 二级商户进件API</a> - 最新更新时间：2022.05.13</para>
    /// </remarks>
    public class WechatPayEcommerceApplymentsResponse : WeChatPayResponse
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

        /// <summary>
        /// 业务申请编号
        /// </summary>
        /// <remarks>
        /// 服务商自定义的商户唯一编号。每个编号对应一个申请单，每个申请单审核通过后会生成一个微信支付商户号。。
        /// <para>示例值：APPLYMENT_00000000001</para>
        /// </remarks>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
