using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementVORes Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementVORes : AlipayObject
    {
        /// <summary>
        /// 合约基本信息
        /// </summary>
        [JsonProperty("ar_base")]
        public ArrangementBaseVO ArBase { get; set; }

        /// <summary>
        /// 合约业务状态
        /// </summary>
        [JsonProperty("ar_bsn_status")]
        public string ArBsnStatus { get; set; }

        /// <summary>
        /// 合约条件值,其格式为json，数据key因合约而存在差异。
        /// </summary>
        [JsonProperty("ar_condition")]
        public string ArCondition { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonProperty("arrangement_no")]
        public string ArrangementNo { get; set; }
    }
}
