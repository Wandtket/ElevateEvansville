// <autogenerated />
#pragma warning disable 618 // Ignore obsolete members warnings
#pragma warning disable 105 // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
#pragma warning disable CS8669 // Ignore annotation for nullable reference types
using System;
using System.Linq;
using System.Collections.Generic;
using Uno.Extensions;
using Uno;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using ElevateEvansvilleUI.Wasm;

#if __WASM__

#endif
namespace ElevateEvansvilleUI.Wasm
{
	/// <summary>
	/// Contains all the static resources defined for the application
	/// </summary>
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("dotnet", "CA1001", Justification="Generated code")]
	public sealed partial class GlobalStaticResources
	{
		static bool _initialized;
		private static bool _stylesRegistered;
		private static bool _dictionariesRegistered;
		internal static global::Uno.UI.Xaml.XamlParseContext __ParseContext_ {get; } = new global::Uno.UI.Xaml.XamlParseContext()
		{
			AssemblyName = "ElevateEvansvilleUI.Wasm",
		}
		;

		static GlobalStaticResources()
		{
			Initialize();
		}
		public static void Initialize()
		{
			if (!_initialized)
			{
				_initialized = true;
				global::Uno.Toolkit.UI.GlobalStaticResources.Initialize();
				global::Uno.UI.GlobalStaticResources.Initialize();
				global::Uno.UI.Toolkit.GlobalStaticResources.Initialize();
				global::Uno.Toolkit.UI.GlobalStaticResources.RegisterDefaultStyles();
				global::Uno.UI.GlobalStaticResources.RegisterDefaultStyles();
				global::Uno.UI.Toolkit.GlobalStaticResources.RegisterDefaultStyles();
				global::Uno.Toolkit.UI.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Uno.UI.GlobalStaticResources.RegisterResourceDictionariesBySource();
				global::Uno.UI.Toolkit.GlobalStaticResources.RegisterResourceDictionariesBySource();
			}
		}
		public static void RegisterDefaultStyles()
		{
			if(!_stylesRegistered)
			{
				_stylesRegistered = true;
				RegisterDefaultStyles_AboutPage_59657eb4f94c92d5744849fdf92fde46();
				RegisterDefaultStyles_App_3fa65cb8d7e5f7a028affefc869f119d();
				RegisterDefaultStyles_EnergyPage_a7cb2421b433102b6d2decd840320e15();
				RegisterDefaultStyles_FinancePage_c389dd525b595ace9bd568be6bf9a144();
				RegisterDefaultStyles_HomePage_a442339bfe6eec45a99b44926e6b8f70();
				RegisterDefaultStyles_HousingPage_005444f8b2b3d80bf3d12a74f7572034();
				RegisterDefaultStyles_MainPage_3af1f3f12a93ba9809ceae47e9031eea();
				RegisterDefaultStyles_PayPalDetailMessage_0aadb35cb069211028f7f4dbf499d93f();
				RegisterDefaultStyles_PetitionPage_cdca8684f131863fabd875439e2700f3();
				RegisterDefaultStyles_PlatformPage_336706b5dd8723fa9b8deaa1fd7a031c();
				RegisterDefaultStyles_PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a();
				RegisterDefaultStyles_PrivacyPage_3fcb2ab55d64b5eee94a76357880ef2d();
				RegisterDefaultStyles_RailroadPage_67e18ba6c0d30315621678b5bcff722a();
				RegisterDefaultStyles_SupportPage_dd8ca0b4707e5601bcb61eecaf6c268c();
				RegisterDefaultStyles_TestPage_da17f6613ee4934aa363dc10577ac638();
				RegisterDefaultStyles_VolunteerLoginPage_a27c668d9d0bcf140dc99f7f0d90c00b();
				RegisterDefaultStyles_VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50();
			}
		}
		// Register ResourceDictionaries using ms-appx:/// syntax, this is called for external resources
		public static void RegisterResourceDictionariesBySource()
		{
			if(!_dictionariesRegistered)
			{
				_dictionariesRegistered = true;
			}
		}
		// Register ResourceDictionaries using ms-resource:/// syntax, this is called for local resources
		internal static void RegisterResourceDictionariesBySourceLocal()
		{
		}
		static partial void RegisterDefaultStyles_AboutPage_59657eb4f94c92d5744849fdf92fde46();
		static partial void RegisterDefaultStyles_App_3fa65cb8d7e5f7a028affefc869f119d();
		static partial void RegisterDefaultStyles_EnergyPage_a7cb2421b433102b6d2decd840320e15();
		static partial void RegisterDefaultStyles_FinancePage_c389dd525b595ace9bd568be6bf9a144();
		static partial void RegisterDefaultStyles_HomePage_a442339bfe6eec45a99b44926e6b8f70();
		static partial void RegisterDefaultStyles_HousingPage_005444f8b2b3d80bf3d12a74f7572034();
		static partial void RegisterDefaultStyles_MainPage_3af1f3f12a93ba9809ceae47e9031eea();
		static partial void RegisterDefaultStyles_PayPalDetailMessage_0aadb35cb069211028f7f4dbf499d93f();
		static partial void RegisterDefaultStyles_PetitionPage_cdca8684f131863fabd875439e2700f3();
		static partial void RegisterDefaultStyles_PlatformPage_336706b5dd8723fa9b8deaa1fd7a031c();
		static partial void RegisterDefaultStyles_PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a();
		static partial void RegisterDefaultStyles_PrivacyPage_3fcb2ab55d64b5eee94a76357880ef2d();
		static partial void RegisterDefaultStyles_RailroadPage_67e18ba6c0d30315621678b5bcff722a();
		static partial void RegisterDefaultStyles_SupportPage_dd8ca0b4707e5601bcb61eecaf6c268c();
		static partial void RegisterDefaultStyles_TestPage_da17f6613ee4934aa363dc10577ac638();
		static partial void RegisterDefaultStyles_VolunteerLoginPage_a27c668d9d0bcf140dc99f7f0d90c00b();
		static partial void RegisterDefaultStyles_VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50();
		[global::System.Obsolete("This method is provided for binary backward compatibility. It will always return null.")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static object FindResource(string name) => null;
		
	}
}
