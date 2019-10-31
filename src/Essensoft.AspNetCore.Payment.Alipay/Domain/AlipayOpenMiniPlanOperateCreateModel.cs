using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPlanOperateCreateModel : AlipayObject
    {
        /// <summary>
        /// 描述支付后推荐的应用是否属于当前账号，该字段只做展示用, 不应用于业务逻辑, 若属于当前账号则设置为OWN，否则设置为OTHERS, 无法判断的场景传 DEFAULT 即可
        /// </summary>
        [JsonProperty("app_belong")]
        public string AppBelong { get; set; }

        /// <summary>
        /// 收藏有礼活动id，用于绑定支付成功页的有礼活动id
        /// </summary>
        [JsonProperty("gift_template_id")]
        public string GiftTemplateId { get; set; }

        /// <summary>
        /// 支付后推荐代运营的应用id，若type=PUBLICAPP，则为生活号id，若type=TINYAPP，则为小程序id
        /// </summary>
        [JsonProperty("oper_app_id")]
        public string OperAppId { get; set; }

        /// <summary>
        /// 指定创建方案的 pid, 该字段仅白名单应用可用, 其他情况下会被忽略
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 投放配置场景内容
        /// </summary>
        [JsonProperty("plan_content")]
        public List<PlanOperateContent> PlanContent { get; set; }

        /// <summary>
        /// 支付后推荐用于标识方案的名称，方便管理
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 小程序投放方案场景码，目前只支持支付后推荐场景
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 可用的服务能力标签列表。可选的服务能力标签，请参考
        /// </summary>
        [JsonProperty("service_list")]
        public List<string> ServiceList { get; set; }

        /// <summary>
        /// 用于标识支付后推荐的类型，目前只支持小程序和生活号推荐。目前可填的枚举值如下:"TINYAPP"(小程序)，"PUBLICAPP"(生活号), "IOT_MEMBER_CARD" (IOT支付后会员卡开卡)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
