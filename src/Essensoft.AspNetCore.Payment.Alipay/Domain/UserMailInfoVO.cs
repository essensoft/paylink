using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserMailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class UserMailInfoVO : AlipayObject
    {
        /// <summary>
        /// 收件人地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// 县区
        /// </summary>
        [JsonProperty("county_district")]
        public string CountyDistrict { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 收件人信息ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// pid用于指定该地址归属的PID，应对集团模式的商户所设定,发票邮寄地址根据PID确定
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }
    }
}
