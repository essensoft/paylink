using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmServicerecordModifyModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmServicerecordModifyModel : AlipayObject
    {
        /// <summary>
        /// 来电唯一标识
        /// </summary>
        [JsonPropertyName("acid")]
        public string Acid { get; set; }

        /// <summary>
        /// 客服坐席号(软电话中定义的)
        /// </summary>
        [JsonPropertyName("aid")]
        public string Aid { get; set; }

        /// <summary>
        /// 主叫号码
        /// </summary>
        [JsonPropertyName("ani")]
        public string Ani { get; set; }

        /// <summary>
        /// 恒生专用来电唯一标识
        /// </summary>
        [JsonPropertyName("asid")]
        public string Asid { get; set; }

        /// <summary>
        /// 类目信息(详细信息请参考具体类型描述)
        /// </summary>
        [JsonPropertyName("category_list")]
        public ServiceRecordCatRequest CategoryList { get; set; }

        /// <summary>
        /// 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("chat_begin_time")]
        public string ChatBeginTime { get; set; }

        /// <summary>
        /// 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("chat_end_time")]
        public string ChatEndTime { get; set; }

        /// <summary>
        /// 来电地址
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 先挂断方 AGENT:客服 CUSTOMER:客户
        /// </summary>
        [JsonPropertyName("discon_symbol")]
        public string DisconSymbol { get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [JsonPropertyName("dnis")]
        public string Dnis { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonPropertyName("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 创建时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 云客服服务记录ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 服务记录备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [JsonPropertyName("modifier_id")]
        public string ModifierId { get; set; }

        /// <summary>
        /// 外呼任务ID
        /// </summary>
        [JsonPropertyName("outbound_task_id")]
        public string OutboundTaskId { get; set; }

        /// <summary>
        /// 满意度 0:非常满意 1:满意 2:一般 3:不满意 4:非常不满意
        /// </summary>
        [JsonPropertyName("satisfaction")]
        public string Satisfaction { get; set; }

        /// <summary>
        /// 满意度补充信息
        /// </summary>
        [JsonPropertyName("satisfaction_memo")]
        public string SatisfactionMemo { get; set; }

        /// <summary>
        /// 1:客户来电 4:电话回访 5:网点服务 6:在线服务 7:外呼任务 8:手动外呼 9:在线离线留言
        /// </summary>
        [JsonPropertyName("service_source")]
        public string ServiceSource { get; set; }

        /// <summary>
        /// 服务时长(单位:秒)
        /// </summary>
        [JsonPropertyName("service_time")]
        public long ServiceTime { get; set; }

        /// <summary>
        /// 技能组ID
        /// </summary>
        [JsonPropertyName("skillgroup_id")]
        public string SkillgroupId { get; set; }

        /// <summary>
        /// 技能组名称(技能组ID对应的技能组名称)
        /// </summary>
        [JsonPropertyName("skillgroup_name")]
        public string SkillgroupName { get; set; }

        /// <summary>
        /// 1:待处理 2:暂存 3:完结 4:废除 5:无效 6:未知
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 业务租户
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 来访用户唯一标识ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// IVR验证结果 ROLE_N:未定位到用户 CERTNO_Y_PWD_Y:证件号码+交易密码验证通过 CERTNO_Y_PWD_N:证件号码验证通过+交易密码不通过 CERTNO_Y_PWD_UNKNOW:证件号码验证通过 PHONE_Y_PWD_Y:来电手机+交易密码验证通过 PHONE_Y_PWD_N:来电手机+交易密码未通过 PHONE_Y_PWD_UNKNOW:来电手机账户 SEARCH_Y_PWD_Y:搜索定位用户+推屏交易密码通过 SEARCH_Y_PWD_N:搜索定位用户+推屏交易密码未通过 SEARCH_Y_PWD_UNKNOW:搜索定位用户
        /// </summary>
        [JsonPropertyName("verify_result")]
        public string VerifyResult { get; set; }
    }
}
