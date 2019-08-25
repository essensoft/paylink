using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OuterTargetingItem Data Structure.
    /// </summary>
    [Serializable]
    public class OuterTargetingItem : AlipayObject
    {
        /// <summary>
        /// 定向类型：  GENDER_TAG_LIST：性别  AGE_TAG_LIST：年龄段  INTEREST_TAG_LIST：兴趣偏好  RESIDENCE_LEVEL_LIST：常住地城市等级  RESIDENCE_TAG_LIST:常住地省市  REGION_LIST: 实时地址  MEDIA_TRADE_LIST:媒体行业  MEDIA_REGION_LIST:媒体省市  CROWD_LIST:行业主题人群  OS_LIST:操作系统  DEVICE_PRICE_LIST:价格区间  DEVICE_BRAND_LIST:品牌  DEVICE_NET_LIST:运营商  DEVICE_NETWORK_LIST:网络类型  DEVICE_TYPE_LIST:设备类型  USER_ACTIVE_TAG_LIST:用户活跃定向  AD_POS_LIST: 广告位定向  OUTER_TAG_LIST: 外部扩展tag定向
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 定向值
        /// </summary>
        [JsonProperty("value_list")]
        public List<string> ValueList { get; set; }
    }
}
