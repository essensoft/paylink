using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierInfoQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 经营期限自
        /// </summary>
        [JsonPropertyName("business_period_from")]
        public string BusinessPeriodFrom { get; set; }

        /// <summary>
        /// 经营期限至
        /// </summary>
        [JsonPropertyName("business_period_to")]
        public string BusinessPeriodTo { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [JsonPropertyName("business_scope")]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 负责人姓名
        /// </summary>
        [JsonPropertyName("charge_person_name")]
        public string ChargePersonName { get; set; }

        /// <summary>
        /// 负责人类型，例如：法定代表人、法人代表、执行合伙人等
        /// </summary>
        [JsonPropertyName("charge_person_type")]
        public string ChargePersonType { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [JsonPropertyName("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [JsonPropertyName("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 经营状态，如存续、在业、吊销、注销、迁入、迁出等
        /// </summary>
        [JsonPropertyName("ep_status")]
        public string EpStatus { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [JsonPropertyName("ep_type")]
        public string EpType { get; set; }

        /// <summary>
        /// 成立时间
        /// </summary>
        [JsonPropertyName("established_time")]
        public string EstablishedTime { get; set; }

        /// <summary>
        /// 所属行业
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [JsonPropertyName("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [JsonPropertyName("registered_capital")]
        public string RegisteredCapital { get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [JsonPropertyName("registered_org")]
        public string RegisteredOrg { get; set; }
    }
}
