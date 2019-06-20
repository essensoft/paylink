using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponWufuCardReceiveModel : AlipayObject
    {
        /// <summary>
        /// 业务流水号，用于数据关联核对，不做为幂等使用。
        /// </summary>
        [JsonProperty("front_biz_no")]
        public string FrontBizNo { get; set; }

        /// <summary>
        /// 福卡领取场景
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
