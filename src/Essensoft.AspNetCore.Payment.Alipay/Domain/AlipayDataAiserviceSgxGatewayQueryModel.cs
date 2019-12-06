using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceSgxGatewayQueryModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceSgxGatewayQueryModel : AlipayObject
    {
        /// <summary>
        /// biz_handler: 具体的业务方法名称，该值必须填写。业务方请联系此openapi接口负责人获取业务方法名称。
        /// </summary>
        [JsonPropertyName("biz_handler")]
        public string BizHandler { get; set; }

        /// <summary>
        /// biz_handler_input:  具体业务请求输入的json字符串，必须填写且唯一。该值的具体内容取决于具体业务。
        /// </summary>
        [JsonPropertyName("biz_handler_input")]
        public string BizHandlerInput { get; set; }

        /// <summary>
        /// institution_uuid: 机构ID，该值可选，默认不填写。业务调用方如果需要填写此值，需要联系此openapi接口人获取。
        /// </summary>
        [JsonPropertyName("institution_uuid")]
        public string InstitutionUuid { get; set; }

        /// <summary>
        /// request_uuid: 请求的唯一ID，用于定位请求。该ID用户可以自行生成，每次请求的ID不要重复。
        /// </summary>
        [JsonPropertyName("request_uuid")]
        public string RequestUuid { get; set; }
    }
}
