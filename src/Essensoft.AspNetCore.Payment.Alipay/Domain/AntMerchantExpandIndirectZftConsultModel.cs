using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftConsultModel : AlipayObject
    {
        /// <summary>
        /// 商户别名
        /// </summary>
        [JsonProperty("alias_name")]
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 商户支付宝账号，用作结算账号。与银行卡对象字段二选一必填
        /// </summary>
        [JsonProperty("alipay_logon_id")]
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 商户结算卡信息。本业务当前只允许传入一张结算卡。与支付宝账号字段二选一必填
        /// </summary>
        [JsonProperty("biz_cards")]
        [XmlArray("biz_cards")]
        [XmlArrayItem("settle_card_info")]
        public List<SettleCardInfo> BizCards { get; set; }

        /// <summary>
        /// 经营地址。地址对象中省、市、区、地址必填，其余选填
        /// </summary>
        [JsonProperty("business_address")]
        [XmlElement("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 营业执照图片url，本业务接口中，如果是特殊行业必填。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonProperty("cert_image")]
        [XmlElement("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 证件反面图片。目前只有当主证件为身份证时才需填写
        /// </summary>
        [JsonProperty("cert_image_back")]
        [XmlElement("cert_image_back")]
        public string CertImageBack { get; set; }

        /// <summary>
        /// 目前只有个体工商户商户类型要求填入本字段，填写值为个体工商户营业执照上的名称
        /// </summary>
        [JsonProperty("cert_name")]
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 商户证件编号（企业或者个体工商户提供营业执照，事业单位提供事证号）
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 商户证件类型，取值范围：201：营业执照；2011:营业执照(统一社会信用代码)；218：事业单位法人证书
        /// </summary>
        [JsonProperty("cert_type")]
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 商户联系人信息。在本业务中，ContactInfo对象中名称，类型、手机号必填，其他选填
        /// </summary>
        [JsonProperty("contact_infos")]
        [XmlArray("contact_infos")]
        [XmlArrayItem("contact_info")]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 商户编号，由机构定义，需要保证在机构下唯一
        /// </summary>
        [JsonProperty("external_id")]
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 开票资料信息
        /// </summary>
        [JsonProperty("invoice_info")]
        [XmlElement("invoice_info")]
        public MerchantInvoiceInfo InvoiceInfo { get; set; }

        /// <summary>
        /// 法人身份证反面url，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。本业务接口中，如果是特殊行业必填
        /// </summary>
        [JsonProperty("legal_cert_back_image")]
        [XmlElement("legal_cert_back_image")]
        public string LegalCertBackImage { get; set; }

        /// <summary>
        /// 法人身份证正面url，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。本业务接口中，如果是特殊行业必填
        /// </summary>
        [JsonProperty("legal_cert_front_image")]
        [XmlElement("legal_cert_front_image")]
        public string LegalCertFrontImage { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [JsonProperty("legal_cert_no")]
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称
        /// </summary>
        [JsonProperty("legal_name")]
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// c6c0c7a1-b9d5-4e5d-b9d4-9eed39f00e65.jpg   营业执照授权函。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。当商户名与结算卡户名不一致时必填
        /// </summary>
        [JsonProperty("license_auth_letter_image")]
        [XmlElement("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 商户类别码mcc，参见附件描述中的“类目code”  https://mif-pub.alipayobjects.com/AlipayMCC.xlsx
        /// </summary>
        [JsonProperty("mcc")]
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商家类型：01：企业；02：事业单位；07：个体工商户
        /// </summary>
        [JsonProperty("merchant_type")]
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 进件的二级商户名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部业务号。比如某种业务标准外部订单号,比如交易外部订单号，代表服务商端自己订单号。用于做并发控制，防止一笔外部订单发起两次进件。如果没有可不用传入。
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 门头照，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。如果使用当面付服务则必填
        /// </summary>
        [JsonProperty("out_door_images")]
        [XmlArray("out_door_images")]
        [XmlArrayItem("string")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 商户行业资质，当商户是特殊行业时必填
        /// </summary>
        [JsonProperty("qualifications")]
        [XmlArray("qualifications")]
        [XmlArrayItem("industry_qualification_info")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 商户使用服务，可选值有：当面付、app支付、wap支付、电脑支付
        /// </summary>
        [JsonProperty("service")]
        [XmlArray("service")]
        [XmlArrayItem("string")]
        public List<string> Service { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonProperty("service_phone")]
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 二级商户与服务商的签约时间
        /// </summary>
        [JsonProperty("sign_time_with_isv")]
        [XmlElement("sign_time_with_isv")]
        public string SignTimeWithIsv { get; set; }

        /// <summary>
        /// 商户站点信息，包括网站、app、小程序。商户使用服务包含电脑支付或wap支付时，必须填充一个类型为01(网站)的SiteInfo对象；当包含app支付时，必须至少填充类型为02(APP)或06(支付宝小程序)中一种类型的SiteInfo对象
        /// </summary>
        [JsonProperty("sites")]
        [XmlArray("sites")]
        [XmlArrayItem("site_info")]
        public List<SiteInfo> Sites { get; set; }
    }
}
