using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossOrderDiagnosisGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossOrderDiagnosisGetModel : AlipayObject
    {
        /// <summary>
        /// 返回的具体的结果信息，选填
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结束时间，按照yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 发现人，用于表示详细的问题发现者的类别  PFUNDDTS：资金治理服务平台  TIANWEN：淘宝天问平台  TRADEBRAIN：交易大脑  BCP：淘宝业务实时校验平台  DEVELOPER：开发  CUSTOMER_SERVICE：客服
        /// </summary>
        [JsonProperty("find_operator")]
        public string FindOperator { get; set; }

        /// <summary>
        /// 订单号，订单号和外部订单号两者不能同时为空
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号，例如，淘宝订单号；  订单号和外部订单号两者不能同时为空
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 问题发现的来源，有以下几类  OUTSIDE_AUTOMATIC，外部自动发现  INSIDE_AUTOMATIC，内部自动发现  MANUAL_CONSULT，人工咨询
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 开始时间，按照yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
