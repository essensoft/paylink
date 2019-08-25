using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserSceneCooperationConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSceneCooperationConsultModel : AlipayObject
    {
        /// <summary>
        /// 人传人场景码。如果商户需要接入人传人活动建立邀请关系，则需要设置此参数表示人传人场景。当前所有接入人传人的商户统一使用 CommerceService
        /// </summary>
        [JsonProperty("invite_scene")]
        public string InviteScene { get; set; }

        /// <summary>
        /// 商户用来标识自己的合作方ID，可用于人传人下级渠道多级返奖
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 用来标识商户实体，可以是商户的支付宝用户ID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 用户主体信息。要求AlipayUserPrincipalInfo中的user_id、mobile(不加国家码)、email属性，有且只有一个非空。否则接口会忽略除去优先级最高的属性之外的其他属性。user_id优先级最高，mobile次之，email最后
        /// </summary>
        [JsonProperty("principal")]
        public AlipayUserPrincipalInfo Principal { get; set; }

        /// <summary>
        /// 商户的场景定义，需要支付宝对接入场景进行配置。
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }
    }
}
