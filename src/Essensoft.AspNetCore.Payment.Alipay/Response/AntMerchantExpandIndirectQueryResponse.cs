using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户地址信息
        /// </summary>
        [JsonPropertyName("address_info")]
        public List<AddressInfo> AddressInfo { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        [JsonPropertyName("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 商户对应银行所开立的结算卡信息
        /// </summary>
        [JsonPropertyName("bankcard_info")]
        public List<BankCardInfo> BankcardInfo { get; set; }

        /// <summary>
        /// 商户证件编号（企业或者个体工商户提供营业执照，事业单位提供事证号）
        /// </summary>
        [JsonPropertyName("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 商户证件类型，取值范围：NATIONAL_LEGAL：营业执照；NATIONAL_LEGAL_MERGE:营业执照(多证合一)；INST_RGST_CTF：事业单位法人证书
        /// </summary>
        [JsonPropertyName("business_license_type")]
        public string BusinessLicenseType { get; set; }

        /// <summary>
        /// 商户经营类目，参考文档：https://doc.open.alipay.com/doc2/detail?&docType=1&articleId=105444。
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商户联系人信息
        /// </summary>
        [JsonPropertyName("contact_info")]
        public List<ContactInfo> ContactInfo { get; set; }

        /// <summary>
        /// 商户编号，由机构定义，需要保证在机构下唯一
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 间连商户等级。INDIRECT_LEVEL_M0:M0等级;INDIRECT_LEVEL_M1:M1等级;INDIRECT_LEVEL_M2:M2等级;INDIRECT_LEVEL_M3:M3等级
        /// </summary>
        [JsonPropertyName("indirect_level")]
        public string IndirectLevel { get; set; }

        /// <summary>
        /// 受理商户的支付宝账号（用于关联商户生活号、原服务窗，打通口碑营销活动）
        /// </summary>
        [JsonPropertyName("logon_id")]
        public List<string> LogonId { get; set; }

        /// <summary>
        /// 标准商户类别码，例如5976表示“专业销售-药品医疗-康复和身体辅助用品”。银联、网联进件的商户有该值。
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户备注信息，可填写额外信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 收单机构(例如银行）在支付宝的pid。银联、网联进件的商户有该值。
        /// </summary>
        [JsonPropertyName("org_pid")]
        public string OrgPid { get; set; }

        /// <summary>
        /// 受理商户的固定二维码链接地址（即一码多付页面地址，用于后续支付宝营销活动）  商户所属的银行或ISV 给商户的二维码url值  一码多付方案:https://doc.open.alipay.com/docs/doc.htm?&docType=1&articleId=105672
        /// </summary>
        [JsonPropertyName("pay_code_info")]
        public List<string> PayCodeInfo { get; set; }

        /// <summary>
        /// 可用服务，列表返回  PC：网站支付  APP：无线支付  F2F：当面付  返回为空为不支持所有服务
        /// </summary>
        [JsonPropertyName("service_codes")]
        public List<string> ServiceCodes { get; set; }

        /// <summary>
        /// 商户客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 网站、APP信息
        /// </summary>
        [JsonPropertyName("site_info")]
        public List<SiteInfo> SiteInfo { get; set; }

        /// <summary>
        /// 间连受理商户的推荐组织。如果是银行自有商户入驻，则推荐组织为银行，如果是ISV推广的商户，那么商户推荐组织为ISV，如果是第三方支付机构的自有商户，则推荐组织为第三方支付机构。
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号
        /// </summary>
        [JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
