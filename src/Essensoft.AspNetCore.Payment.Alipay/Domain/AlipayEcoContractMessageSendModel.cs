using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoContractMessageSendModel Data Structure.
    /// </summary>
    public class AlipayEcoContractMessageSendModel : AlipayObject
    {
        /// <summary>
        /// 调用批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public List<string> CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 流程Id
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 供应商的appId
        /// </summary>
        [JsonPropertyName("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 消息模板ID
        /// </summary>
        [JsonPropertyName("msg_template_id")]
        public string MsgTemplateId { get; set; }

        /// <summary>
        /// 签署平台的代码
        /// </summary>
        [JsonPropertyName("sign_platform_code")]
        public string SignPlatformCode { get; set; }

        /// <summary>
        /// 支付宝账号Id,数组关联多个支付宝账号 （如果未注册支付宝账号 则为空）
        /// </summary>
        [JsonPropertyName("user_ids")]
        public List<string> UserIds { get; set; }
    }
}
