using System.Xml.Serialization;

namespace Essensoft.Paylink.WeChatPay.V2.Response
{
    [XmlRoot("xml")]
    public class WeChatPayProfitSharingMerchantRatioQueryResponse : WeChatPayResponse
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 品牌主商户号
        /// </summary>
        [XmlElement("brand_mch_id")]
        public string BrandMchId { get; set; }

        /// <summary>
        /// 最大分账比例
        /// </summary>
        [XmlElement("max_ratio")]
        public int MaxRatio { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }
    }
}
