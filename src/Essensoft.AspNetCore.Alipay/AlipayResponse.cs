using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay
{

    public abstract class AlipayResponse
    {
        private string code;
        private string msg;
        private string subCode;
        private string subMsg;
        private string sign;
        private string body;

        /// <summary>
        /// 错误码
        /// 对应 ErrCode
        /// </summary>
        [JsonProperty("code")]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        /// <summary>
        /// 错误信息
        /// 对应 ErrMsg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        /// <summary>
        /// 子错误码
        /// 对应 SubErrCode
        /// </summary>
        [JsonProperty("sub_code")]
        public string SubCode
        {
            get { return subCode; }
            set { subCode = value; }
        }

        /// <summary>
        /// 子错误信息
        /// 对应 SubErrMsg
        /// </summary>
        [JsonProperty("sub_msg")]
        public string SubMsg
        {
            get { return subMsg; }
            set { subMsg = value; }
        }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign
        {
            get { return sign; }
            set { sign = value; }
        }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body
        {
            get { return body; }
            set { body = value; }
        }

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
