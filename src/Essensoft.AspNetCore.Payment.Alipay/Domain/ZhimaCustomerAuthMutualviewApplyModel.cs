using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerAuthMutualviewApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerAuthMutualviewApplyModel : AlipayObject
    {
        /// <summary>
        /// 当前业务操作是查询自己还是查询别人的芝麻分，接口提供方分配的值：  self ：标识查询自己的分数或者做业务授权时也需要传入此值  other ： 标识需要查询别人的分数
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户回调的url，业务操作完成后会在此url上追加返回参数
        /// </summary>
        [JsonProperty("callback_url")]
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 用户传递扩展类的信息，例如传入当前用户的logo，昵称等，用于业务页面上的展示，此值为一个Map类型的json串字符，传入规则如下：  {"key1":"val2","key2":"val2"}
        /// </summary>
        [JsonProperty("ext_biz_param")]
        [XmlElement("ext_biz_param")]
        public string ExtBizParam { get; set; }

        /// <summary>
        /// 个人身份信息入参：  1. 若做业务授权请求请传入身份三要素，如下：   {"certType":"IDENTITY_CARD","name":"张三","certNo":"654326198805xxxx9"}  2. 若为查询自己或者别人的信用状态，请传入userId，如下：  {"userId":"2088xxxx281848"}    针对各个字段的描述如下：  certType:证件类型固定为身份证，传入IDENTITY_CARD；  name:用户姓名，如张三  certNo:身份证号码  userId:此值为查询时的必要入参，此值的来源为授权完成后返回的mutual_view_id字段，可以参见接口返回值中的出参
        /// </summary>
        [JsonProperty("identity_param")]
        [XmlElement("identity_param")]
        public string IdentityParam { get; set; }
    }
}
