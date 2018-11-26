using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdSubmerchantCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdSubmerchantCreateModel : AlipayObject
    {
        /// <summary>
        /// 受理商户详细经营地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 受理商户简称
        /// </summary>
        [JsonProperty("alias_name")]
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 受理商户营业执照编号
        /// </summary>
        [JsonProperty("business_license")]
        [XmlElement("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 受理商户经营类目，参考开放平台口碑开放行业入驻要求
        /// </summary>
        [JsonProperty("category_id")]
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 受理商户所在城市编码
        /// </summary>
        [JsonProperty("city_code")]
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 受理商户联系人邮箱
        /// </summary>
        [JsonProperty("contact_email")]
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 受理商户联系人手机号
        /// </summary>
        [JsonProperty("contact_mobile")]
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 受理商户联系人名称
        /// </summary>
        [JsonProperty("contact_name")]
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 受理商户联系人电话
        /// </summary>
        [JsonProperty("contact_phone")]
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 受理商户所在区县编码
        /// </summary>
        [JsonProperty("district_code")]
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 受理商户编号，由受理机构定义，需要保证在受理机构下唯一
        /// </summary>
        [JsonProperty("external_id")]
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 受理商户身份证编号
        /// </summary>
        [JsonProperty("id_card")]
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 受理商户备注信息，可填写额外信息
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 受理商户名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 受理商户所在省份编码
        /// </summary>
        [JsonProperty("province_code")]
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 受理商户客服电话
        /// </summary>
        [JsonProperty("service_phone")]
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 受理商户来源机构标识，填写受理机构在支付宝的pid
        /// </summary>
        [JsonProperty("source")]
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
