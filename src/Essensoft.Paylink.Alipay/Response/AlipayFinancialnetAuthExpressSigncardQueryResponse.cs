using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthExpressSigncardQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthExpressSigncardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务成功时，且用户有相应的卡，该字段（列表类型）存在
        /// </summary>
        [JsonPropertyName("sign_card_infos")]
        public List<SignCardInfo> SignCardInfos { get; set; }
    }
}
