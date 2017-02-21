using System;
using ObjCRuntime;

[assembly: LinkWith ("libQuantcast.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, LinkerFlags="-lz -lsqlite3", Frameworks = "UIKit Foundation SystemConfiguration CoreTelephony Accelerate CoreGraphics QuartzCore", ForceLoad = true)]
