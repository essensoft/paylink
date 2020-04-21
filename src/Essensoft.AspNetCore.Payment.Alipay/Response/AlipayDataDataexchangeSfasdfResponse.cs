using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataexchangeSfasdfResponse.
    /// </summary>
    public class AlipayDataDataexchangeSfasdfResponse : AlipayResponse
    {
        /// <summary>
        /// dsfagshdj
        /// </summary>
        [JsonPropertyName("azxfghd")]
        public List<string> Azxfghd { get; set; }

        /// <summary>
        /// asghdfsdas阿福故事、
        /// </summary>
        [JsonPropertyName("gfdhsdasafg")]
        public List<string> Gfdhsdasafg { get; set; }

        /// <summary>
        /// fgdhjdsfgh
        /// </summary>
        [JsonPropertyName("gfhjfdsa")]
        public List<string> Gfhjfdsa { get; set; }

        /// <summary>
        /// sdfdhgjfdfsaghjfd
        /// </summary>
        [JsonPropertyName("ghjfdsafgh")]
        public List<string> Ghjfdsafgh { get; set; }

        /// <summary>
        /// sadasff
        /// </summary>
        [JsonPropertyName("sdvsdv")]
        public string Sdvsdv { get; set; }

        /// <summary>
        /// hysasd
        /// </summary>
        [JsonPropertyName("wrty")]
        public List<AlipayItemGoodsList> Wrty { get; set; }
    }
}
