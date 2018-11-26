using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeCustomsDeclareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCustomsDeclareModel : AlipayObject
    {
        /// <summary>
        /// 报关金额，单位为人民币“元”，精确到小数点后2位。
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订购人身份信息
        /// </summary>
        [JsonProperty("buyer_info")]
        [XmlElement("buyer_info")]
        public CustomsDeclareBuyerInfo BuyerInfo { get; set; }

        /// <summary>
        /// 海关编号（大小写皆可）。参见“ <a href="https://doc.open.alipay.com/docs/doc.htm?treeId=267&articleId=105883&docType=1">海关编号</a>”。
        /// </summary>
        [JsonProperty("customs_place")]
        [XmlElement("customs_place")]
        public string CustomsPlace { get; set; }

        /// <summary>
        /// 商户控制本单是否拆单的报关参数。  仅当该参数传值为T或者t时，才会触发拆单。
        /// </summary>
        [JsonProperty("is_split")]
        [XmlElement("is_split")]
        public string IsSplit { get; set; }

        /// <summary>
        /// 商户在海关备案的编号。
        /// </summary>
        [JsonProperty("merchant_customs_code")]
        [XmlElement("merchant_customs_code")]
        public string MerchantCustomsCode { get; set; }

        /// <summary>
        /// 商户海关备案名称。
        /// </summary>
        [JsonProperty("merchant_customs_name")]
        [XmlElement("merchant_customs_name")]
        public string MerchantCustomsName { get; set; }

        /// <summary>
        /// 报关流水号。商户生成的用于唯一标识一次报关操作的业务编号。  建议生成规则：yyyymmdd型8位日期拼接4位序列号。每个报关请求号仅允许传入：数字、英文字母、下划线”_”、短横线”－” 。长度6-32位前后不能有空格
        /// </summary>
        [JsonProperty("out_request_no")]
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 拆单报关的商户子订单号。 用于区别拆单时不同子单。拆单时必须传入，否则会报INVALID_PARAMETER错误码。
        /// </summary>
        [JsonProperty("sub_out_biz_no")]
        [XmlElement("sub_out_biz_no")]
        public string SubOutBizNo { get; set; }

        /// <summary>
        /// 支付宝交易号。该交易在支付宝系统中的交易流水号，最长64位。
        /// </summary>
        [JsonProperty("trade_no")]
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
