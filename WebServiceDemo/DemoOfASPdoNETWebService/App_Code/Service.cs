using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    //[WebMethod]
    //public string HelloWorld() {
    //    return "Hello World";
    //}
    [WebMethod(Description = "求和的方法")]
    public double addition(double i, double j)
    {
        return i + j;
    }
    [WebMethod(Description = "求差的方法")]
    public double subtract(double i, double j)
    {
        return i - j;
    }
    [WebMethod(Description = "求积的方法")]
    public double multiplication(double i, double j)
    {
        return i * j;
    }
    [WebMethod(Description = "求商的方法")]
    public double division(double i, double j)
    {
        if (j != 0)
            return i / j;
        else
            return 0;
    }   
}