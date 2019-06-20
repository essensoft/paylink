using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandBenefitConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandBenefitConfirmModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonProperty("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 用户跳转到外部页面1688系统发起的·确认发奖的外部业务时间
        /// </summary>
        [JsonProperty("out_biz_time")]
        public string OutBizTime { get; set; }

        /// <summary>
        /// 用户跳转外部1688页面时URL 带的 发放记录·ID
        /// </summary>
        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
