using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CorsTest {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API 配置和服务
            var cors = new EnableCorsAttribute("http://192.168.4.179:8080", "*", "*");//全局设置api cors，特性标记和全局都设置会有冲突， 只设置一种
            config.EnableCors(cors);
            
            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
