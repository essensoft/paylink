using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RoyaltyEntity Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyEntity : AlipayObject
    {
        /// <summary>
        /// 分账方帐号。当分账方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；当分账方类型是loginName时，本参数为用户的支付宝登录号。
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// 分账关系描述
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 分账方全称，新增分账关系时作为请求参数必填，解绑分账关系时作为请求参数可不填，分账关系查询时不作为返回结果返回
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分账方类型。userId：表示是支付宝账号对应的支付宝唯一用户号；loginName：表示是支付宝登录号。
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
