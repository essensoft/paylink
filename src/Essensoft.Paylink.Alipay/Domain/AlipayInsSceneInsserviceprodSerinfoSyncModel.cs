using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 支付宝的服务产品编号 也就是服务出单接口中收到的那个ant_ser_prod_no
        /// </summary>
        [JsonPropertyName("ant_ser_prod_no")]
        public string AntSerProdNo { get; set; }

        /// <summary>
        /// 支付宝的单据编号
        /// </summary>
        [JsonPropertyName("ser_biz_no")]
        public string SerBizNo { get; set; }

        /// <summary>
        /// 当ser_biz_type=APPLY表示ser_biz_no的值是服务记录编号； 当ser_biz_type=REFUND表示ser_biz_no的值是售中退款单编号； 当ser_biz_type=SURRENDER表示ser_biz_no的值是售后退款单编号
        /// </summary>
        [JsonPropertyName("ser_biz_type")]
        public string SerBizType { get; set; }

        /// <summary>
        /// key是服务信息的标识， value是具体的服务信息List。具体的结构定义请见《服务信息结构定义》
        /// </summary>
        [JsonPropertyName("service_info")]
        public string ServiceInfo { get; set; }
    }
}
