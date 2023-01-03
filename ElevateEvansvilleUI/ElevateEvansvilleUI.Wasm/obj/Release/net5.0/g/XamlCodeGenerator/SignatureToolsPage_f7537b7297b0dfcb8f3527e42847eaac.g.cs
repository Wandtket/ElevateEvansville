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

namespace ElevateEvansvilleUI.Pages
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
	partial class SignatureToolsPage : Windows.UI.Xaml.Controls.Page
	{
				private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			base.IsParsing = true;
			Resources[
			typeof(global::Windows.UI.Xaml.Controls.TextBlock)
			] = 
			new global::Uno.UI.Xaml.WeakResourceInitializer(this, __ResourceOwner_4 => 
				new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
				{
					Setters = 
					{
						new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)16d/* double/double, 16, Setter/Value */),
						new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.TextWrappingProperty, (Windows.UI.Xaml.TextWrapping)global::Windows.UI.Xaml.TextWrapping.Wrap/* Windows.UI.Xaml.TextWrapping/Windows.UI.Xaml.TextWrapping, Wrap, Setter/Value */),
					}
				}
			)
			;
			// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Signature\SignatureToolsPage.xaml (Line 1:2)
			base.Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true,
				// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Signature\SignatureToolsPage.xaml (Line 23:6)
			}
			.SignatureToolsPage_f7537b7297b0dfcb8f3527e42847eaac_XamlApply((SignatureToolsPage_f7537b7297b0dfcb8f3527e42847eaacXamlApplyExtensions.XamlApplyHandler0)(c0 => 
			{
				c0.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply((c1 => 
			{
				// Source C:\Users\wandt\source\Workspaces\ElevateEvansville\ElevateEvansvilleUI\ElevateEvansvilleUI.Shared\Pages\Signature\SignatureToolsPage.xaml (Line 1:2)
				
				// WARNING Property c1.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply((c2 => 
			{
				// Class ElevateEvansvilleUI.Pages.SignatureToolsPage
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c2, global::Windows.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_0 = c2;
				c2.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new SignatureToolsPage_Bindings(this);
			Loading += delegate
			{
				Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_0_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.Page _component_0
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Page)_component_0_Holder.Instance;
			}
			set
			{
				_component_0_Holder.Instance = value;
			}
		}
		private interface ISignatureToolsPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private ISignatureToolsPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class SignatureToolsPage_Bindings : ISignatureToolsPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private global::ElevateEvansvilleUI.Pages.SignatureToolsPage Owner { get => (global::ElevateEvansvilleUI.Pages.SignatureToolsPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private global::ElevateEvansvilleUI.Pages.SignatureToolsPage Owner { get; set; }
			#endif
			public SignatureToolsPage_Bindings(global::ElevateEvansvilleUI.Pages.SignatureToolsPage owner)
			{
				Owner = owner;
			}
			void ISignatureToolsPage_Bindings.Initialize()
			{
			}
			void ISignatureToolsPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void ISignatureToolsPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
			}
			void ISignatureToolsPage_Bindings.StopTracking()
			{
			}
		}

	}
}
namespace ElevateEvansvilleUI.Wasm
{
	static class SignatureToolsPage_f7537b7297b0dfcb8f3527e42847eaacXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid SignatureToolsPage_f7537b7297b0dfcb8f3527e42847eaac_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
