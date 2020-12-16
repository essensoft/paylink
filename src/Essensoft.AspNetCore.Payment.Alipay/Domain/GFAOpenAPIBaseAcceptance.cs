using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GFAOpenAPIBaseAcceptance Data Structure.
    /// </summary>
    public class GFAOpenAPIBaseAcceptance : AlipayObject
    {
        /// <summary>
        /// 业财受理单号
        /// </summary>
        [JsonPropertyName("acceptance_id")]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 业务事件码
        /// </summary>
        [JsonPropertyName("biz_ev_code")]
        public string BizEvCode { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [JsonPropertyName("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 端事件码
        /// </summary>
        [JsonPropertyName("cnl_ev_code")]
        public string CnlEvCode { get; set; }

        /// <summary>
        /// 端产品码
        /// </summary>
        [JsonPropertyName("cnl_pd_code")]
        public string CnlPdCode { get; set; }

        /// <summary>
        /// 受理方向
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 业财统一身份Id
        /// </summary>
        [JsonPropertyName("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonPropertyName("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 主体Id
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 受理单扩展信息
        /// </summary>
        [JsonPropertyName("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 逆向受理关联的业务流水号
        /// </summary>
        [JsonPropertyName("rel_out_business_no")]
        public string RelOutBusinessNo { get; set; }

        /// <summary>
        /// 逆向受理关联的业务流水子单号
        /// </summary>
        [JsonPropertyName("rel_sub_out_business_no")]
        public string RelSubOutBusinessNo { get; set; }

        /// <summary>
        /// 业务唯一标识
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 解决方案id
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 业务流水子单号
        /// </summary>
        [JsonPropertyName("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }

        /// <summary>
        /// 受理来源系统
        /// </summary>
        [JsonPropertyName("system_origin")]
        public string SystemOrigin { get; set; }
    }
}
