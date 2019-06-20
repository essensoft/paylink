using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInviteAwardReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserInviteAwardReceiveModel : AlipayObject
    {
        /// <summary>
        /// 用户扫码抽奖输入的手机号，手机号和用户ID必须有一个非空，如果两者都有，则优先取user_id的值作为后续发奖的用户账号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部业务方代码
        /// </summary>
        [JsonProperty("out_biz_code")]
        public string OutBizCode { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，手机号和用户ID必须有一个非空，如果两者都有，则优先取user_id的值作为后续发奖的用户账号
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
