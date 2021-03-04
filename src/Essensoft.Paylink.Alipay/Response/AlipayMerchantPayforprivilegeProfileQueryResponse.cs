using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeProfileQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeProfileQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 充享惠卡模板设置
        /// </summary>
        [JsonPropertyName("card_template_config")]
        public PayForPrivilegeCardTemplateConfig CardTemplateConfig { get; set; }
    }
}
