using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdGfsettlePaycontractModifyModel Data Structure.
    /// </summary>
    public class AlipayBossProdGfsettlePaycontractModifyModel : AlipayObject
    {
        /// <summary>
        /// 修改的付款条款信息
        /// </summary>
        [JsonPropertyName("paycontract")]
        public PayContractDTO Paycontract { get; set; }
    }
}
