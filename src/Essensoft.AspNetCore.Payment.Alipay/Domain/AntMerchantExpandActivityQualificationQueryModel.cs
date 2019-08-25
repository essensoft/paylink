using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandActivityQualificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandActivityQualificationQueryModel : AlipayObject
    {
        /// <summary>
        /// 商家活动平台活动编码
        /// </summary>
        [JsonProperty("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonProperty("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 外部业务时间
        /// </summary>
        [JsonProperty("out_biz_time")]
        public string OutBizTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
