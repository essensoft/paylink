using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubCertDetail Data Structure.
    /// </summary>
    public class SubCertDetail : AlipayObject
    {
        /// <summary>
        /// 凭证批次号
        /// </summary>
        [JsonPropertyName("lot_num")]
        public string LotNum { get; set; }

        /// <summary>
        /// 子凭证有效点数
        /// </summary>
        [JsonPropertyName("lot_point")]
        public string LotPoint { get; set; }

        /// <summary>
        /// 子凭证编号
        /// </summary>
        [JsonPropertyName("sub_lotnum")]
        public string SubLotnum { get; set; }
    }
}
