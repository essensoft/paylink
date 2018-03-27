using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("add")]
        public List<string> Add { get; set; }

        /// <summary>
        /// zzz
        /// </summary>
        [JsonProperty("xxxx")]
        public XXXXsdasdasd Xxxx { get; set; }
    }
}
