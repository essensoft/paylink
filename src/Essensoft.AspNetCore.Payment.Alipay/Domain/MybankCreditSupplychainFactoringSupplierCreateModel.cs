using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSupplierCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainFactoringSupplierCreateModel : AlipayObject
    {
        /// <summary>
        /// 采购商网商银行参与者会员ID
        /// </summary>
        [JsonProperty("buyer_ip_id")]
        public string BuyerIpId { get; set; }

        /// <summary>
        /// 采购商网商银行参与者会员角色ID
        /// </summary>
        [JsonProperty("buyer_ip_role_id")]
        public string BuyerIpRoleId { get; set; }

        /// <summary>
        /// 采购商会员站点：ALIPAY:支付宝(当前支持)
        /// </summary>
        [JsonProperty("buyer_site")]
        public string BuyerSite { get; set; }

        /// <summary>
        /// 采购商支付宝ID
        /// </summary>
        [JsonProperty("buyer_site_user_id")]
        public string BuyerSiteUserId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 运营商名称
        /// </summary>
        [JsonProperty("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 收款渠道
        /// </summary>
        [JsonProperty("rcv_account_type")]
        public string RcvAccountType { get; set; }

        /// <summary>
        /// 供应商收款银行卡号
        /// </summary>
        [JsonProperty("seller_bank_acc")]
        public string SellerBankAcc { get; set; }

        /// <summary>
        /// 供应商账户名
        /// </summary>
        [JsonProperty("seller_bank_acc_name")]
        public string SellerBankAccName { get; set; }

        /// <summary>
        /// 供应商支行联行号-外标(企业时必填)
        /// </summary>
        [JsonProperty("seller_bank_branch_union_code")]
        public string SellerBankBranchUnionCode { get; set; }

        /// <summary>
        /// 供应商银行名称
        /// </summary>
        [JsonProperty("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 供应商联系人邮箱
        /// </summary>
        [JsonProperty("seller_contact_email")]
        public string SellerContactEmail { get; set; }

        /// <summary>
        /// 供应商联系人
        /// </summary>
        [JsonProperty("seller_contact_name")]
        public string SellerContactName { get; set; }

        /// <summary>
        /// 供应商联系人电话
        /// </summary>
        [JsonProperty("seller_contact_phone")]
        public string SellerContactPhone { get; set; }

        /// <summary>
        /// 供应商支付宝会员登录ID
        /// </summary>
        [JsonProperty("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 门店所属城市
        /// </summary>
        [JsonProperty("store_city")]
        public string StoreCity { get; set; }

        /// <summary>
        /// 门店所属区县
        /// </summary>
        [JsonProperty("store_county")]
        public string StoreCounty { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonProperty("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [JsonProperty("store_no")]
        public string StoreNo { get; set; }

        /// <summary>
        /// 门店所属省份
        /// </summary>
        [JsonProperty("store_province")]
        public string StoreProvince { get; set; }

        /// <summary>
        /// 门店背后主体证件号
        /// </summary>
        [JsonProperty("store_subject_cert_no")]
        public string StoreSubjectCertNo { get; set; }

        /// <summary>
        /// 门店背后主体名称
        /// </summary>
        [JsonProperty("store_subject_name")]
        public string StoreSubjectName { get; set; }
    }
}
