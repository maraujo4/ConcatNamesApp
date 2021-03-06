﻿using System;
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
                //string apkFilePath = @"C:\github\Source\Repos\ConcatNamesApp\ConcatNamesApp\ConcatNamesApp.Android\bin\Release\com.companyname.ConcatNamesApp-Signed.apk";
                //string apkFilePath = @"C:\apks\com.companyname.ConcatNamesApp.apk";

                //string apkFilePath = @"c:\Users\maraujo\Desktop\com.companyname.ConcatNamesApp.apk";
                //ConfigureApp.Android.ApkFile(apkFilePath).StartApp();
                //return ConfigureApp.Android.StartApp();


                return ConfigureApp
                    .Android
                    .ApkFile(@"c:\Users\maraujo\Desktop\com.companyname.ConcatNamesApp.apk")
                    //.InstalledApp("com.companyname.ConcatNamesApp")
                    //.DeviceSerial("SH2AVLY08034")
                    .PreferIdeSettings()
                    .EnableLocalScreenshots()
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}