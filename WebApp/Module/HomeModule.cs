using System;

namespace FP.DotnetInTheBox.BuildMultistage.Module
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get("/", args => $"Hallo Leipzig - {DateTime.Now}");
        }
    }
}