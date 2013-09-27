﻿// 
// DNN Corp. - http://www.dnnsoftware.com
// Copyright (c) 2002-2013 DNN  Corp.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.

using Newtonsoft.Json.Linq;

namespace DotNetNuke.Modules.DNNReferralModule.Components
{
    public class PackageInfo
    {
        public PackageInfo(JToken jPackage)
        {
            PackageId = (int) jPackage["id"];
            PackageName = (string) jPackage["name"];
            PackageLink = (string) jPackage["link"];
            PackagePrice = (string) jPackage["price"];
            PackageIcon = (string) jPackage["icon"];
            PackageRatingNumber = (double) jPackage["rating"];
            PackageRatingImage = (string)jPackage["ratingImage"];
            VendorName = (string)jPackage["vendorName"];
            VendorLink = (string)jPackage["vendorLink"];
        }

        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string PackageLink { get; set; }
        public string PackagePrice { get; set; }
        public string PackageIcon { get; set; }
        public double PackageRatingNumber { get; set; }
        public string PackageRatingImage { get; set; }
        public string VendorName { get; set; }
        public string VendorLink { get; set; }
    }
}