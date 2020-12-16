using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenInviteOrderCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenInviteOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// ISV 业务系统的申请单 id。由 ISV 自定义，支付宝会将该值拼接在 isv_return_url 后返回，ISV 可据此做业务处理。
        /// </summary>
        [JsonPropertyName("isv_biz_id")]
        public string IsvBizId { get; set; }

        /// <summary>
        /// ISV 平台的回跳地址。商户从 ISV 平台跳转至支付宝提交签约申请后，在结果页可以回跳至该页面。
        /// </summary>
        [JsonPropertyName("isv_return_url")]
        public string IsvReturnUrl { get; set; }
    }
}
