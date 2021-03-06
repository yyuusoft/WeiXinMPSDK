﻿/*----------------------------------------------------------------
    Copyright (C) 2017 Senparc
    
    文件名：OAuth2Result.cs
    文件功能描述：获取成员信息返回结果
    http://work.weixin.qq.com/api/doc#10028
    
    创建标识：Senparc - 20150313
    
    修改标识：Senparc - 20150313
    修改描述：整理接口
 
    修改标识：Senparc - 20150316
    修改描述：添加DeviceId字段
 
    修改标识：Senparc - 20150316
    修改描述：GetUserIdResult变更为GetUserInfoResult，增加OpenId字段


----------------------------------------------------------------*/

using Senparc.Weixin.Entities;

namespace Senparc.Weixin.Work.AdvancedAPIs.OAuth2
{
    /// <summary>
    /// 获取成员信息返回结果
    /// </summary>
    public class GetUserInfoResult : WorkJsonResult
    {
        /* 
           a) 当用户为企业成员时返回示例如下：

{
   "errcode": 0,
   "errmsg": "ok",
   "UserId":"USERID",
   "DeviceId":"DEVICEID",
   "user_ticket": "USER_TICKET"，
   "expires_in":7200
}

            b) 非企业成员授权时返回示例如下：

{
   "errcode": 0,
   "errmsg": "ok",
   "OpenId":"OPENID",
   "DeviceId":"DEVICEID"
}

    */


        /// <summary>
        /// 员工UserID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 非企业成员的OpenId
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 手机设备号(由企业微信在安装时随机生成，删除重装会改变，升级不受影响)
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 成员票据，最大为512字节。
        /// scope为snsapi_userinfo或snsapi_privateinfo，且用户在应用可见范围之内时返回此参数。
        /// 后续利用该参数可以获取用户信息或敏感信息。
        /// </summary>
        public string user_ticket { get; set; }

        /// <summary>
        /// user_token的有效时间（秒），随user_ticket一起返回
        /// </summary>
        public int expires_in { get; set; }

    }
}
