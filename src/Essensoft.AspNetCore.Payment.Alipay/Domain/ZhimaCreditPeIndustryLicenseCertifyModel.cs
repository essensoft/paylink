using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeIndustryLicenseCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeIndustryLicenseCertifyModel : AlipayObject
    {
        /// <summary>
        /// 业务场景,分时租赁平台:car_sharing_zhima,具体业务对应的业务场景请联系业务确认
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 扩展信息字段，格式:json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 证件校验状态 Y：校验通过， N:校验不通过
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
