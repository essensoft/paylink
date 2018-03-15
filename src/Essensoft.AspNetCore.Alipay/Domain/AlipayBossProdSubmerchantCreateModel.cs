using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdSubmerchantCreateModel Data Structure.
    /// </summary>
    public class AlipayBossProdSubmerchantCreateModel : AlipayObject
    {
        /// <summary>
        /// 受理商户详细经营地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 受理商户简称
        /// </summary>
        [JsonProperty("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 受理商户营业执照编号
        /// </summary>
        [JsonProperty("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 受理商户经营类目，参考开放平台口碑开放行业入驻要求
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 受理商户所在城市编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 受理商户联系人邮箱
        /// </summary>
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 受理商户联系人手机号
        /// </summary>
        [JsonProperty("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 受理商户联系人名称
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 受理商户联系人电话
        /// </summary>
        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 受理商户所在区县编码
        /// </summary>
        [JsonProperty("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 受理商户编号，由受理机构定义，需要保证在受理机构下唯一
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 受理商户身份证编号
        /// </summary>
        [JsonProperty("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 受理商户备注信息，可填写额外信息
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 受理商户名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 受理商户所在省份编码
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 受理商户客服电话
        /// </summary>
        [JsonProperty("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 受理商户来源机构标识，填写受理机构在支付宝的pid
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
