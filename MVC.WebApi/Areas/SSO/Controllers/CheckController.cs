using System;
using System.Web.Http;
using Infrastructure;
using Infrastructure.Cache;
using MVC.App;
using MVC.App.SSO;
using MVC.App.Response;

namespace MVC.WebApi.Areas.SSO.Controllers
{
    public class CheckController : ApiController
    {
        public AuthorizeApp _app { get; set; }
        private ObjCacheProvider<UserAuthSession> _objCacheProvider = new ObjCacheProvider<UserAuthSession>();
        // GET: SSO/Check

        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="request">登录参数</param>
        /// <returns></returns>
        [System.Web.Mvc.HttpPost]
        public LoginResult Login(PassportLoginRequest request)
        {
            var result = new LoginResult();
         
            try
            {
                result = SSOAuthUtil.Parse(request);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.Message;
            }

            return result;
        }

        /// <summary>
        /// 注销登录
        /// </summary>
        /// <param name="token"></param>
        /// <param name="requestid">备用参数.</param>
        [System.Web.Mvc.HttpPost]
        public bool Logout(string token, string requestid = "")
        {
            try
            {
                _objCacheProvider.Remove(token);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}