using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserDigitalidentityIdcodeinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayUserDigitalidentityIdcodeinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 扫码用户二维码后解析出的码串值
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 场景类型，描述在何等场景下获取用户身份码信息。场景例如：HOTEL（酒店）、CYBERCAFE（网吧）、SENSITIVE_MATERIALS（敏感物资）等，具体可支持的类型可能会有新增，请与技术支持人员确认
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 二级商户ID，标识一级商户下某个具体商家或门店。一级商户就是指接入支付宝开放平台的商家或服务商，支付宝侧可直接获取到相应的appId
        /// </summary>
        [JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
