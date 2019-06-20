using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingSellerSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingSellerSignModel : AlipayObject
    {
        /// <summary>
        /// 商户生成的外部业务号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品编码；由蚂蚁保险平台分配，商户通过该产品编码投保特定的保险产品（如饿了么外卖延误险)
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 卖家
        /// </summary>
        [JsonProperty("seller")]
        public InsPerson Seller { get; set; }

        /// <summary>
        /// 签约的用户支付宝id
        /// </summary>
        [JsonProperty("sign_alipay_id")]
        public string SignAlipayId { get; set; }
    }
}
