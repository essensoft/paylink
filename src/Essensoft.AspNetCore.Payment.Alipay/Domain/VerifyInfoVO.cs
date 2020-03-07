using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VerifyInfoVO Data Structure.
    /// </summary>
    public class VerifyInfoVO : AlipayObject
    {
        /// <summary>
        /// 公司地址
        /// </summary>
        [JsonPropertyName("business_address")]
        public string BusinessAddress { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 曾用名(目前为null)
        /// </summary>
        [JsonPropertyName("ever_org_name")]
        public string EverOrgName { get; set; }

        /// <summary>
        /// 国民经济行业
        /// </summary>
        [JsonPropertyName("industry_name")]
        public string IndustryName { get; set; }

        /// <summary>
        /// 法人信息
        /// </summary>
        [JsonPropertyName("legal_representative")]
        public LegalRepresentativeVO LegalRepresentative { get; set; }

        /// <summary>
        /// 当地税号
        /// </summary>
        [JsonPropertyName("local_tax_no")]
        public string LocalTaxNo { get; set; }

        /// <summary>
        /// 注销日期
        /// </summary>
        [JsonPropertyName("logoff_date")]
        public string LogoffDate { get; set; }

        /// <summary>
        /// 主要管理人员信息
        /// </summary>
        [JsonPropertyName("managers")]
        public List<ManagerVO> Managers { get; set; }

        /// <summary>
        /// 一般经营项目
        /// </summary>
        [JsonPropertyName("norm_opr_project")]
        public string NormOprProject { get; set; }

        /// <summary>
        /// 经营状态
        /// </summary>
        [JsonPropertyName("opr_status")]
        public string OprStatus { get; set; }

        /// <summary>
        /// 经营期限结束时间
        /// </summary>
        [JsonPropertyName("oprt_end_date")]
        public string OprtEndDate { get; set; }

        /// <summary>
        /// 经营期限起始时间
        /// </summary>
        [JsonPropertyName("oprt_start_date")]
        public string OprtStartDate { get; set; }

        /// <summary>
        /// 实缴资金（万）
        /// </summary>
        [JsonPropertyName("org_actual_cptl")]
        public string OrgActualCptl { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [JsonPropertyName("org_reg_addr")]
        public string OrgRegAddr { get; set; }

        /// <summary>
        /// 注册资金（万）
        /// </summary>
        [JsonPropertyName("org_reg_cptl")]
        public string OrgRegCptl { get; set; }

        /// <summary>
        /// 注册币种
        /// </summary>
        [JsonPropertyName("org_reg_cptl_curcy")]
        public string OrgRegCptlCurcy { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        [JsonPropertyName("org_reg_opr_scope")]
        public string OrgRegOprScope { get; set; }

        /// <summary>
        /// 企业类型
        /// </summary>
        [JsonPropertyName("org_type")]
        public string OrgType { get; set; }

        /// <summary>
        /// 网站列表
        /// </summary>
        [JsonPropertyName("org_website")]
        public string OrgWebsite { get; set; }

        /// <summary>
        /// 许可经营项目
        /// </summary>
        [JsonPropertyName("permit_opr_project")]
        public string PermitOprProject { get; set; }

        /// <summary>
        /// 注册国家
        /// </summary>
        [JsonPropertyName("registration_country")]
        public string RegistrationCountry { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        [JsonPropertyName("registration_date")]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// 工商注册号
        /// </summary>
        [JsonPropertyName("registration_no")]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// 吊销日期
        /// </summary>
        [JsonPropertyName("revoke_date")]
        public string RevokeDate { get; set; }

        /// <summary>
        /// 股东信息
        /// </summary>
        [JsonPropertyName("stock_holders")]
        public List<StockHolderVO> StockHolders { get; set; }

        /// <summary>
        /// 个人UBO信息
        /// </summary>
        [JsonPropertyName("ubos")]
        public List<UboVO> Ubos { get; set; }

        /// <summary>
        /// 标识码
        /// </summary>
        [JsonPropertyName("uc_code")]
        public string UcCode { get; set; }
    }
}
