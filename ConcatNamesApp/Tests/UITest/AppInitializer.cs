using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
                ConfigureApp.Android.ApkFile(@"C:\apks\com.companyname.ConcatNamesApp.apk").StartApp();
                return ConfigureApp.Android.StartApp();                
            }

			return ConfigureApp.iOS.StartApp();
		}
	}
}