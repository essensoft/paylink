using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiSignQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiSignQueryResponse : AlipayObject
    {
        /// <summary>
        /// 用户签约成功后的协议号
        /// </summary>
        [JsonProperty("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 协议失效时间，格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。
        /// </summary>
        [JsonProperty("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 签约主体类型。  CARD:支付宝账号  CUSTOMER:支付宝用户
        /// </summary>
        [JsonProperty("pricipal_type")]
        public string PricipalType { get; set; }

        /// <summary>
        /// 签约主体标识。  当principal_type为CARD 时，该字段为支付宝用户号;  当principal_type为 CUSTOMER 时，该字段为支付宝用户标识。一个用户 可能有多个支付宝账号，即多个支付宝用户号，但只有一个是支付宝用户标识。  一个支付宝账号对应一个支付宝唯一用户号(以2088开头的16位纯数字组成)。
        /// </summary>
        [JsonProperty("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 签约协议的场景。
        /// </summary>
        [JsonProperty("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 协议签约时间，格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("sign_time")]
        public string SignTime { get; set; }

        /// <summary>
        /// 协议当前状态  1. TEMP：暂存，协议未生效过；  2. NORMAL：正常；  3. STOP：暂停
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。  取值范围：  1. PARTNER（平台商户）;  2. MERCHANT（集团商户），集团下子商户可共享用户签约内容;  默认为PARTNER。
        /// </summary>
        [JsonProperty("third_party_type")]
        public string ThirdPartyType { get; set; }

        /// <summary>
        /// 协议生效时间，格式为 yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("valid_time")]
        public string ValidTime { get; set; }
    }
}
