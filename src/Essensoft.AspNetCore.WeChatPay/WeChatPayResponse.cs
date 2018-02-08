using System.Xml.Serialization;

namespace Essensoft.AspNetCore.WeChatPay
{
    public abstract class WeChatPayResponse : WeChatPayObject
    {
        private string returnCode;
        private string returnMsg;
        private string appId;
        private string mchId;
        private string deviceInfo;
        private string nonceStr;
        private string sign;
        private string resultCode;
        private string resultMsg;
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
        /// 返回信息，如非空，为错误原因
        /// 签名失败
        /// 参数格式校验错误
        /// </summary>
        [XmlElement("return_msg")]
        public string ReturnMsg
        {
            get { return returnMsg; }
            set { returnMsg = value; }
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
        /// 设备号
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo
        {
            get { return deviceInfo; }
            set { deviceInfo = value; }
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
        /// 业务结果
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg
        {
            get { return resultMsg; }
            set { resultMsg = value; }
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
        /// 响应结果是否错误
        /// </summary>
        public bool IsError { get { return returnCode != "SUCCESS"; } }
    }
}
