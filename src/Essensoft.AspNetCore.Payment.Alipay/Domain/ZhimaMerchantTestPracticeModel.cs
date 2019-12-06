using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantTestPracticeModel Data Structure.
    /// </summary>
    public class ZhimaMerchantTestPracticeModel : AlipayObject
    {
        /// <summary>
        /// a d
        /// </summary>
        [JsonPropertyName("add")]
        public List<string> Add { get; set; }

        /// <summary>
        /// zzz
        /// </summary>
        [JsonPropertyName("xxxx")]
        public XXXXsdasdasd Xxxx { get; set; }
    }
}
