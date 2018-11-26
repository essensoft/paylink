using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMemberCouponQuerylistResponse.
    /// </summary>
    public class AlipayMemberCouponQuerylistResponse : AlipayResponse
    {
        /// <summary>
        /// 券信息数组.  如果没有查询到券信息，则为数组长度为0。  否则返回券信息数组
        /// </summary>
        [JsonProperty("coupon_list")]
        [XmlArray("coupon_list")]
        [XmlArrayItem("coupon")]
        public List<Coupon> CouponList { get; set; }

        /// <summary>
        /// 请求成功时，不存在本参数；  请求失败时，本参数为错误代码，参见“7  错误码”。
        /// </summary>
        [JsonProperty("error_code")]
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 请求成功时，不存在本参数；  请求失败时，本参数返回具体的错误原因。
        /// </summary>
        [JsonProperty("error_msg")]
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 本轮查询返回的数量
        /// </summary>
        [JsonProperty("list_size")]
        [XmlElement("list_size")]
        public string ListSize { get; set; }

        /// <summary>
        /// 整个业务处理成功时  返回T否则返回F。  具体的错误码和 信息科参考error_code和error_msg信息
        /// </summary>
        [JsonProperty("success_code")]
        [XmlElement("success_code")]
        public string SuccessCode { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_num")]
        [XmlElement("total_num")]
        public string TotalNum { get; set; }
    }
}
