using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaAuthInfoAuthqueryModel Data Structure.
    /// </summary>
    public class ZhimaAuthInfoAuthqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前授权查询的类型，分为企业信用产品授权查询和个人信用产品授权查询；默认为个人信用授权查询即为C2B。枚举如下： * C2B：表示个人与商户间授权查询； * C2ConB：表示个人通过商户进行个人互查时授权； * B2B：表示企业授权查询。
        /// </summary>
        [JsonPropertyName("auth_category")]
        public string AuthCategory { get; set; }

        /// <summary>
        /// 身份信息 json 数据，与 identity_type 搭配使用。支持2种方式的入参查询： 1. identity_type＝2 时，表示通过证件三要素查询，入参示例： identity_param＝{"certType":"IDENTITY_CARD","name":"张三","certNo":"33021199003132432"} 2. identity_type＝5时，表示通过userId查询，入参示例： identity_param＝{"userId":"2088xxxxxx"}
        /// </summary>
        [JsonPropertyName("identity_param")]
        public string IdentityParam { get; set; }

        /// <summary>
        /// 标识查询类型，与 identity_param 搭配使用，枚举如下： * 2：表示利用证件号＋姓名＋证件类型 进行查询。 * 5，表示利用 userId 查询。
        /// </summary>
        [JsonPropertyName("identity_type")]
        public string IdentityType { get; set; }
    }
}
