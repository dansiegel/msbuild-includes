using System;
using Android.App;
using Android.Runtime;

namespace WLSample.Droid
{
    [Application(
        Label = "@string/ApplicationName",
        Icon = "@mipmap/icon"
        )]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}