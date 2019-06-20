using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsHealthGiftBatchAlreadyOpenedResult Data Structure.
    /// </summary>
    [Serializable]
    public class InsHealthGiftBatchAlreadyOpenedResult : AlipayObject
    {
        /// <summary>
        /// 是否已开通。true为开通，false为未开通
        /// </summary>
        [JsonProperty("already_opened")]
        public bool AlreadyOpened { get; set; }

        /// <summary>
        /// 业务类型。免费医疗金 HEALTH_BEAN_SIMPLE_UPGRADE、守护金 HEALTH_GUARDIAN_GOLD、多收多宝新门诊 HEALTH_DSDB_NEW_OUTPATIENT
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }
    }
}
