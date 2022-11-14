// <autogenerated />
#pragma warning disable 618 // Ignore obsolete members warnings
#pragma warning disable 105 // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
#pragma warning disable CS8669 // Ignore annotation for nullable reference types
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using ElevateEvansvilleUI.Wasm;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API || NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace ElevateEvansvilleUI
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("dotnet", "CA1001", Justification="Generated code")]
	partial class App : Windows.UI.Xaml.Application
	{
				private void InitializeComponent()
		{
			global::Windows.ApplicationModel.Resources.ResourceLoader.DefaultLanguage = "en-US";
			global::Windows.ApplicationModel.Resources.ResourceLoader.AddLookupAssembly(GetType().Assembly);
			global::Windows.ApplicationModel.Resources.ResourceLoader.AddLookupAssembly(typeof(global::Windows.UI.Xaml.FrameworkElement).Assembly);

			this
			.GenericApply((c0 => 
			{
				// Source C:\Users\wandt\source\Workspaces\ElevateEvansville\ElevateEvansvilleUI\ElevateEvansvilleUI.Shared\App.xaml (Line 1:2)
				
				// WARNING Property c0.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Application, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			;

			global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.Initialize();
			global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.RegisterResourceDictionariesBySourceLocal();
			global::Uno.UI.DataBinding.BindableMetadata.Provider = new global::ElevateEvansvilleUI.Wasm.BindableMetadataProvider();
			#if __ANDROID__
			global::Uno.Helpers.DrawableHelper.Drawables = typeof(global::ElevateEvansvilleUI.Wasm.Resource.Drawable);
			#endif
			// Workaround for https://github.com/dotnet/runtime/issues/44269
			typeof(global::Uno.UI.Runtime.WebAssembly.HtmlElementAttribute).GetHashCode();
			// MergedDictionaries
			Resources.MergedDictionaries.Add(
			new global::Microsoft.UI.Xaml.Controls.XamlControlsResourcesV2()
			{
			}
			);
			// ThemeDictionaries
			Resources.ThemeDictionaries["Dark"] = 
			new global::Uno.UI.Xaml.WeakResourceInitializer(this, __ResourceOwner_8 => 
				new global::Windows.UI.Xaml.ResourceDictionary
				{
					[
					"TitleBarColor"
					] = 
					new global::Uno.UI.Xaml.WeakResourceInitializer(__ResourceOwner_8, __ResourceOwner_9 => 
						SolidColorBrushHelper.Black/* Windows.UI.Xaml.Media.Brush/Windows.UI.Xaml.Media.Brush, Black, /_UnknownContent */					)
					,
					[
					"SubColor"
					] = 
					new global::Uno.UI.Xaml.WeakResourceInitializer(__ResourceOwner_8, __ResourceOwner_10 => 
						SolidColorBrushHelper.FromARGB(255, 45, 45, 48)/* Windows.UI.Xaml.Media.Brush/Windows.UI.Xaml.Media.Brush, #FF2D2D30, /_UnknownContent */					)
					,
					[
					"FontColor"
					] = 
					new global::Uno.UI.Xaml.WeakResourceInitializer(__ResourceOwner_8, __ResourceOwner_11 => 
						SolidColorBrushHelper.White/* Windows.UI.Xaml.Media.Brush/Windows.UI.Xaml.Media.Brush, White, /_UnknownContent */					)
					,
				}
			)
			;
			Resources.ThemeDictionaries["Light"] = 
			new global::Uno.UI.Xaml.WeakResourceInitializer(this, __ResourceOwner_12 => 
				new global::Windows.UI.Xaml.ResourceDictionary
				{
					[
					"TitleBarColor"
					] = 
					new global::Uno.UI.Xaml.WeakResourceInitializer(__ResourceOwner_12, __ResourceOwner_13 => 
						SolidColorBrushHelper.White/* Windows.UI.Xaml.Media.Brush/Windows.UI.Xaml.Media.Brush, White, /_UnknownContent */					)
					,
					[
					"SubColor"
					] = 
					new global::Uno.UI.Xaml.WeakResourceInitializer(__ResourceOwner_12, __ResourceOwner_14 => 
						SolidColorBrushHelper.FromARGB(255, 235, 235, 235)/* Windows.UI.Xaml.Media.Brush/Windows.UI.Xaml.Media.Brush, #FFEBEBEB, /_UnknownContent */					)
					,
					[
					"FontColor"
					] = 
					new global::Uno.UI.Xaml.WeakResourceInitializer(__ResourceOwner_12, __ResourceOwner_15 => 
						SolidColorBrushHelper.Black/* Windows.UI.Xaml.Media.Brush/Windows.UI.Xaml.Media.Brush, Black, /_UnknownContent */					)
					,
				}
			)
			;
			Resources[
			typeof(global::Windows.UI.Xaml.Controls.TextBlock)
			] = 
			new global::Uno.UI.Xaml.WeakResourceInitializer(this, __ResourceOwner_16 => 
				new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
				{
					Setters = 
					{
						new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.HorizontalAlignmentProperty, (Windows.UI.Xaml.HorizontalAlignment)global::Windows.UI.Xaml.HorizontalAlignment.Left/* Windows.UI.Xaml.HorizontalAlignment/Windows.UI.Xaml.HorizontalAlignment, Left, Setter/Value */),
						new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.TextWrappingProperty, (Windows.UI.Xaml.TextWrapping)global::Windows.UI.Xaml.TextWrapping.Wrap/* Windows.UI.Xaml.TextWrapping/Windows.UI.Xaml.TextWrapping, Wrap, Setter/Value */),
					}
				}
			)
			;
			// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\App.xaml (Line 1:2)
		}

	}
}
namespace ElevateEvansvilleUI.Wasm
{
	static class App_3fa65cb8d7e5f7a028affefc869f119dXamlApplyExtensions
	{
	}
}