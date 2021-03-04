using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiRetailWmsDeliveryorderprocessQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsDeliveryorderprocessQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 物流单据状态列表
        /// </summary>
        [JsonPropertyName("delivery_order_process_vo_list")]
        public List<DeliveryOrderProcessVO> DeliveryOrderProcessVoList { get; set; }
    }
}
