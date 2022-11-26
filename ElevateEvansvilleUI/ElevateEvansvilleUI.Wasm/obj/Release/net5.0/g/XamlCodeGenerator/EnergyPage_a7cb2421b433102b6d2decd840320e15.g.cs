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

namespace ElevateEvansvilleUI.Pages.Featured
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
	partial class EnergyPage : Windows.UI.Xaml.Controls.Page
	{
				private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			base.IsParsing = true;
			Resources[
			"Paragraph"
			] = 
			new global::Uno.UI.Xaml.WeakResourceInitializer(this, __ResourceOwner_67 => 
				new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
				{
					Setters = 
					{
						new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)24d/* double/double, 24, Setter/Value */),
						new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.TextWrappingProperty, (Windows.UI.Xaml.TextWrapping)global::Windows.UI.Xaml.TextWrapping.Wrap/* Windows.UI.Xaml.TextWrapping/Windows.UI.Xaml.TextWrapping, Wrap, Setter/Value */),
					}
				}
			)
			;
			Resources[
			"Header"
			] = 
			new global::Uno.UI.Xaml.WeakResourceInitializer(this, __ResourceOwner_71 => 
				new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBlock))
				{
					Setters = 
					{
						new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.FontSizeProperty, (double)30d/* double/double, 30, Setter/Value */),
						new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.TextWrappingProperty, (Windows.UI.Xaml.TextWrapping)global::Windows.UI.Xaml.TextWrapping.Wrap/* Windows.UI.Xaml.TextWrapping/Windows.UI.Xaml.TextWrapping, Wrap, Setter/Value */),
						new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.TextBlock.MarginProperty, (Windows.UI.Xaml.Thickness)new global::Windows.UI.Xaml.Thickness(0,15,0,10)/* Windows.UI.Xaml.Thickness/Windows.UI.Xaml.Thickness, 0,15,0,10, Setter/Value */),
					}
				}
			)
			;
			// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 1:2)
			base.Content = 
			new global::Windows.UI.Xaml.Controls.ScrollViewer
			{
				IsParsing = true,
				// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 25:6)
				Content = 
				new global::Windows.UI.Xaml.Controls.Grid
				{
					IsParsing = true,
					Padding = new global::Windows.UI.Xaml.Thickness(20,75,20,75)/* Windows.UI.Xaml.Thickness/, 20,75,20,75, Grid/Padding */,
					RowSpacing = 20d/* double/, 20, Grid/RowSpacing */,
					HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, Grid/HorizontalAlignment */,
					MaxWidth = 900d/* double/, 900, Grid/MaxWidth */,
					RowDefinitions = 
					{
						new global::Windows.UI.Xaml.Controls.RowDefinition
						{
							Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
							// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 28:18)
						}
						,
						new global::Windows.UI.Xaml.Controls.RowDefinition
						{
							Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
							// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 29:18)
						}
						,
					}
					,
					// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 26:10)
					Children = 
					{
						new global::Windows.UI.Xaml.Controls.Grid
						{
							IsParsing = true,
							RowDefinitions = 
							{
								new global::Windows.UI.Xaml.Controls.RowDefinition
								{
									Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 34:22)
								}
								,
								new global::Windows.UI.Xaml.Controls.RowDefinition
								{
									Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 35:22)
								}
								,
								new global::Windows.UI.Xaml.Controls.RowDefinition
								{
									Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 36:22)
								}
								,
								new global::Windows.UI.Xaml.Controls.RowDefinition
								{
									Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 37:22)
								}
								,
								new global::Windows.UI.Xaml.Controls.RowDefinition
								{
									Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 38:22)
								}
								,
								new global::Windows.UI.Xaml.Controls.RowDefinition
								{
									Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 39:22)
								}
								,
								new global::Windows.UI.Xaml.Controls.RowDefinition
								{
									Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 40:22)
								}
								,
								new global::Windows.UI.Xaml.Controls.RowDefinition
								{
									Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 41:22)
								}
								,
								new global::Windows.UI.Xaml.Controls.RowDefinition
								{
									Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 42:22)
								}
								,
							}
							,
							// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 32:14)
							Children = 
							{
								new global::Windows.UI.Xaml.Controls.TextBlock
								{
									IsParsing = true,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 46:18)
									Inlines = 
									{
										new global::Windows.UI.Xaml.Documents.Run
										{
											Text = "I believe there is an argument to be made that the most devasting events in human history are the disasters of Chernobyl, Fukushima, and the threat of nuclear war that plagued the 20th century."/* string/, I believe there is an argument to be made that the most devasting events in human history are the disasters of Chernobyl, Fukushima, and the threat of nuclear war that plagued the 20th century., Run/Text */,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 50:19)
										}
										,
									}
								}
								.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler2)(c12 => 
								{
									global::Windows.UI.Xaml.Controls.Grid.SetRow(c12, 0/* int/, 0, Grid/Row */);
									global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c12, global::Windows.UI.Xaml.Controls.TextBlock.StyleProperty, "Paragraph", isThemeResourceExtension: false, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
									/* _isTopLevelDictionary:False */
									this._component_0 = c12;
									c12.CreationComplete();
								}
								))
								,
								new global::Windows.UI.Xaml.Controls.TextBlock
								{
									IsParsing = true,
									Margin = new global::Windows.UI.Xaml.Thickness(0,15,0,0)/* Windows.UI.Xaml.Thickness/, 0,15,0,0, TextBlock/Margin */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 52:18)
									Inlines = 
									{
										new global::Windows.UI.Xaml.Documents.Run
										{
											Text = "These events allowed the fossil fuel, coal, and other energy producing industries to leverage fear against the advent of nuclear energy. Despite nuclear having a higher energy yield, fewer accidents, no air or water pollution, superior waste management, and can be setup anywhere there isn’t serious seismic activity, the word \"nuclear” became a word to stoke feelings of dread rather than progress."/* string/, These events allowed the fossil fuel, coal, and other energy producing industries to leverage fear against the advent of nuclear energy. Despite nuclear having a higher energy yield, fewer accidents, no air or water pollution, superior waste management, and can be setup anywhere there isn’t serious seismic activity, the word "nuclear” became a word to stoke feelings of dread rather than progress., Run/Text */,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 58:19)
										}
										,
									}
								}
								.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler2)(c14 => 
								{
									global::Windows.UI.Xaml.Controls.Grid.SetRow(c14, 1/* int/, 1, Grid/Row */);
									global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c14, global::Windows.UI.Xaml.Controls.TextBlock.StyleProperty, "Paragraph", isThemeResourceExtension: false, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
									/* _isTopLevelDictionary:False */
									this._component_1 = c14;
									c14.CreationComplete();
								}
								))
								,
								new global::Windows.UI.Xaml.Controls.TextBlock
								{
									IsParsing = true,
									Margin = new global::Windows.UI.Xaml.Thickness(0,15,0,0)/* Windows.UI.Xaml.Thickness/, 0,15,0,0, TextBlock/Margin */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 60:18)
									Inlines = 
									{
										new global::Windows.UI.Xaml.Documents.Run
										{
											Text = "Today, we face a serious threat of losing our ability to produce enough energy to accommodate our needs. Make no mistake, one day we will run out of fossil fuels, Earth is the only place we know of that contains them and it was a mistake to believe we could rely upon such a limited resource forever. We’ve allowed the energy barons to amass too much power and now we are suffering the consequences of it."/* string/, Today, we face a serious threat of losing our ability to produce enough energy to accommodate our needs. Make no mistake, one day we will run out of fossil fuels, Earth is the only place we know of that contains them and it was a mistake to believe we could rely upon such a limited resource forever. We’ve allowed the energy barons to amass too much power and now we are suffering the consequences of it., Run/Text */,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 66:19)
										}
										,
									}
								}
								.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler2)(c16 => 
								{
									global::Windows.UI.Xaml.Controls.Grid.SetRow(c16, 2/* int/, 2, Grid/Row */);
									global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c16, global::Windows.UI.Xaml.Controls.TextBlock.StyleProperty, "Paragraph", isThemeResourceExtension: false, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
									/* _isTopLevelDictionary:False */
									this._component_2 = c16;
									c16.CreationComplete();
								}
								))
								,
								new global::Windows.UI.Xaml.Controls.TextBlock
								{
									IsParsing = true,
									Margin = new global::Windows.UI.Xaml.Thickness(0,15,0,0)/* Windows.UI.Xaml.Thickness/, 0,15,0,0, TextBlock/Margin */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 68:18)
									Inlines = 
									{
										new global::Windows.UI.Xaml.Documents.Run
										{
											Text = "The best time to build a nuclear energy facility was 40 years ago. Despite what you may believe about man-made climate change, we’ve all been sold the lie that the best way to produce energy was coal and fossil fuels. The quality of the air you breathe can mean the difference between dying at 60 rather than 80 or 90. What happens when you sit in your car in your garage with the engine turned on? At first not a lot will happen but try falling asleep and I guarantee you won’t wake up. Now picture the Earth as one large garage with millions of cars in it and you’re just about to fall asleep, that’s the stage that we’re in right now."/* string/, The best time to build a nuclear energy facility was 40 years ago. Despite what you may believe about man-made climate change, we’ve all been sold the lie that the best way to produce energy was coal and fossil fuels. The quality of the air you breathe can mean the difference between dying at 60 rather than 80 or 90. What happens when you sit in your car in your garage with the engine turned on? At first not a lot will happen but try falling asleep and I guarantee you won’t wake up. Now picture the Earth as one large garage with millions of cars in it and you’re just about to fall asleep, that’s the stage that we’re in right now., Run/Text */,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 77:19)
										}
										,
									}
								}
								.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler2)(c18 => 
								{
									global::Windows.UI.Xaml.Controls.Grid.SetRow(c18, 3/* int/, 3, Grid/Row */);
									global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c18, global::Windows.UI.Xaml.Controls.TextBlock.StyleProperty, "Paragraph", isThemeResourceExtension: false, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
									/* _isTopLevelDictionary:False */
									this._component_3 = c18;
									c18.CreationComplete();
								}
								))
								,
								new global::Windows.UI.Xaml.Controls.TextBlock
								{
									IsParsing = true,
									Margin = new global::Windows.UI.Xaml.Thickness(0,15,0,0)/* Windows.UI.Xaml.Thickness/, 0,15,0,0, TextBlock/Margin */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 79:18)
									Inlines = 
									{
										new global::Windows.UI.Xaml.Documents.Run
										{
											Text = "Unfortunately, I am in no position to correct that mistake, I will however, do my small part in course correcting this path we’ve been sent down as Mayor of Evansville and it is my goal to reduce the cost of living as much as possible which includes energy costs."/* string/, Unfortunately, I am in no position to correct that mistake, I will however, do my small part in course correcting this path we’ve been sent down as Mayor of Evansville and it is my goal to reduce the cost of living as much as possible which includes energy costs., Run/Text */,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 83:19)
										}
										,
									}
								}
								.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler2)(c20 => 
								{
									global::Windows.UI.Xaml.Controls.Grid.SetRow(c20, 4/* int/, 4, Grid/Row */);
									global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c20, global::Windows.UI.Xaml.Controls.TextBlock.StyleProperty, "Paragraph", isThemeResourceExtension: false, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
									/* _isTopLevelDictionary:False */
									this._component_4 = c20;
									c20.CreationComplete();
								}
								))
								,
								new global::Windows.UI.Xaml.Controls.TextBlock
								{
									IsParsing = true,
									Margin = new global::Windows.UI.Xaml.Thickness(0,15,0,0)/* Windows.UI.Xaml.Thickness/, 0,15,0,0, TextBlock/Margin */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 85:18)
									Inlines = 
									{
										new global::Windows.UI.Xaml.Documents.Run
										{
											Text = "I intend to make an adjustment to the Evansville building code that will require all major businesses to limit the exposure of asphalt, concrete, or blacktop to the sun up to 70%. The percentage can be negotiated of course but the method of covering these materials will be a choice between relocating adult trees strategically for smaller businesses or allow the deployment of Solar Canopies. Large retailers such as Walmart, Target, Costco, etc will be required to deploy solar canopy solutions that covers their parking spaces. Failure to comply with the ordinance will result in major fines, the fines will then be utilized in deploying the canopies once the parking spaces are seized utilizing the powers of eminent domain."/* string/, I intend to make an adjustment to the Evansville building code that will require all major businesses to limit the exposure of asphalt, concrete, or blacktop to the sun up to 70%. The percentage can be negotiated of course but the method of covering these materials will be a choice between relocating adult trees strategically for smaller businesses or allow the deployment of Solar Canopies. Large retailers such as Walmart, Target, Costco, etc will be required to deploy solar canopy solutions that covers their parking spaces. Failure to comply with the ordinance will result in major fines, the fines will then be utilized in deploying the canopies once the parking spaces are seized utilizing the powers of eminent domain., Run/Text */,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 94:19)
										}
										,
									}
								}
								.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler2)(c22 => 
								{
									global::Windows.UI.Xaml.Controls.Grid.SetRow(c22, 5/* int/, 5, Grid/Row */);
									global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c22, global::Windows.UI.Xaml.Controls.TextBlock.StyleProperty, "Paragraph", isThemeResourceExtension: false, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
									/* _isTopLevelDictionary:False */
									this._component_5 = c22;
									c22.CreationComplete();
								}
								))
								,
								new global::Windows.UI.Xaml.Controls.TextBlock
								{
									IsParsing = true,
									Margin = new global::Windows.UI.Xaml.Thickness(0,15,0,0)/* Windows.UI.Xaml.Thickness/, 0,15,0,0, TextBlock/Margin */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 97:18)
									Inlines = 
									{
										new global::Windows.UI.Xaml.Documents.Run
										{
											Text = "The city will also be investing in relocating forests inside city limits and planting trees where they were taken from. All major roads in Evansville will have their center barriers supplemented with trees."/* string/, The city will also be investing in relocating forests inside city limits and planting trees where they were taken from. All major roads in Evansville will have their center barriers supplemented with trees., Run/Text */,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 101:19)
										}
										,
									}
								}
								.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler2)(c24 => 
								{
									global::Windows.UI.Xaml.Controls.Grid.SetRow(c24, 6/* int/, 6, Grid/Row */);
									global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c24, global::Windows.UI.Xaml.Controls.TextBlock.StyleProperty, "Paragraph", isThemeResourceExtension: false, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
									/* _isTopLevelDictionary:False */
									this._component_6 = c24;
									c24.CreationComplete();
								}
								))
								,
								new global::Windows.UI.Xaml.Controls.TextBlock
								{
									IsParsing = true,
									Margin = new global::Windows.UI.Xaml.Thickness(0,15,0,0)/* Windows.UI.Xaml.Thickness/, 0,15,0,0, TextBlock/Margin */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 103:18)
									Inlines = 
									{
										new global::Windows.UI.Xaml.Documents.Run
										{
											Text = "The major benefit of covering concrete that people may not realize is that in the summer time the average temperature of the city can be reduced significantly making the outside far more pleasant as concrete retains heat, try visiting a concrete jungle in a major city and you’ll see how unpleasant exposed concrete can be."/* string/, The major benefit of covering concrete that people may not realize is that in the summer time the average temperature of the city can be reduced significantly making the outside far more pleasant as concrete retains heat, try visiting a concrete jungle in a major city and you’ll see how unpleasant exposed concrete can be., Run/Text */,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 108:19)
										}
										,
									}
								}
								.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler2)(c26 => 
								{
									global::Windows.UI.Xaml.Controls.Grid.SetRow(c26, 7/* int/, 7, Grid/Row */);
									global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c26, global::Windows.UI.Xaml.Controls.TextBlock.StyleProperty, "Paragraph", isThemeResourceExtension: false, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
									/* _isTopLevelDictionary:False */
									this._component_7 = c26;
									c26.CreationComplete();
								}
								))
								,
								new global::Windows.UI.Xaml.Controls.TextBlock
								{
									IsParsing = true,
									Margin = new global::Windows.UI.Xaml.Thickness(0,15,0,0)/* Windows.UI.Xaml.Thickness/, 0,15,0,0, TextBlock/Margin */,
									// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 110:18)
									Inlines = 
									{
										new global::Windows.UI.Xaml.Documents.Run
										{
											Text = "Finally as Mayor I will support any efforts to bring nuclear energy to Evansville to drastically reduce the burden of energy prices on my constituents, whether it be traditional fission or research and development for fusion energy."/* string/, Finally as Mayor I will support any efforts to bring nuclear energy to Evansville to drastically reduce the burden of energy prices on my constituents, whether it be traditional fission or research and development for fusion energy., Run/Text */,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 114:19)
										}
										,
									}
								}
								.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler2)(c28 => 
								{
									global::Windows.UI.Xaml.Controls.Grid.SetRow(c28, 8/* int/, 8, Grid/Row */);
									global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c28, global::Windows.UI.Xaml.Controls.TextBlock.StyleProperty, "Paragraph", isThemeResourceExtension: false, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
									/* _isTopLevelDictionary:False */
									this._component_8 = c28;
									c28.CreationComplete();
								}
								))
								,
							}
						}
						.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler3)(c29 => 
						{
							global::Windows.UI.Xaml.Controls.Grid.SetRow(c29, 0/* int/, 0, Grid/Row */);
							c29.CreationComplete();
						}
						))
						,
					}
				}
				.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler3)(c30 => 
				{
					c30.CreationComplete();
				}
				))
				,
			}
			.EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply((EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions.XamlApplyHandler4)(c31 => 
			{
				c31.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply((c32 => 
			{
				// Source C:\Users\wandt\source\Workspaces\ElevateEvansville\ElevateEvansvilleUI\ElevateEvansvilleUI.Shared\Pages\Featured\EnergyPage.xaml (Line 1:2)
				
				// WARNING Property c32.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply((c33 => 
			{
				// Class ElevateEvansvilleUI.Pages.Featured.EnergyPage
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c33, global::Windows.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_9 = c33;
				c33.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new EnergyPage_Bindings(this);
			Loading += delegate
			{
				Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_0_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_0
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_0_Holder.Instance;
			}
			set
			{
				_component_0_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_1_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_1
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_1_Holder.Instance;
			}
			set
			{
				_component_1_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_2_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_2
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_2_Holder.Instance;
			}
			set
			{
				_component_2_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_3_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_3
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_3_Holder.Instance;
			}
			set
			{
				_component_3_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_4_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_4
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_4_Holder.Instance;
			}
			set
			{
				_component_4_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_5_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_5
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_5_Holder.Instance;
			}
			set
			{
				_component_5_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_6_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_6
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_6_Holder.Instance;
			}
			set
			{
				_component_6_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_7_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_7
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_7_Holder.Instance;
			}
			set
			{
				_component_7_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_8_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.TextBlock _component_8
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_component_8_Holder.Instance;
			}
			set
			{
				_component_8_Holder.Instance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_9_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.Page _component_9
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Page)_component_9_Holder.Instance;
			}
			set
			{
				_component_9_Holder.Instance = value;
			}
		}
		private interface IEnergyPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IEnergyPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class EnergyPage_Bindings : IEnergyPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private global::ElevateEvansvilleUI.Pages.Featured.EnergyPage Owner { get => (global::ElevateEvansvilleUI.Pages.Featured.EnergyPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private global::ElevateEvansvilleUI.Pages.Featured.EnergyPage Owner { get; set; }
			#endif
			public EnergyPage_Bindings(global::ElevateEvansvilleUI.Pages.Featured.EnergyPage owner)
			{
				Owner = owner;
			}
			void IEnergyPage_Bindings.Initialize()
			{
			}
			void IEnergyPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void IEnergyPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
				owner._component_1.UpdateResourceBindings();
				owner._component_2.UpdateResourceBindings();
				owner._component_3.UpdateResourceBindings();
				owner._component_4.UpdateResourceBindings();
				owner._component_5.UpdateResourceBindings();
				owner._component_6.UpdateResourceBindings();
				owner._component_7.UpdateResourceBindings();
				owner._component_8.UpdateResourceBindings();
				owner._component_9.UpdateResourceBindings();
			}
			void IEnergyPage_Bindings.StopTracking()
			{
			}
		}

	}
}
namespace ElevateEvansvilleUI.Wasm
{
	static class EnergyPage_a7cb2421b433102b6d2decd840320e15XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.RowDefinition EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Documents.Run instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Documents.Run EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply(this global::Windows.UI.Xaml.Documents.Run instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.ScrollViewer instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ScrollViewer EnergyPage_a7cb2421b433102b6d2decd840320e15_XamlApply(this global::Windows.UI.Xaml.Controls.ScrollViewer instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
