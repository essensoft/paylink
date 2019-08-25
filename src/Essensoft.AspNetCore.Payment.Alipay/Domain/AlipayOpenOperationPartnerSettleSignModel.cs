using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationPartnerSettleSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationPartnerSettleSignModel : AlipayObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 入驻渠道Id。  高德 - AMAP
        /// </summary>
        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 公司所在地-城市编码
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机号码
        /// </summary>
        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 公司所在地-区/县编码
        /// </summary>
        [JsonProperty("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 公司所在地-省份编码
        /// </summary>
        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 业务介绍
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 入驻开放平台的角色列表。  枚举如下：  自研开发者 -- IDENTITY_OPEN_SELF_RESEARCH_DEVELOPER，  系统服务商 -- IDENTITY_OPEN_SYSTEM_SERVICE_PROVIDER，  地推服务商 -- IDENTITY_OPEN_PUSH_SERVICE_PROVIDER
        /// </summary>
        [JsonProperty("roles")]
        public List<string> Roles { get; set; }
    }
}
