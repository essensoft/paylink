using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfsettlePaycontractQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询条件
        /// </summary>
        [JsonPropertyName("pay_contract_base_dto")]
        public PayContractBaseDTO PayContractBaseDto { get; set; }
    }
}
