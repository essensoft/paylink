using System.Xml.Serialization;

namespace Essensoft.AspNetCore.QPay
{
    public abstract class QPayNotifyResponse : QPayObject
    {
        private string appid;
        private string mchid;
        private string noncestr;
        private string sign;

        /// <summary>
        /// 公众账号ID
        /// </summary>
        [XmlElement("appid")]
        public string AppId
        {
            get { return appid; }
            set { appid = value; }
        }

        /// <summary>
        /// 商户号ID
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId
        {
            get { return mchid; }
            set { mchid = value; }
        }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr
        {
            get { return noncestr; }
            set { noncestr = value; }
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
    }
}
