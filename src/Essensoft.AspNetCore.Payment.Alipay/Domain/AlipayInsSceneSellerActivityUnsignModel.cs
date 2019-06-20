using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneSellerActivityUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneSellerActivityUnsignModel : AlipayObject
    {
        /// <summary>
        /// 渠道账号对应的uid，如果证据类型字段没填则必填
        /// </summary>
        [JsonProperty("channel_account_id")]
        public string ChannelAccountId { get; set; }

        /// <summary>
        /// 渠道账号类型,如果证据类型字段没填则必填1:支付宝账号 2:淘宝账号
        /// </summary>
        [JsonProperty("channel_account_type")]
        public string ChannelAccountType { get; set; }

        /// <summary>
        /// 解约的相关产品编号
        /// </summary>
        [JsonProperty("sp_code")]
        public string SpCode { get; set; }
    }
}
