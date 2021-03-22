using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceCaasBlacklistConsultModel Data Structure.
    /// </summary>
    public class AlipayFincoreComplianceCaasBlacklistConsultModel : AlipayObject
    {
        /// <summary>
        /// app_name+调用方系统名称；会与分配的app_token做校验
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// app_token+每一个app分配一个
        /// </summary>
        [JsonPropertyName("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// biz_code+咨询服务分配的业务code
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// event_code+服务方分配的咨询事件code
        /// </summary>
        [JsonPropertyName("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// merchant_pid+商户pid，与组织机构代码不可全部为空
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// org_code+商户组织机构代码； 与Pid不可全部为空
        /// </summary>
        [JsonPropertyName("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// request_id+请求方自行生成的请求号
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
