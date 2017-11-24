using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInviteAwardReceiveModel Data Structure.
    /// </summary>
    public class AlipayUserInviteAwardReceiveModel : AlipayObject
    {
        /// <summary>
        /// 用户扫码抽奖输入的手机号
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
    }
}
