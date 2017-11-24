using System.Xml.Serialization;

namespace Essensoft.AspNetCore.QPay
{
    public abstract class QPayResponse : QPayObject
    {
        private string returnCode;
        private string returnMsg;
        private string retCode;
        private string retMsg;
        private string appId;
        private string mchId;
        private string nonceStr;
        private string sign;
        private string resultCode;
        private string errCode;
        private string errCodeDes;

        /// <summary>
        /// 返回状态码
        /// 此字段是通信标识，非交易标识，
        /// 交易是否成功需要查看result_code来判断
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode
        {
            get { return returnCode; }
            set { returnCode = value; }
        }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("return_msg")]
        public string ReturnMsg
        {
            get { return returnMsg; }
            set { returnMsg = value; }
        }

        /// <summary>
        /// 手Q CGI原始错误码
        /// </summary>
        [XmlElement("retcode")]
        public string RetCode
        {
            get { return retCode; }
            set { retCode = value; }
        }

        /// <summary>
        /// 手Q CGI原始错误信息
        /// </summary>
        [XmlElement("retmsg")]
        public string RetMsg
        {
            get { return retMsg; }
            set { retMsg = value; }
        }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId
        {
            get { return appId; }
            set { appId = value; }
        }

        /// <summary>
        /// 商户号ID
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId
        {
            get { return mchId; }
            set { mchId = value; }
        }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign
        {
            get { return sign; }
            set { sign = value; }
        }

        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode
        {
            get { return resultCode; }
            set { resultCode = value; }
        }

        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode
        {
            get { return errCode; }
            set { errCode = value; }
        }

        /// <summary>
        /// 错误描述	
        /// </summary>
        [XmlElement("err_code_des")]
        public string ErrCodeDes
        {
            get { return errCodeDes; }
            set { errCodeDes = value; }
        }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr
        {
            get { return nonceStr; }
            set { nonceStr = value; }
        }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        public bool IsError { get { return returnCode != "SUCCESS"; } }
    }
}
