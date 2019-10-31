using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionAuditSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionAuditSubmitModel : AlipayObject
    {
        /// <summary>
        /// 小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以参考https://docs.alipay.com/isv/10325，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。
        /// </summary>
        [JsonProperty("app_category_ids")]
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字，如果不填默认采用当前小程序的应用描述
        /// </summary>
        [JsonProperty("app_desc")]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称，如果不填默认采用当前小程序应用英文名称，3～30个字符
        /// </summary>
        [JsonProperty("app_english_name")]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo图标，图片格式必须为：png、jpeg、jpg，比例必须为1:1，建议上传像素为180*180，不超过256kb， 如果不填默认采用当前小程序应用logo图标
        /// </summary>
        [JsonProperty("app_logo")]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称，如果不填默认采用当前小程序应用名称，名称3-40个字符，一个中文算两个字符
        /// </summary>
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 来源类型，新接入方需要向支付宝申请专用来源，否则不予接入。
        /// </summary>
        [JsonProperty("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能，如果不填默认采用当前小程序应用简介，10~32个字符
        /// </summary>
        [JsonProperty("app_slogan")]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 需要提交审核的小程序版本号，格式为: x.y.z，其中x、y、z均为整型数字，一个应用最多只能有一个审核中、审核通过或者审核驳回的版本。
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端ID，多端场景下区分不同端
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 提交审核营业执照信息，部分小程序类目需要营业执照信息，需要营业执照的类目请参照https://docs.alipay.com/isv/10325
        /// </summary>
        [JsonProperty("license_info")]
        public AuditLicenseInfo LicenseInfo { get; set; }

        /// <summary>
        /// 小程序备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 需要提交审核的小程序appId，面向一方场景，其他场景误用
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 门头照图片地址，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序门头照图片
        /// </summary>
        [JsonProperty("out_door_pic")]
        public string OutDoorPic { get; set; }

        /// <summary>
        /// 小程序所属PID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 小程序应用截图列表，逗号分割，需要2-5张图片，单张图片不能超过4MB，图片格式只支持jpg，png；通过模板实例化小程序不需要传递此参数。
        /// </summary>
        [JsonProperty("screen_shot_list")]
        public List<string> ScreenShotList { get; set; }

        /// <summary>
        /// 小程序客服邮箱，如果不填默认采用当前小程序的应用客服邮箱，和客服电话至少填写一个
        /// </summary>
        [JsonProperty("service_email")]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话，如果不填默认采用当前小程序的应用客服电话，和客服邮箱至少填写一个
        /// </summary>
        [JsonProperty("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 特殊资质图片地址列表，逗号分隔；部分类目需要特殊资质，如果需要特殊资质，最少一张，最多三张。
        /// </summary>
        [JsonProperty("special_license_pic_list")]
        public string SpecialLicensePicList { get; set; }

        /// <summary>
        /// 小程序版本变更描述，30-500个字符，区分于app_desc
        /// </summary>
        [JsonProperty("version_desc")]
        public string VersionDesc { get; set; }
    }
}
