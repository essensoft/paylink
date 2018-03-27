using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public abstract class AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// 对应 ErrCode
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// 对应 ErrMsg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 子错误码
        /// 对应 SubErrCode
        /// </summary>
        [JsonProperty("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// 子错误信息
        /// 对应 SubErrMsg
        /// </summary>
        [JsonProperty("sub_msg")]
        public string SubMsg { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        public bool IsError
        {
            get
            {
                return !string.IsNullOrEmpty(SubCode);
            }
        }
    }
}
