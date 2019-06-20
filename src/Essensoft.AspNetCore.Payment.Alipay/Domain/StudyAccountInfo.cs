using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StudyAccountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StudyAccountInfo : AlipayObject
    {
        /// <summary>
        /// 校园卡ID
        /// </summary>
        [JsonProperty("alipay_card_no")]
        public string AlipayCardNo { get; set; }

        /// <summary>
        /// 校园卡类型
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 支付宝终身学习账户id
        /// </summary>
        [JsonProperty("study_id")]
        public string StudyId { get; set; }
    }
}
