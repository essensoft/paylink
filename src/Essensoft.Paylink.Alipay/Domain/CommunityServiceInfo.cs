using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CommunityServiceInfo Data Structure.
    /// </summary>
    public class CommunityServiceInfo : AlipayObject
    {
        /// <summary>
        /// 服务类型 "THIRD_PARTY_COMMUNITY_JIAOFEI", "THIRD_PARTY","物业缴费" "CENTRAL_SCAN_CODE_PASS", "SCAN_CODE_PASS","扫码通行联动门禁" "OPEN_SESAME", "SCAN_CODE_PASS","扫码通行无门禁" "H5_SCAN_CODE_PASS", "SCAN_CODE_PASS","扫码通行内部H5模式"
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务状态 "WAIT_BIND_METERIAL", "待物业小区关系材料上传" "WAIT_BIND_AUDIT", "待小二审核状态" "WAIT_ONLINE_REQUEST", "待ISV申请上线" "WAIT_ONLINE_AUDIT", "待小二审核上线" "ONLINE", "上线" "ONLINE_AUDIT_REJECT", "上线拒绝"
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
