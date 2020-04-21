using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OcrIdentifyResult Data Structure.
    /// </summary>
    public class OcrIdentifyResult : AlipayObject
    {
        /// <summary>
        /// 当识别驾驶证时，返回家庭住址；
        /// </summary>
        [JsonPropertyName("addr")]
        public string Addr { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回注册地址；  当识别身份证时，返回家庭住址；
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 当识别身份证时，返回生日
        /// </summary>
        [JsonPropertyName("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回经营范围
        /// </summary>
        [JsonPropertyName("business")]
        public string Business { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回注册资本
        /// </summary>
        [JsonPropertyName("captial")]
        public string Captial { get; set; }

        /// <summary>
        /// 当识别银行卡时，返回银行卡号
        /// </summary>
        [JsonPropertyName("card_num")]
        public string CardNum { get; set; }

        /// <summary>
        /// 调用结果编码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 当识别驾驶证时，返回证件有效期结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回发动机号
        /// </summary>
        [JsonPropertyName("engine_num")]
        public string EngineNum { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回注册时间
        /// </summary>
        [JsonPropertyName("establish_date")]
        public string EstablishDate { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回发证日期
        /// </summary>
        [JsonPropertyName("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 调用结果说明
        /// </summary>
        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回公司名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 当识别身份证时，返回民族
        /// </summary>
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 当识别驾驶证时，返回证件号码；  当识别身份证时，返回身份证号码；
        /// </summary>
        [JsonPropertyName("num")]
        public string Num { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回所有人
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回公司法人
        /// </summary>
        [JsonPropertyName("person")]
        public string Person { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回车牌
        /// </summary>
        [JsonPropertyName("plate_num")]
        public string PlateNum { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回注册编号
        /// </summary>
        [JsonPropertyName("reg_num")]
        public string RegNum { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回注册时间
        /// </summary>
        [JsonPropertyName("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// request_id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 当识别身份证时，返回性别
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 当识别驾驶证时，返回证件有效期起始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 识别是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }

        /// <summary>
        /// trace_id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回使用性质
        /// </summary>
        [JsonPropertyName("use_character")]
        public string UseCharacter { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回有效期
        /// </summary>
        [JsonPropertyName("valid_period")]
        public string ValidPeriod { get; set; }

        /// <summary>
        /// 当识别驾驶证时，返回证件准驾车型；  当识别行驶证时，返回车辆类型；
        /// </summary>
        [JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 当识别车架号时，返回车架号；  当识别行驶证时，返回车辆识别代号；
        /// </summary>
        [JsonPropertyName("vin")]
        public string Vin { get; set; }
    }
}
