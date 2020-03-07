using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectOnlineQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectOnlineQueryResponse : AlipayResponse
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
        /// 签约受理机构pid
        /// </summary>
        [JsonPropertyName("bank_pid")]
        public string BankPid { get; set; }

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
        /// 商户联系人信息
        /// </summary>
        [JsonPropertyName("contact_info")]
        public List<ContactInfo> ContactInfo { get; set; }

        /// <summary>
        /// 支付机构pid/source id；服务商PID；
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商户的支付宝账号
        /// </summary>
        [JsonPropertyName("logon_id")]
        public List<string> LogonId { get; set; }

        /// <summary>
        /// mcc编码
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户特殊资质等
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户的支付二维码中信息，用于营销活动
        /// </summary>
        [JsonPropertyName("pay_code_info")]
        public List<string> PayCodeInfo { get; set; }

        /// <summary>
        /// 商户客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 商户在银行端的签约时间
        /// </summary>
        [JsonPropertyName("sign_bank_time")]
        public string SignBankTime { get; set; }

        /// <summary>
        /// 站点信息
        /// </summary>
        [JsonPropertyName("site_info")]
        public List<SiteInfo> SiteInfo { get; set; }

        /// <summary>
        /// 商户在受理机构的唯一代码，该代号在该机构下保持唯一；extenalID；
        /// </summary>
        [JsonPropertyName("unique_id_by_bank")]
        public string UniqueIdByBank { get; set; }

        /// <summary>
        /// 商户在支付机构的的唯一代码；服务商对该商户分配的ID；
        /// </summary>
        [JsonPropertyName("unique_id_by_isv")]
        public string UniqueIdByIsv { get; set; }
    }
}
