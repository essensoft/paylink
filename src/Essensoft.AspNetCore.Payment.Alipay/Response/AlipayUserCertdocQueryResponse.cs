using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertdocQueryResponse.
    /// </summary>
    public class AlipayUserCertdocQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 进行授权的用户本人的驾驶证信息
        /// </summary>
        [JsonPropertyName("driving_license")]
        public AlipayUserCertDocDrivingLicense DrivingLicense { get; set; }

        /// <summary>
        /// 所有驾驶证信息列表
        /// </summary>
        [JsonPropertyName("driving_license_list")]
        public List<AlipayUserCertDocDrivingLicense> DrivingLicenseList { get; set; }

        /// <summary>
        /// 进行授权的用户本人的身份证信息
        /// </summary>
        [JsonPropertyName("identity_card")]
        public AlipayUserCertDocIDCard IdentityCard { get; set; }

        /// <summary>
        /// 所有身份证信息列表
        /// </summary>
        [JsonPropertyName("identity_card_list")]
        public List<AlipayUserCertDocIDCard> IdentityCardList { get; set; }

        /// <summary>
        /// 护照列表
        /// </summary>
        [JsonPropertyName("passport_list")]
        public List<AlipayUserCertDocPassport> PassportList { get; set; }

        /// <summary>
        /// 进行授权的用户本人的行驶证信息列表
        /// </summary>
        [JsonPropertyName("self_vehicle_license_list")]
        public List<AlipayUserCertDocVehicleLicense> SelfVehicleLicenseList { get; set; }

        /// <summary>
        /// 所有行驶证信息列表
        /// </summary>
        [JsonPropertyName("vehicle_license_list")]
        public List<AlipayUserCertDocVehicleLicense> VehicleLicenseList { get; set; }
    }
}
