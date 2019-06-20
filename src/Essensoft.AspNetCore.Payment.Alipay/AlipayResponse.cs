using System;
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
        public virtual string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// 对应 ErrMsg
        /// </summary>
        [JsonProperty("msg")]
        public virtual string Msg { get; set; }

        /// <summary>
        /// 子错误码
        /// 对应 SubErrCode
        /// </summary>
        [JsonProperty("sub_code")]
        public virtual string SubCode { get; set; }

        /// <summary>
        /// 子错误信息
        /// 对应 SubErrMsg
        /// </summary>
        [JsonProperty("sub_msg")]
        public virtual string SubMsg { get; set; }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        [JsonIgnore]
        public virtual string ResponseBody { get; set; }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        [JsonIgnore]
        public virtual bool IsError => !string.IsNullOrEmpty(SubCode);
    }
}
