using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialAntforestPlantApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestPlantApplyModel : AlipayObject
    {
        /// <summary>
        /// 出账购买树种的账户id
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 兑换类型，默认是ACCOUNT，走account账户扣能量
        /// </summary>
        [JsonProperty("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 接口扩展参数，商户可透传一些信息进来，后续扩展或者透传等作用
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用于幂等操作
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 项目id，需要配合其他查询接口，查询到相关的项目之后使用。不限于树种，还包括保护地等
        /// </summary>
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 发起该行为的支付宝用户 蚂蚁统一会员ID，可选
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
