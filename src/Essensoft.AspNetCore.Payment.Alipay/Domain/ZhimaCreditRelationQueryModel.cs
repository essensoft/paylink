using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditRelationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditRelationQueryModel : AlipayObject
    {
        /// <summary>
        /// 申请人证件号，中国大陆18或者15位合法身份号
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 芝麻平台服务商模式下的二级商户标识，如果是直连商户调用该接口，不需要设置
        /// </summary>
        [JsonProperty("linked_merchant_id")]
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// 申请人证件姓名，简体中文，长度不超过64，姓名中不含",","/u0001"，"|","&","^","\\"等特殊字符
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 产品码，标记商户接入的具体产品；直接使用每个接口入参中示例值即可
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 申请人与联系人之间关系类型，目前支持4类关系，family(亲友)、workmate(同事)、schoolmate(同学)、friend(朋友)
        /// </summary>
        [JsonProperty("relation")]
        public string Relation { get; set; }

        /// <summary>
        /// 联系人姓名，简体中文，长度不超过64，姓名中不含",","/u0001"，"|","&","^","\\"等特殊字符
        /// </summary>
        [JsonProperty("relation_name")]
        public string RelationName { get; set; }

        /// <summary>
        /// 手机号码。中国大陆合法手机号，长度11位，不含国家代码
        /// </summary>
        [JsonProperty("relation_phone")]
        public string RelationPhone { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，长度64位以内字符串，仅限字母数字下划线组合。该标识作为业务调用的唯一标识，商户要保证其业务唯一性，使用相同transaction_id的查询，芝麻在一段时间内（一般为1天）返回首次查询结果，超过有效期的查询即为无效并返回异常，有效期内的重复查询不重新计费
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
