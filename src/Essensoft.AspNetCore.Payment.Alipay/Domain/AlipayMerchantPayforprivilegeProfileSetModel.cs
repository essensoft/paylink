using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeProfileSetModel Data Structure.
    /// </summary>
    public class AlipayMerchantPayforprivilegeProfileSetModel : AlipayObject
    {
        /// <summary>
        /// 充享惠卡模板设置，用户使用充享惠业务领卡后会在支付宝卡包中使用该模板配置创建卡入口
        /// </summary>
        [JsonPropertyName("card_template_config")]
        public PayForPrivilegeCardTemplateConfig CardTemplateConfig { get; set; }
    }
}
