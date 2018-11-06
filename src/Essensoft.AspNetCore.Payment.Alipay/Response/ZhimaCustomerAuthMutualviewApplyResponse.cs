using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerAuthMutualviewApplyResponse.
    /// </summary>
    public class ZhimaCustomerAuthMutualviewApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 查询用户信用状态的id
        /// </summary>
        [JsonProperty("auth_id")]
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 取消授权结果，true为成功，false为失败，其他值表示非取消授权的操作
        /// </summary>
        [JsonProperty("cancel_result")]
        [XmlElement("cancel_result")]
        public string CancelResult { get; set; }

        /// <summary>
        /// 用于展示本次查询结果的描述，例如信用良好，信用一般
        /// </summary>
        [JsonProperty("describe")]
        [XmlElement("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 本次业务操作的错误码
        /// </summary>
        [JsonProperty("error_code")]
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 本次业务操作的错误描述
        /// </summary>
        [JsonProperty("error_message")]
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 此值接口提供方不做消费，仅用来给商户端透传的字段；用于商户端在调用此接口时回传到自己的业务逻辑中，用于自己的业务逻辑校验使用的；  此值的来源参见接口入参中的ext_biz_param 中
        /// </summary>
        [JsonProperty("outer_sign")]
        [XmlElement("outer_sign")]
        public string OuterSign { get; set; }
    }
}
