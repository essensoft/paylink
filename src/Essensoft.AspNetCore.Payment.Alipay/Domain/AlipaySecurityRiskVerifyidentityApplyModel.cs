using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskVerifyidentityApplyModel : AlipayObject
    {
        /// <summary>
        /// 用户帐号
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 帐号类型：ALIPAY_USERID,CERT
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 接入业务方业务唯一性id
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务信息上下文，JSON结构
        /// </summary>
        [JsonProperty("biz_params")]
        public string BizParams { get; set; }

        /// <summary>
        /// 身份核验场景CODE，商务谈判基础上，由支付宝来分配。
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 待校验的核身产品集合
        /// </summary>
        [JsonProperty("validate_product_group")]
        public string ValidateProductGroup { get; set; }
    }
}
