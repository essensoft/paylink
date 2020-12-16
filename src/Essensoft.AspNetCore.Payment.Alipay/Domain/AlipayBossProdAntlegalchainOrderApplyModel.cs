using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainOrderApplyModel Data Structure.
    /// </summary>
    public class AlipayBossProdAntlegalchainOrderApplyModel : AlipayObject
    {
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
        /// 业务数据请求唯一标识,唯一
        /// </summary>
        [JsonPropertyName("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 我方经办人工号(内部buc工号)
        /// </summary>
        [JsonPropertyName("main_agent_buc_user_no")]
        public string MainAgentBucUserNo { get; set; }

        /// <summary>
        /// 我方经办人真实姓名
        /// </summary>
        [JsonPropertyName("main_agent_person_cert_name")]
        public string MainAgentPersonCertName { get; set; }

        /// <summary>
        /// 我方经办人证件上的身份证号
        /// </summary>
        [JsonPropertyName("main_agent_person_cert_no")]
        public string MainAgentPersonCertNo { get; set; }

        /// <summary>
        /// 我方签约公司信息：公司名称(必传)   公司支付宝账号(可传)   公司统一社会信用编码(可传)
        /// </summary>
        [JsonPropertyName("main_corp_entity")]
        public CorpEntity MainCorpEntity { get; set; }

        /// <summary>
        /// 我方通知人邮箱地址
        /// </summary>
        [JsonPropertyName("main_corp_notify_email")]
        public string MainCorpNotifyEmail { get; set; }

        /// <summary>
        /// 我方通知人姓名
        /// </summary>
        [JsonPropertyName("main_corp_notify_name")]
        public string MainCorpNotifyName { get; set; }

        /// <summary>
        /// 我方通知人手机号
        /// </summary>
        [JsonPropertyName("main_corp_notify_phone")]
        public string MainCorpNotifyPhone { get; set; }

        /// <summary>
        /// 签约文件对象信息列表
        /// </summary>
        [JsonPropertyName("notary_file_list")]
        public List<NotaryFileVO> NotaryFileList { get; set; }

        /// <summary>
        /// 签约相对方企业信息: 对方公司支付宝账号（必传） 公司名称（必传） 统一社会信用编码（必传）
        /// </summary>
        [JsonPropertyName("rela_corp_entity")]
        public CorpEntity RelaCorpEntity { get; set; }

        /// <summary>
        /// 对方通知人邮箱地址
        /// </summary>
        [JsonPropertyName("rela_corp_notify_email")]
        public string RelaCorpNotifyEmail { get; set; }

        /// <summary>
        /// 对方通知人手机号
        /// </summary>
        [JsonPropertyName("rela_corp_notify_phone")]
        public string RelaCorpNotifyPhone { get; set; }

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
        /// 签约顺序, 1表示我方先签约; 2表示对方先签约. （可传，若不传，默认值为1，即“我方先签约”）
        /// </summary>
        [JsonPropertyName("sign_order")]
        public long SignOrder { get; set; }

        /// <summary>
        /// 发起签约时间/我方签约时间
        /// </summary>
        [JsonPropertyName("submit_time")]
        public string SubmitTime { get; set; }
    }
}
