using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderPointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderPointQueryModel : AlipayObject
    {
        /// <summary>
        /// 需要查询的积分类型，如家庭积分、会员积分、返佣积分等等
        /// </summary>
        [JsonProperty("point_type")]
        public string PointType { get; set; }

        /// <summary>
        /// 用户身份
        /// </summary>
        [JsonProperty("user")]
        public UserIdentity User { get; set; }
    }
}
