using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerContractRecordSyncModel Data Structure.
    /// </summary>
    public class ZhimaCustomerContractRecordSyncModel : AlipayObject
    {
        /// <summary>
        /// 本次业务流程唯一标识，一次电子合约流程中可能存在多次业务操作，比如有多次电子签名，每次业务操作有一个唯一标识，每次业务操作有多次存证记录
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 存证记录的业务发生时间，为格林威治时间从1970年1月1日0点到现在的毫秒数。Java程序里面通过System.currentTimeMillis()获取
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 存证记录业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 存证记录的电子合约号，标识一次完整的电子合约流程，一次电子合约流程会有多次业务流程，比如有多次电子签名，每个业务流程有多次存证记录
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 存证内容，根据biz type不同而不同
        /// </summary>
        [JsonPropertyName("record_content")]
        public string RecordContent { get; set; }
    }
}
