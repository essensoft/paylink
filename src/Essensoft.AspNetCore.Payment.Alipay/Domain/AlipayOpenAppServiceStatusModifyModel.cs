using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceStatusModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceStatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 目标动作 VALID：生效服务，INVALID：失效服务
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 业务来源视角的的服务唯一ID，比如口碑、饿了么的店铺ID或者淘票票的影片ID等
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 数据变更时间戳
        /// </summary>
        [JsonPropertyName("data_timestamp")]
        public string DataTimestamp { get; set; }

        /// <summary>
        /// 服务的业务规格（来源），比如：KOUEI_SERVICE-口碑服务；TPP_SERVICE-淘票票服务
        /// </summary>
        [JsonPropertyName("service_spec_code")]
        public string ServiceSpecCode { get; set; }
    }
}
