using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodContractCheckavailableModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInsserviceprodContractCheckavailableModel : AlipayObject
    {
        /// <summary>
        /// 支付宝的服务合约编号 (服务出单接口中携带的那个)
        /// </summary>
        [JsonPropertyName("ant_ser_contract_no")]
        public string AntSerContractNo { get; set; }
    }
}
