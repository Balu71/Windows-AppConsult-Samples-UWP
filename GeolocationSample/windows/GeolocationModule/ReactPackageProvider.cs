﻿using Microsoft.ReactNative;
using Microsoft.ReactNative.Managed;

namespace GeolocationModule
{
    public sealed class ReactPackageProvider: IReactPackageProvider
    {
        public void CreatePackage(IReactPackageBuilder packageBuilder)
        {
            packageBuilder.AddAttributedModules();
        }
    }
}
