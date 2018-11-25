using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    /// <summary>
    /// 大额行号查询
    /// </summary>
    public class LianLianPayPrcptcdQueryResponse : LianLianPayResponse
    {
        /// <summary>
        /// 请求结果代码 
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 请求结果描述
        /// </summary>
        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 银行编号
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 支行信息
        /// </summary>
        [JsonProperty("card_list", ItemIsReference = true)]
        public List<Brabank> CardList { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }
    }
}
