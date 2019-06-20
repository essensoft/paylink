using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ActivityQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityQueryResult : AlipayObject
    {
        /// <summary>
        /// 查询返回结果的code  biz_code与biz_msg的对应关系见下：  biz_code:OK, biz_msg:正常  biz_code:BENEFITED, biz_msg:您已领取过收藏有礼券  biz_code:BENEFITED_COUPON, biz_msg:您已领取收藏有礼券  biz_code:KEEP_OLD_USER_NO_COUPON, biz_msg:您已收藏该小程序  biz_code:CANCEL_KEEP_OLD_USER_NO_COUPON, biz_msg:您近期已收藏过该小程序  biz_code:ACTIVITY_NOT_EXIST, biz_msg:活动异常，链接失效  biz_code:NOT_START, biz_msg:活动未开始  biz_code:PAUSE, biz_msg:活动已暂停  biz_code:END, biz_msg:活动已结束  biz_code:TIMEOUT, biz_msg:活动已过期  biz_code:NO_COUPON, biz_msg:券无余量  biz_code:UNKNOWN_ERROR, biz_msg:未知异常
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 对应code的中文描述
        /// </summary>
        [JsonProperty("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 查询的小程序id
        /// </summary>
        [JsonProperty("query_app_id")]
        public string QueryAppId { get; set; }
    }
}
