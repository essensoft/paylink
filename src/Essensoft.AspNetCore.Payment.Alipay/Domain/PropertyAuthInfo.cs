using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PropertyAuthInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PropertyAuthInfo : AlipayObject
    {
        /// <summary>
        /// 小区所在区县
        /// </summary>
        [JsonProperty("area")]
        public string Area { get; set; }

        /// <summary>
        /// 小区所在城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 小区名称
        /// </summary>
        [JsonProperty("community")]
        public string Community { get; set; }

        /// <summary>
        /// 认证信息ID（ISV提供，作为修改、删除唯一标识）
        /// </summary>
        [JsonProperty("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 小区纬度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 小区经度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 物业公司
        /// </summary>
        [JsonProperty("property")]
        public string Property { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}
