using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceShoppingmallrecVoucherQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceShoppingmallrecVoucherQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 本次推荐的id, 开发者埋点需带入此参数
        /// </summary>
        [JsonProperty("recommend_id")]
        [XmlElement("recommend_id")]
        public string RecommendId { get; set; }

        /// <summary>
        /// 本次请求的全局唯一标识, 支持英文字母和数字, 由开发者自行定义,和入参request_id一致
        /// </summary>
        [JsonProperty("request_id")]
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 商场券的推荐列表
        /// </summary>
        [JsonProperty("voucher_recommend_list")]
        [XmlArray("voucher_recommend_list")]
        [XmlArrayItem("voucher_rec")]
        public List<VoucherRec> VoucherRecommendList { get; set; }
    }
}
