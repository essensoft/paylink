using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderidApplyModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderidApplyModel : AlipayObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
