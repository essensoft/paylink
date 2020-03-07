using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceRegisterCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceRegisterCreateModel : AlipayObject
    {
        /// <summary>
        /// 联系人信息
        /// </summary>
        [JsonPropertyName("contact_info")]
        public InvoiceContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 拓展字段，json格式
        /// </summary>
        [JsonPropertyName("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 企业税务信息
        /// </summary>
        [JsonPropertyName("invoice_company")]
        public InvoiceCompanyInfo InvoiceCompany { get; set; }

        /// <summary>
        /// 发票订购信息。当业务前台是由服务市场订购后发起入驻时，且register_type是new后者renew时，必填；register_type是init或者online时，为空；
        /// </summary>
        [JsonPropertyName("invoice_order")]
        public List<InvoiceOrderInfo> InvoiceOrder { get; set; }

        /// <summary>
        /// 支付宝开票链路必传， 定义商户的一级简称，用于标识商户品牌，对应于商户入驻时填写的"商户品牌简称"。  只能包含大小写字母，数字，或下划线。匹配规则：^[A-Za-z0-9][A-Za-z_0-9]*$
        /// </summary>
        [JsonPropertyName("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 外部业务幂等ID,由业务方自己生成
        /// </summary>
        [JsonPropertyName("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 业务平台code, 由发票中台分配
        /// </summary>
        [JsonPropertyName("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 业务平台商户ID/用户ID
        /// </summary>
        [JsonPropertyName("platform_user_id")]
        public string PlatformUserId { get; set; }

        /// <summary>
        /// 入驻类型，可选值： 新订购：new，续订：renew，已有税控初始化：init，线下商户上线：online
        /// </summary>
        [JsonPropertyName("register_type")]
        public string RegisterType { get; set; }

        /// <summary>
        /// 支付宝开票链路必传， 定义商户的二级简称，用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的"商户门店简称"。 如：肯德基-杭州西湖区文一西路店：KFC_HZ_19003 要求："商户品牌简称+商户门店简称"作为确定商户及其下属机构的唯一标识，不可重复。 只能包含大小写字母，数字，或下划线。匹配规则：^[A-Za-z0-9][A-Za-z_0-9]*$
        /// </summary>
        [JsonPropertyName("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
