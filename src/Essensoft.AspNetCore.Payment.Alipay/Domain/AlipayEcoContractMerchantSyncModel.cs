using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoContractMerchantSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoContractMerchantSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 商家配置信息
        /// </summary>
        [JsonPropertyName("merchant_configs")]
        public List<MerchantConfigRequest> MerchantConfigs { get; set; }

        /// <summary>
        /// 签署平台的代码
        /// </summary>
        [JsonPropertyName("sign_platform_code")]
        public string SignPlatformCode { get; set; }
    }
}
