using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaAuthInfoAuthqueryModel Data Structure.
    /// </summary>
    public class ZhimaAuthInfoAuthqueryModel : AlipayObject
    {
        /// <summary>
        /// 用于标识当前授权查询的类型，分为企业信用产品授权查询和个人信用产品授权查询；默认为个人信用授权查询即为C2B；  个人与商户间授权查询则传入C2B；  个人通过商户进行个人互查时授权则传入C2ConB；  企业授权查询则传入B2B；
        /// </summary>
        [JsonPropertyName("auth_category")]
        public string AuthCategory { get; set; }

        /// <summary>
        /// json格式的内容；支持2种方式的入参查询：  1. 通过证件三要素查询时：  identity_type＝2  identity_param＝{"certType":"IDENTITY_CARD","name":"张三","certNo":"33021199003132432"}  2. 通过userId查询时：   identity_type＝5  identity_param＝{"userId":"2088xxxxxx"}
        /// </summary>
        [JsonPropertyName("identity_param")]
        public string IdentityParam { get; set; }

        /// <summary>
        /// 标识当前查询的类型：   2，表示传入证件号＋姓名＋证件类型 进行查询  5，表示传入userId查询；
        /// </summary>
        [JsonPropertyName("identity_type")]
        public string IdentityType { get; set; }
    }
}
