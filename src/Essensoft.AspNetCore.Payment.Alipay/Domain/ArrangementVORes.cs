using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementVORes Data Structure.
    /// </summary>
    public class ArrangementVORes : AlipayObject
    {
        /// <summary>
        /// 合约基本信息
        /// </summary>
        [JsonPropertyName("ar_base")]
        public ArrangementBaseVO ArBase { get; set; }

        /// <summary>
        /// 合约业务状态
        /// </summary>
        [JsonPropertyName("ar_bsn_status")]
        public string ArBsnStatus { get; set; }

        /// <summary>
        /// 合约条件值,其格式为json，数据key因合约而存在差异。
        /// </summary>
        [JsonPropertyName("ar_condition")]
        public string ArCondition { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }
    }
}
