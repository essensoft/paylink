using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainMultipartyApplyModel Data Structure.
    /// </summary>
    public class AlipayBossProdAntlegalchainMultipartyApplyModel : AlipayObject
    {
        /// <summary>
        /// 申请人工号(内部buc工号)
        /// </summary>
        [JsonPropertyName("apply_buc_user_no")]
        public string ApplyBucUserNo { get; set; }

        /// <summary>
        /// 关联业务数据编号
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 关联业务名称
        /// </summary>
        [JsonPropertyName("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 业务数据请求唯一标识
        /// </summary>
        [JsonPropertyName("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 所有签约方企业信息列表(支持多方签约, 任何一方支持多家公司主体)
        /// </summary>
        [JsonPropertyName("corp_entity_multi_list")]
        public List<CorpEntity> CorpEntityMultiList { get; set; }

        /// <summary>
        /// 签约发起方企业信息
        /// </summary>
        [JsonPropertyName("init_corp_entity")]
        public CorpEntity InitCorpEntity { get; set; }

        /// <summary>
        /// 签约文件对象信息列表
        /// </summary>
        [JsonPropertyName("notary_file_list")]
        public List<NotaryFileVO> NotaryFileList { get; set; }

        /// <summary>
        /// 请求来源系统英文名称
        /// </summary>
        [JsonPropertyName("request_app_name")]
        public string RequestAppName { get; set; }

        /// <summary>
        /// 请求时间戳（请求时间的毫秒值）
        /// </summary>
        [JsonPropertyName("request_time_stamp")]
        public string RequestTimeStamp { get; set; }

        /// <summary>
        /// 请求token
        /// </summary>
        [JsonPropertyName("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 签约顺序类型 (值为IN_ORDER: 有顺序; 值为NON_ORDER: 无顺序)；默认为“有顺序”
        /// </summary>
        [JsonPropertyName("sign_order_type")]
        public string SignOrderType { get; set; }

        /// <summary>
        /// 发起签约时间/我方签约时间
        /// </summary>
        [JsonPropertyName("submit_time")]
        public string SubmitTime { get; set; }
    }
}
