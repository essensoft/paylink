using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginOrderModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerappPluginOrderModel : AlipayObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 订购的服务商品ID
        /// </summary>
        [JsonPropertyName("merchandise_id")]
        public string MerchandiseId { get; set; }

        /// <summary>
        /// 一二方支持传入appId
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 业务幂等号，规则为商品id+appOrigin+requestId 作为幂等流水号 非必填,不传则默认生成一个8位requestId
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
