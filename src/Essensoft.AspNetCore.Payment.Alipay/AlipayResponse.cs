using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 响应。
    /// </summary>
    [Serializable]
    public abstract class AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// 对应 ErrCode
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// 对应 ErrMsg
        /// </summary>
        [JsonProperty("msg")]
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 子错误码
        /// 对应 SubErrCode
        /// </summary>
        [JsonProperty("sub_code")]
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 子错误信息
        /// 对应 SubErrMsg
        /// </summary>
        [JsonProperty("sub_msg")]
        [XmlElement("sub_msg")]
        public string SubMsg { get; set; }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        [JsonIgnore]
        [XmlIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        [JsonIgnore]
        [XmlIgnore]
        public bool IsError => !string.IsNullOrEmpty(SubCode);
    }
}
