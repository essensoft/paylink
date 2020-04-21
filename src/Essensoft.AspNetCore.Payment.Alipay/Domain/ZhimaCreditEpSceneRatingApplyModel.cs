using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneRatingApplyModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpSceneRatingApplyModel : AlipayObject
    {
        /// <summary>
        /// 发起申请的环境，支持以下值：  PC：PC端浏览器,  ALIPAY_H5，支付宝移动端H5,  XIAOCHENGXU:支付宝小程序,  MINIAPP:小程序JSAPI调用方式  默认ALIPAY_H5
        /// </summary>
        [JsonPropertyName("apply_environment")]
        public string ApplyEnvironment { get; set; }

        /// <summary>
        /// 芝麻企业信用评估订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，64位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性。
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
