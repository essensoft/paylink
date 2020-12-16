using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTransferInstitutionpaymentQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTransferInstitutionpaymentQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_scene_type")]
        public string BizSceneType { get; set; }

        /// <summary>
        /// 搜索关键字(学校名/机构ID)
        /// </summary>
        [JsonPropertyName("institution_keyword")]
        public string InstitutionKeyword { get; set; }

        /// <summary>
        /// 收款机构所在国家，2位编码
        /// </summary>
        [JsonPropertyName("institution_region")]
        public string InstitutionRegion { get; set; }

        /// <summary>
        /// 透传字段，json map格式
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
