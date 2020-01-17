using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ConfigInfo Data Structure.
    /// </summary>
    public class ConfigInfo : AlipayObject
    {
        /// <summary>
        /// 附件信息（collect_attachement值为true时必填）
        /// </summary>
        [JsonPropertyName("attachment_explain")]
        public AttachmentExplain AttachmentExplain { get; set; }

        /// <summary>
        /// 是否收集附件
        /// </summary>
        [JsonPropertyName("collect_attachement")]
        public bool CollectAttachement { get; set; }

        /// <summary>
        /// 公司编号-SF
        /// </summary>
        [JsonPropertyName("company_no")]
        public string CompanyNo { get; set; }

        /// <summary>
        /// 文档过期时间
        /// </summary>
        [JsonPropertyName("contract_validity")]
        public long ContractValidity { get; set; }

        /// <summary>
        /// 支付宝小程序跳转
        /// </summary>
        [JsonPropertyName("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 回调地址，签署的过程和签署完成都会回调。
        /// </summary>
        [JsonPropertyName("notice_developer_url")]
        public string NoticeDeveloperUrl { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [JsonPropertyName("platform_order_no")]
        public string PlatformOrderNo { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }
    }
}
