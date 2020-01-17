using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenInviteOrderCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenInviteOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// isv业务系统的申请单id
        /// </summary>
        [JsonPropertyName("isv_biz_id")]
        public string IsvBizId { get; set; }

        /// <summary>
        /// isv平台的回跳地址。商户从伙伴平台跳转过来签约提交申请后，在结果页可以回跳到合作伙伴指定的页面，
        /// </summary>
        [JsonPropertyName("isv_return_url")]
        public string IsvReturnUrl { get; set; }
    }
}
