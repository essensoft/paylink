using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandShopCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandShopCreateModel : AlipayObject
    {
        /// <summary>
        /// 经营地址。地址对象中省、市、区、地址必填，其余选填
        /// </summary>
        [JsonProperty("business_address")]
        [XmlElement("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 店铺经营时间。
        /// </summary>
        [JsonProperty("business_time")]
        [XmlArray("business_time")]
        [XmlArrayItem("shop_business_time")]
        public List<ShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 营业执照图片url。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。当店铺类目为特殊行业时必填
        /// </summary>
        [JsonProperty("cert_image")]
        [XmlElement("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 营业执照名称，填写值为营业执照或统一社会信用代码证上的名称。当店铺类目是特殊类目是要求必填
        /// </summary>
        [JsonProperty("cert_name")]
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码。请填写店铺营业执照号。当店铺类目是特殊类目是要求必填
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，取值范围：201：营业执照；2011:多证合一(统一社会信用代码)。当店铺类目是特殊类目是要求必填
        /// </summary>
        [JsonProperty("cert_type")]
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 联系人信息。如果填写，其中xxxx必填
        /// </summary>
        [JsonProperty("contact_infos")]
        [XmlArray("contact_infos")]
        [XmlArrayItem("contact_info")]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 店铺联系手机，与店铺联系固话二选一必填
        /// </summary>
        [JsonProperty("contact_mobile")]
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固话，和店铺联系手机二选一必填
        /// </summary>
        [JsonProperty("contact_phone")]
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid
        /// </summary>
        [JsonProperty("ip_role_id")]
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 法人身份证号。当店铺类目是特殊类目是要求必填
        /// </summary>
        [JsonProperty("legal_cert_no")]
        [XmlElement("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称。当店铺类目是特殊类目是要求必填
        /// </summary>
        [JsonProperty("legal_name")]
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照授权函。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。当店铺类目是特殊行业时必填
        /// </summary>
        [JsonProperty("license_auth_letter_image")]
        [XmlElement("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 门头照，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。当店铺类目是特殊类目是要求必填
        /// </summary>
        [JsonProperty("out_door_images")]
        [XmlArray("out_door_images")]
        [XmlArrayItem("string")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 行业特殊资质。当店铺类目是特殊类目是要求必填
        /// </summary>
        [JsonProperty("qualifications")]
        [XmlArray("qualifications")]
        [XmlArrayItem("industry_qualification_info")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 结算支付宝账号的登录号
        /// </summary>
        [JsonProperty("settle_alipay_logon_id")]
        [XmlElement("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }

        /// <summary>
        /// 店铺类目，取值参见文件https://mif-pub.alipayobjects.com/ShopCategory.xlsx 中的三级门店类目
        /// </summary>
        [JsonProperty("shop_category")]
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 店铺名称。直连开店要保证全局店铺名称+地址唯一，间连开店要保证服务商pid下店铺名称+地址唯一
        /// </summary>
        [JsonProperty("shop_name")]
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺经营类型，01表示直营，02表示加盟
        /// </summary>
        [JsonProperty("shop_type")]
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号
        /// </summary>
        [JsonProperty("store_id")]
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
