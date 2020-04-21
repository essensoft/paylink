using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenLotterymallExchangerecordstatusSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenLotterymallExchangerecordstatusSyncModel : AlipayObject
    {
        /// <summary>
        /// 环境信息，PRE预发环境，PROD线上
        /// </summary>
        [JsonPropertyName("env")]
        public string Env { get; set; }

        /// <summary>
        /// json格式的数据
        /// </summary>
        [JsonPropertyName("extinfo")]
        public string Extinfo { get; set; }

        /// <summary>
        /// 积分兑换商城的兑换记录id
        /// </summary>
        [JsonPropertyName("mallexchangerecordid")]
        public string Mallexchangerecordid { get; set; }

        /// <summary>
        /// 该笔订单之前的状态
        /// </summary>
        [JsonPropertyName("now")]
        public string Now { get; set; }

        /// <summary>
        /// 调用方自己创建的订单id，为抽奖调用业务方下单时业务方生成的业务id
        /// </summary>
        [JsonPropertyName("outbizid")]
        public string Outbizid { get; set; }

        /// <summary>
        /// 兑换记录目标状态
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }
    }
}
