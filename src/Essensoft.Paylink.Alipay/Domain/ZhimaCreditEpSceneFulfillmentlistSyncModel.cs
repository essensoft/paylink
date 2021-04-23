using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentlistSyncModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpSceneFulfillmentlistSyncModel : AlipayObject
    {
        /// <summary>
        /// 信用订单号，为<a href="https://opendocs.alipay.com/apis/api_8/zhima.credit.ep.scene.agreement.use">zhima.credit.ep.scene.agreement.use</a>接口加入信用服务后获取的credit_order_no（信用订单号）。
        /// </summary>
        [JsonPropertyName("credit_order_no")]
        public string CreditOrderNo { get; set; }

        /// <summary>
        /// 履约信息列表，最大不超过200项
        /// </summary>
        [JsonPropertyName("fulfillment_info_list")]
        public List<FulfillmentInfo> FulfillmentInfoList { get; set; }
    }
}
