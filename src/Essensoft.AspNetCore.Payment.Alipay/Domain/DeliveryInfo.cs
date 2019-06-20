using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeliveryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryInfo : AlipayObject
    {
        /// <summary>
        /// 市区编码，国标码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [JsonProperty("consignee")]
        public string Consignee { get; set; }

        /// <summary>
        /// 收件人联系方式
        /// </summary>
        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 详细地区
        /// </summary>
        [JsonProperty("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 县区编码，国标码
        /// </summary>
        [JsonProperty("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 省份编码，国标码
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }
    }
}
