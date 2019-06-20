using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionPromoteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionMissionPromoteModel : AlipayObject
    {
        /// <summary>
        /// 推广主键  identify_type=mission-值必须是任务ID  identify_type=voucher-值必须是券ID
        /// </summary>
        [JsonProperty("identify")]
        public string Identify { get; set; }

        /// <summary>
        /// 推广主键类型  mission-任务  voucher-券
        /// </summary>
        [JsonProperty("identify_type")]
        public string IdentifyType { get; set; }

        /// <summary>
        /// 指定推广活动的名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
