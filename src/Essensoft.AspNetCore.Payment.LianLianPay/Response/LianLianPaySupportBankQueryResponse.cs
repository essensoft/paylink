using Essensoft.AspNetCore.Payment.LianLianPay.Domain;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    public class LianLianPaySupportBankQueryResponse : LianLianPayResponse
    {
        /// <summary>
        /// 交易结果代码 
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 交易结果描述
        /// </summary>
        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 支持银行列表
        /// </summary>
        [JsonProperty("support_banklist")]
        public List<SupportBank> SupportBanklist { get; set; }
    }
}
