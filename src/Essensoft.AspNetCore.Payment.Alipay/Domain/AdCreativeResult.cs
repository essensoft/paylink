using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdCreativeResult Data Structure.
    /// </summary>
    public class AdCreativeResult : AlipayObject
    {
        /// <summary>
        /// 广告创意ID
        /// </summary>
        [JsonPropertyName("ad_id")]
        public long AdId { get; set; }

        /// <summary>
        /// 创意包含的物料列表
        /// </summary>
        [JsonPropertyName("ad_material_list")]
        public List<AdMaterialResultDTO> AdMaterialList { get; set; }

        /// <summary>
        /// 创意名称
        /// </summary>
        [JsonPropertyName("ad_name")]
        public string AdName { get; set; }

        /// <summary>
        /// 创意审核状态，PASS：审核通过；TO_BE_AUDTI：待审核；OP_AUDIT：运营审核中；MEDIA_AUDIT：媒体审核中；REFUSED：审核拒绝
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 所属广告单元ID
        /// </summary>
        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 创意状态，ENABLE：生效；DISABLE：失效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 创意使用模板名称
        /// </summary>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }
    }
}
