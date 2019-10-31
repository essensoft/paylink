using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.mini.version.audit.apply
    /// </summary>
    public class AlipayOpenMiniVersionAuditApplyRequest : IAlipayUploadRequest<AlipayOpenMiniVersionAuditApplyResponse>
    {
        /// <summary>
        /// 小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以参考https://docs.alipay.com/isv/10325，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。
        /// </summary>
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字，如果不填默认采用当前小程序的应用描述
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称，如果不填默认采用当前小程序应用英文名称，3～30个字符
        /// </summary>
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo图标，图片格式必须为：png、jpeg、jpg，建议上传像素为180*180，如果不填默认采用当前小程序应用logo图标
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称，如果不填默认采用当前小程序应用名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能，如果不填默认采用当前小程序应用简介，10~32个字符
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// 端参数
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// 第五张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序第五张营业执照照片
        /// </summary>
        public FileItem FifthLicensePic { get; set; }

        /// <summary>
        /// 小程序第五张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem FifthScreenShot { get; set; }

        /// <summary>
        /// 第一张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序第一张营业执照照片
        /// </summary>
        public FileItem FirstLicensePic { get; set; }

        /// <summary>
        /// 实例化的小程序可以不用传第一张应用截图，小程序第一张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem FirstScreenShot { get; set; }

        /// <summary>
        /// 第一张特殊资质图片，不能超过4MB，图片格式只支持jpg、png、jepg，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325 中是否需要特殊资质，如果不填默认采用当前小程序第一张特殊资质
        /// </summary>
        public FileItem FirstSpecialLicensePic { get; set; }

        /// <summary>
        /// 第四张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序第四张营业执照照片
        /// </summary>
        public FileItem FourthLicensePic { get; set; }

        /// <summary>
        /// 小程序第四张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem FourthScreenShot { get; set; }

        /// <summary>
        /// 营业执照名称，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填类目采用当前小程序应用营业执照名称。
        /// </summary>
        public string LicenseName { get; set; }

        /// <summary>
        /// 营业执照号，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序应用营业执照号。
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 营业执照有效期，格式为yyyy-MM-dd，9999-12-31表示长期，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序营业执照有效期
        /// </summary>
        public string LicenseValidDate { get; set; }

        /// <summary>
        /// 小程序备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 门头照图片，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序门头照图片
        /// </summary>
        public FileItem OutDoorPic { get; set; }

        /// <summary>
        /// 小程序服务区域类型，GLOBAL-全球，CHINA-中国，LOCATION-指定区域
        /// </summary>
        public string RegionType { get; set; }

        /// <summary>
        /// 第二张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序第二张营业执照照片
        /// </summary>
        public FileItem SecondLicensePic { get; set; }

        /// <summary>
        /// 实例化的小程序可以不用传第二张应用截图，小程序第二张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem SecondScreenShot { get; set; }

        /// <summary>
        /// 第二张特殊资质图片文件，不能超过4MB，图片格式只支持jpg、png、jepg，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325 中是否需要特殊资质，如果不填默认采用当前小程序第二张特殊资质图片
        /// </summary>
        public FileItem SecondSpecialLicensePic { get; set; }

        /// <summary>
        /// 小程序客服邮箱，如果不填默认采用当前小程序的应用客服邮箱
        /// </summary>
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话，如果不填默认采用当前小程序的应用客服电话
        /// </summary>
        public string ServicePhone { get; set; }

        /// <summary>
        /// 省市区信息，当区域类型为LOCATION时，不能为空，province_code不能为空，当填写city_code时，province_code不能为空，当填写area_code时，province_code和city_code不能为空。只填province_code时，该省全部选择；province_code和city_code都填时，该市全部选择。province_code，city_code和area_code都填时，该县全部选择。具体code可以参考https://docs.alipay.com/isv/10327
        /// </summary>
        public List<RegionInfo> ServiceRegionInfo { get; set; }

        /// <summary>
        /// 测试账号
        /// </summary>
        public string TestAccout { get; set; }

        /// <summary>
        /// 测试附件，请上传10M以内附件，支持格式zip,rar
        /// </summary>
        public FileItem TestFileName { get; set; }

        /// <summary>
        /// 测试账号密码
        /// </summary>
        public string TestPassword { get; set; }

        /// <summary>
        /// 第三张营业执照照片，不能超过4MB，图片格式只支持jpg，png，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要营业执照信息，如果不填默认采用当前小程序第三张营业执照照片
        /// </summary>
        public FileItem ThirdLicensePic { get; set; }

        /// <summary>
        /// 小程序第三张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem ThirdScreenShot { get; set; }

        /// <summary>
        /// 第三张特殊资质图片文件，不能超过4MB，图片格式只支持jpg、png、jepg，部分小程序类目需要提交，参照https://docs.alipay.com/isv/10325中是否需要特殊资质，如果不填默认采用当前小程序第三张特殊资质
        /// </summary>
        public FileItem ThirdSpecialLicensePic { get; set; }

        /// <summary>
        /// 小程序版本描述，30-500个字符
        /// </summary>
        public string VersionDesc { get; set; }

        #region IAlipayRequest Members
        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {

            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.mini.version.audit.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "app_category_ids", AppCategoryIds },
                { "app_desc", AppDesc },
                { "app_english_name", AppEnglishName },
                { "app_name", AppName },
                { "app_slogan", AppSlogan },
                { "app_version", AppVersion },
                { "bundle_id", BundleId },
                { "license_name", LicenseName },
                { "license_no", LicenseNo },
                { "license_valid_date", LicenseValidDate },
                { "memo", Memo },
                { "region_type", RegionType },
                { "service_email", ServiceEmail },
                { "service_phone", ServicePhone },
                { "service_region_info", ServiceRegionInfo },
                { "test_accout", TestAccout },
                { "test_password", TestPassword },
                { "version_desc", VersionDesc }
            };
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>
            {
                { "app_logo", AppLogo },
                { "fifth_license_pic", FifthLicensePic },
                { "fifth_screen_shot", FifthScreenShot },
                { "first_license_pic", FirstLicensePic },
                { "first_screen_shot", FirstScreenShot },
                { "first_special_license_pic", FirstSpecialLicensePic },
                { "fourth_license_pic", FourthLicensePic },
                { "fourth_screen_shot", FourthScreenShot },
                { "out_door_pic", OutDoorPic },
                { "second_license_pic", SecondLicensePic },
                { "second_screen_shot", SecondScreenShot },
                { "second_special_license_pic", SecondSpecialLicensePic },
                { "test_file_name", TestFileName },
                { "third_license_pic", ThirdLicensePic },
                { "third_screen_shot", ThirdScreenShot },
                { "third_special_license_pic", ThirdSpecialLicensePic }
            };
            return parameters;
        }

        #endregion
    }
}
