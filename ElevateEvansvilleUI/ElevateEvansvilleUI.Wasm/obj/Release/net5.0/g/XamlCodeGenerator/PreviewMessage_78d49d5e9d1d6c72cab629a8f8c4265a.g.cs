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

namespace ElevateEvansvilleUI.Controls.Messages
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
	partial class PreviewMessage : Windows.UI.Xaml.Controls.UserControl
	{
				private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			base.IsParsing = true;
			// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 1:2)
			base.Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true,
				MaxWidth = 375d/* double/, 375, Grid/MaxWidth */,
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 14:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 15:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 16:14)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 12:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.TextBlock
					{
						IsParsing = true,
						// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 19:10)
						Inlines = 
						{
							new global::Windows.UI.Xaml.Documents.Run
							{
								Text = "This site is currently being field tested, most features are operational, if something isn't working for you please message the developer (Tyler Wandtke)."/* string/, This site is currently being field tested, most features are operational, if something isn't working for you please message the developer (Tyler Wandtke)., Run/Text */,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 22:11)
							}
							,
						}
					}
					.PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply((PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265aXamlApplyExtensions.XamlApplyHandler2)(c4 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c4, 0/* int/, 0, Grid/Row */);
						c4.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.Grid
					{
						IsParsing = true,
						HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Stretch/* Windows.UI.Xaml.HorizontalAlignment/, Stretch, Grid/HorizontalAlignment */,
						Margin = new global::Windows.UI.Xaml.Thickness(0,10,0,0)/* Windows.UI.Xaml.Thickness/, 0,10,0,0, Grid/Margin */,
						ColumnDefinitions = 
						{
							new global::Windows.UI.Xaml.Controls.ColumnDefinition
							{
								Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, ColumnDefinition/Width */,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 26:18)
							}
							,
							new global::Windows.UI.Xaml.Controls.ColumnDefinition
							{
								Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, ColumnDefinition/Width */,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 27:18)
							}
							,
						}
						,
						// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 24:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true,
								FontWeight = global::Windows.UI.Text.FontWeights.Bold/* Windows.UI.Text.FontWeight/, Bold, TextBlock/FontWeight */,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 30:14)
								Inlines = 
								{
									new global::Windows.UI.Xaml.Documents.Run
									{
										Text = "Changelog:"/* string/, Changelog:, Run/Text */,
										// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 32:15)
									}
									,
								}
							}
							.PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply((PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265aXamlApplyExtensions.XamlApplyHandler2)(c8 => 
							{
								global::Windows.UI.Xaml.Controls.Grid.SetColumn(c8, 0/* int/, 0, Grid/Column */);
								c8.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true,
								FontSize = 11d/* double/, 11, TextBlock/FontSize */,
								HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Right/* Windows.UI.Xaml.HorizontalAlignment/, Right, TextBlock/HorizontalAlignment */,
								VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Bottom/* Windows.UI.Xaml.VerticalAlignment/, Bottom, TextBlock/VerticalAlignment */,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 34:14)
								Inlines = 
								{
									new global::Windows.UI.Xaml.Documents.Run
									{
										Text = "Last Updated: 1/15/2023"/* string/, Last Updated: 1/15/2023, Run/Text */,
										// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 36:15)
									}
									,
								}
							}
							.PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply((PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265aXamlApplyExtensions.XamlApplyHandler2)(c10 => 
							{
								global::Windows.UI.Xaml.Controls.Grid.SetColumn(c10, 1/* int/, 1, Grid/Column */);
								c10.CreationComplete();
							}
							))
							,
						}
					}
					.PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply((PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265aXamlApplyExtensions.XamlApplyHandler4)(c11 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c11, 1/* int/, 1, Grid/Row */);
						c11.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.ListView
					{
						IsParsing = true,
						Name = "ChangeItemsListView",
						Margin = new global::Windows.UI.Xaml.Thickness(15,5,0,0)/* Windows.UI.Xaml.Thickness/, 15,5,0,0, ListView/Margin */,
						Height = 75d/* double/, 75, ListView/Height */,
						SelectionMode = global::Windows.UI.Xaml.Controls.ListViewSelectionMode.None/* Windows.UI.Xaml.Controls.ListViewSelectionMode/, None, ListView/SelectionMode */,
						ItemTemplate = 						new global::Windows.UI.Xaml.DataTemplate(this , __owner => 						new _PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_ElevateEvansvilleUIControlsMessagesPreviewMessageSC0().Build(__owner)
						)						,
						// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 40:10)
					}
					.PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply((PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265aXamlApplyExtensions.XamlApplyHandler5)(c12 => 
					{
						nameScope.RegisterName("ChangeItemsListView", c12);
						this.ChangeItemsListView = c12;
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c12, 2/* int/, 2, Grid/Row */);
						c12.CreationComplete();
					}
					))
					,
				}
			}
			.PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply((PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265aXamlApplyExtensions.XamlApplyHandler4)(c13 => 
			{
				c13.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply((c14 => 
			{
				// Source C:\Users\wandt\source\Workspaces\ElevateEvansville\ElevateEvansvilleUI\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 1:2)
				
				// WARNING Property c14.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}UserControl, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply((c15 => 
			{
				// Class ElevateEvansvilleUI.Controls.Messages.PreviewMessage
				c15.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _ChangeItemsListViewSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.ListView ChangeItemsListView
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.ListView)_ChangeItemsListViewSubject.ElementInstance;
			}
			set
			{
				_ChangeItemsListViewSubject.ElementInstance = value;
			}
		}
		private class _PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_ElevateEvansvilleUIControlsMessagesPreviewMessageSC0
		{
			public _View Build(object __ResourceOwner_14)
			{
				var nameScope = new global::Windows.UI.Xaml.NameScope();
				_View __rootInstance = null;
				__rootInstance = 
				new global::Windows.UI.Xaml.Controls.TextBlock
				{
					IsParsing = true,
					TextWrapping = global::Windows.UI.Xaml.TextWrapping.Wrap/* Windows.UI.Xaml.TextWrapping/, Wrap, TextBlock/TextWrapping */,
					Padding = new global::Windows.UI.Xaml.Thickness(0,5,0,5)/* Windows.UI.Xaml.Thickness/, 0,5,0,5, TextBlock/Padding */,
					// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Controls\Messages\PreviewMessage.xaml (Line 43:22)
				}
				.PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply((PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265aXamlApplyExtensions.XamlApplyHandler2)(c16 => 
				{
					c16.SetBinding(
						global::Windows.UI.Xaml.Controls.TextBlock.TextProperty,
						new Windows.UI.Xaml.Data.Binding()
					);
					c16.CreationComplete();
				}
				))
				;
				if (__rootInstance is DependencyObject d)
				{
					if (global::Windows.UI.Xaml.NameScope.GetNameScope(d) == null)
					{
						global::Windows.UI.Xaml.NameScope.SetNameScope(d, nameScope);
						nameScope.Owner = d;
					}
					global::Uno.UI.FrameworkElementHelper.AddObjectReference(d, this);
				}
				return __rootInstance;
			}
		}

	}
}
namespace ElevateEvansvilleUI.Wasm
{
	static class PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265aXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.RowDefinition PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Documents.Run instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Documents.Run PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply(this global::Windows.UI.Xaml.Documents.Run instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.ColumnDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ColumnDefinition PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply(this global::Windows.UI.Xaml.Controls.ColumnDefinition instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.ListView instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ListView PreviewMessage_78d49d5e9d1d6c72cab629a8f8c4265a_XamlApply(this global::Windows.UI.Xaml.Controls.ListView instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
