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
	partial class VolunteerPortalPage : Windows.UI.Xaml.Controls.Page
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
			// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 1:2)
			base.Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true,
				// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 24:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.Grid
					{
						IsParsing = true,
						HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, Grid/HorizontalAlignment */,
						Margin = new global::Windows.UI.Xaml.Thickness(0,75,0,0)/* Windows.UI.Xaml.Thickness/, 0,75,0,0, Grid/Margin */,
						Padding = new global::Windows.UI.Xaml.Thickness(5)/* Windows.UI.Xaml.Thickness/, 5, Grid/Padding */,
						RowSpacing = 10d/* double/, 10, Grid/RowSpacing */,
						RowDefinitions = 
						{
							new global::Windows.UI.Xaml.Controls.RowDefinition
							{
								Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 27:18)
							}
							,
							new global::Windows.UI.Xaml.Controls.RowDefinition
							{
								Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 28:18)
							}
							,
							new global::Windows.UI.Xaml.Controls.RowDefinition
							{
								Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 29:18)
							}
							,
						}
						,
						// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 25:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true,
								Name = "WelcomeMessage",
								Text = "Welcome, Tyler"/* string/, Welcome, Tyler, TextBlock/Text */,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 33:14)
							}
							.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler1)(c3 => 
							{
								nameScope.RegisterName("WelcomeMessage", c3);
								this.WelcomeMessage = c3;
								c3.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.StackPanel
							{
								IsParsing = true,
								// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 35:14)
								Children = 
								{
									new global::Microsoft.UI.Xaml.Controls.Expander
									{
										IsParsing = true,
										Name = "VistaPrint",
										MaxWidth = 555d/* double/, 555, Expander/MaxWidth */,
										IsExpanded = true/* bool/, True, Expander/IsExpanded */,
										VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Top/* Windows.UI.Xaml.VerticalAlignment/, Top, Expander/VerticalAlignment */,
										Header = 										new global::Windows.UI.Xaml.Controls.Grid
										{
											IsParsing = true,
											ColumnSpacing = 15d/* double/, 15, Grid/ColumnSpacing */,
											ColumnDefinitions = 
											{
												new global::Windows.UI.Xaml.Controls.ColumnDefinition
												{
													Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, ColumnDefinition/Width */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 41:34)
												}
												,
												new global::Windows.UI.Xaml.Controls.ColumnDefinition
												{
													Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, ColumnDefinition/Width */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 42:34)
												}
												,
											}
											,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 39:26)
											Children = 
											{
												new global::Windows.UI.Xaml.Controls.Image
												{
													IsParsing = true,
													Source = "/Assets/Images/Logos/Petition.png"/* Windows.UI.Xaml.Media.ImageSource/, /Assets/Images/Logos/Petition.png, Image/Source */,
													Height = 35d/* double/, 35, Image/Height */,
													Width = 30d/* double/, 30, Image/Width */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 45:30)
												}
												.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler3)(c6 => 
												{
													global::Windows.UI.Xaml.Controls.Grid.SetColumn(c6, 0/* int/, 0, Grid/Column */);
													c6.CreationComplete();
												}
												))
												,
												new global::Windows.UI.Xaml.Controls.TextBlock
												{
													IsParsing = true,
													FontSize = 20d/* double/, 20, TextBlock/FontSize */,
													VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Center/* Windows.UI.Xaml.VerticalAlignment/, Center, TextBlock/VerticalAlignment */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 46:30)
													Inlines = 
													{
														new global::Windows.UI.Xaml.Documents.Bold
														{
															// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 47:46)
															Inlines = 
															{
																new global::Windows.UI.Xaml.Documents.Run
																{
																	Text = "Print Petition & Acquire Signatures"/* string/, Print Petition & Acquire Signatures, Run/Text */,
																	// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 47:92)
																}
																,
															}
														}
														,
													}
												}
												.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler1)(c8 => 
												{
													global::Windows.UI.Xaml.Controls.Grid.SetColumn(c8, 1/* int/, 1, Grid/Column */);
													c8.CreationComplete();
												}
												))
												,
											}
										}
										.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler5)(c9 => 
										{
											c9.CreationComplete();
										}
										))
										,
										Content = 										new global::Windows.UI.Xaml.Controls.Grid
										{
											IsParsing = true,
											MinHeight = 280d/* double/, 280, Grid/MinHeight */,
											Padding = new global::Windows.UI.Xaml.Thickness(15,0,15,15)/* Windows.UI.Xaml.Thickness/, 15,0,15,15, Grid/Padding */,
											RowSpacing = 15d/* double/, 15, Grid/RowSpacing */,
											RowDefinitions = 
											{
												new global::Windows.UI.Xaml.Controls.RowDefinition
												{
													Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 55:34)
												}
												,
												new global::Windows.UI.Xaml.Controls.RowDefinition
												{
													Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 56:34)
												}
												,
												new global::Windows.UI.Xaml.Controls.RowDefinition
												{
													Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 57:34)
												}
												,
												new global::Windows.UI.Xaml.Controls.RowDefinition
												{
													Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, auto, RowDefinition/Height */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 58:34)
												}
												,
											}
											,
											// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 53:26)
											Children = 
											{
												new global::Windows.UI.Xaml.Controls.TextBlock
												{
													IsParsing = true,
													Margin = new global::Windows.UI.Xaml.Thickness(0,25,0,0)/* Windows.UI.Xaml.Thickness/, 0,25,0,0, TextBlock/Margin */,
													FontSize = 16d/* double/, 16, TextBlock/FontSize */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 61:30)
													Inlines = 
													{
														new global::Windows.UI.Xaml.Documents.Run
														{
															Text = "If you wish to collect signatures at your place of work or neighborhood, print out as many petitions as you like."/* string/, If you wish to collect signatures at your place of work or neighborhood, print out as many petitions as you like., Run/Text */,
															// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 63:31)
														}
														,
													}
												}
												.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler1)(c15 => 
												{
													global::Windows.UI.Xaml.Controls.Grid.SetRow(c15, 0/* int/, 0, Grid/Row */);
													c15.CreationComplete();
												}
												))
												,
												new global::Windows.UI.Xaml.Controls.TextBlock
												{
													IsParsing = true,
													FontSize = 16d/* double/, 16, TextBlock/FontSize */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 65:30)
													Inlines = 
													{
														new global::Windows.UI.Xaml.Documents.Run
														{
															Text = "Please ensure that you witness the person signing the petition and that you validate that they are registered to vote and live within the city limits of Evansville IN."/* string/, Please ensure that you witness the person signing the petition and that you validate that they are registered to vote and live within the city limits of Evansville IN., Run/Text */,
															// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 68:31)
														}
														,
													}
												}
												.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler1)(c17 => 
												{
													global::Windows.UI.Xaml.Controls.Grid.SetRow(c17, 1/* int/, 1, Grid/Row */);
													c17.CreationComplete();
												}
												))
												,
												new global::Windows.UI.Xaml.Controls.TextBlock
												{
													IsParsing = true,
													FontSize = 16d/* double/, 16, TextBlock/FontSize */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 70:30)
													Inlines = 
													{
														new global::Windows.UI.Xaml.Documents.Run
														{
															Text = "Lastly, be sure to "/* string/, Lastly, be sure to , Run/Text */,
															// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 71:53)
														}
														,
														new global::Windows.UI.Xaml.Documents.Bold
														{
															// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 71:53)
															Inlines = 
															{
																new global::Windows.UI.Xaml.Documents.Run
																{
																	Text = "print on both sides."/* string/, print on both sides., Run/Text */,
																	// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 71:80)
																}
																,
															}
														}
														,
														new global::Windows.UI.Xaml.Documents.Run
														{
															Text = " and fill in your information in the Petition Carrier Certification. once you're finished collecting, schedule a turn in via email by pressing the button below."/* string/,  and fill in your information in the Petition Carrier Certification. once you're finished collecting, schedule a turn in via email by pressing the button below., Run/Text */,
															// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 73:31)
														}
														,
													}
												}
												.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler1)(c21 => 
												{
													global::Windows.UI.Xaml.Controls.Grid.SetRow(c21, 2/* int/, 2, Grid/Row */);
													c21.CreationComplete();
												}
												))
												,
												new global::Windows.UI.Xaml.Controls.WrapPanel
												{
													IsParsing = true,
													Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, WrapPanel/Orientation */,
													Margin = new global::Windows.UI.Xaml.Thickness(0,0,0,0)/* Windows.UI.Xaml.Thickness/, 0,0,0,0, WrapPanel/Margin */,
													// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 75:30)
													Children = 
													{
														new global::Windows.UI.Xaml.Controls.Button
														{
															IsParsing = true,
															Content = @"Print Petition"/* object/, Print Petition, Button/Content */,
															Background = SolidColorBrushHelper.LightBlue/* Windows.UI.Xaml.Media.Brush/, LightBlue, Button/Background */,
															Foreground = SolidColorBrushHelper.Black/* Windows.UI.Xaml.Media.Brush/, Black, Button/Foreground */,
															FontWeight = global::Windows.UI.Text.FontWeights.Medium/* Windows.UI.Text.FontWeight/, Medium, Button/FontWeight */,
															CornerRadius = new Windows.UI.Xaml.CornerRadius(15)/* Windows.UI.Xaml.CornerRadius/, 15, Button/CornerRadius */,
															Padding = new global::Windows.UI.Xaml.Thickness(20,5,20,5)/* Windows.UI.Xaml.Thickness/, 20,5,20,5, Button/Padding */,
															FontSize = 18d/* double/, 18, Button/FontSize */,
															Margin = new global::Windows.UI.Xaml.Thickness(5,5,0,0)/* Windows.UI.Xaml.Thickness/, 5,5,0,0, Button/Margin */,
															// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 76:34)
														}
														.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler6)(c22 => 
														{
															var Click_PrintPetition_Click_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
															/* second level */ c22.Click += (PrintPetition_Click_sender,PrintPetition_Click_e) => (Click_PrintPetition_Click_That.Target as global::ElevateEvansvilleUI.Pages.VolunteerPortalPage)?.PrintPetition_Click(PrintPetition_Click_sender,PrintPetition_Click_e);
															c22.CreationComplete();
														}
														))
														,
														new global::Windows.UI.Xaml.Controls.Button
														{
															IsParsing = true,
															Content = @"Schedule Petition(s) Turn-in"/* object/, Schedule Petition(s) Turn-in, Button/Content */,
															Background = SolidColorBrushHelper.LightBlue/* Windows.UI.Xaml.Media.Brush/, LightBlue, Button/Background */,
															Foreground = SolidColorBrushHelper.Black/* Windows.UI.Xaml.Media.Brush/, Black, Button/Foreground */,
															FontWeight = global::Windows.UI.Text.FontWeights.Medium/* Windows.UI.Text.FontWeight/, Medium, Button/FontWeight */,
															CornerRadius = new Windows.UI.Xaml.CornerRadius(15)/* Windows.UI.Xaml.CornerRadius/, 15, Button/CornerRadius */,
															Padding = new global::Windows.UI.Xaml.Thickness(20,5,20,5)/* Windows.UI.Xaml.Thickness/, 20,5,20,5, Button/Padding */,
															FontSize = 18d/* double/, 18, Button/FontSize */,
															Margin = new global::Windows.UI.Xaml.Thickness(5,5,0,0)/* Windows.UI.Xaml.Thickness/, 5,5,0,0, Button/Margin */,
															// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 79:34)
														}
														.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler6)(c23 => 
														{
															var Click_TurnInPetition_Click_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
															/* second level */ c23.Click += (TurnInPetition_Click_sender,TurnInPetition_Click_e) => (Click_TurnInPetition_Click_That.Target as global::ElevateEvansvilleUI.Pages.VolunteerPortalPage)?.TurnInPetition_Click(TurnInPetition_Click_sender,TurnInPetition_Click_e);
															c23.CreationComplete();
														}
														))
														,
													}
												}
												.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler7)(c24 => 
												{
													global::Windows.UI.Xaml.Controls.Grid.SetRow(c24, 4/* int/, 4, Grid/Row */);
													c24.CreationComplete();
												}
												))
												,
											}
										}
										.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler5)(c25 => 
										{
											c25.CreationComplete();
										}
										))
										,
										// Source ..\..\..\..\..\..\..\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 36:18)
									}
									.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler8)(c26 => 
									{
										nameScope.RegisterName("VistaPrint", c26);
										this.VistaPrint = c26;
										c26.CreationComplete();
									}
									))
									,
								}
							}
							.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler9)(c27 => 
							{
								global::Windows.UI.Xaml.Controls.Grid.SetRow(c27, 1/* int/, 1, Grid/Row */);
								c27.CreationComplete();
							}
							))
							,
						}
					}
					.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler5)(c28 => 
					{
						c28.CreationComplete();
					}
					))
					,
				}
			}
			.VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply((VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions.XamlApplyHandler5)(c29 => 
			{
				c29.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply((c30 => 
			{
				// Source C:\Users\wandt\source\Workspaces\ElevateEvansville\ElevateEvansvilleUI\ElevateEvansvilleUI.Shared\Pages\Volunteer\VolunteerPortalPage.xaml (Line 1:2)
				
				// WARNING Property c30.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply((c31 => 
			{
				// Class ElevateEvansvilleUI.Pages.VolunteerPortalPage
				var Loaded_Page_Loaded_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
				/* second level */ c31.Loaded += (Page_Loaded_sender,Page_Loaded_e) => (Loaded_Page_Loaded_That.Target as global::ElevateEvansvilleUI.Pages.VolunteerPortalPage)?.Page_Loaded(Page_Loaded_sender,Page_Loaded_e);
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c31, global::Windows.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, isHotReloadSupported: false, context: global::ElevateEvansvilleUI.Wasm.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_0 = c31;
				c31.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new VolunteerPortalPage_Bindings(this);
			Loading += delegate
			{
				Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _WelcomeMessageSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.TextBlock WelcomeMessage
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_WelcomeMessageSubject.ElementInstance;
			}
			set
			{
				_WelcomeMessageSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Data.ElementNameSubject _VistaPrintSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Microsoft.UI.Xaml.Controls.Expander VistaPrint
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Expander)_VistaPrintSubject.ElementInstance;
			}
			set
			{
				_VistaPrintSubject.ElementInstance = value;
			}
		}
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
		private interface IVolunteerPortalPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IVolunteerPortalPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class VolunteerPortalPage_Bindings : IVolunteerPortalPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private global::ElevateEvansvilleUI.Pages.VolunteerPortalPage Owner { get => (global::ElevateEvansvilleUI.Pages.VolunteerPortalPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private global::ElevateEvansvilleUI.Pages.VolunteerPortalPage Owner { get; set; }
			#endif
			public VolunteerPortalPage_Bindings(global::ElevateEvansvilleUI.Pages.VolunteerPortalPage owner)
			{
				Owner = owner;
			}
			void IVolunteerPortalPage_Bindings.Initialize()
			{
			}
			void IVolunteerPortalPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void IVolunteerPortalPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
			}
			void IVolunteerPortalPage_Bindings.StopTracking()
			{
			}
		}

	}
}
namespace ElevateEvansvilleUI.Wasm
{
	static class VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.RowDefinition VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.ColumnDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ColumnDefinition VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Windows.UI.Xaml.Controls.ColumnDefinition instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.Image instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Image VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Windows.UI.Xaml.Controls.Image instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Documents.Run instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Documents.Run VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Windows.UI.Xaml.Documents.Run instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.Button instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Button VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler7(global::Windows.UI.Xaml.Controls.WrapPanel instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.WrapPanel VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Windows.UI.Xaml.Controls.WrapPanel instance, XamlApplyHandler7 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler8(global::Microsoft.UI.Xaml.Controls.Expander instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Microsoft.UI.Xaml.Controls.Expander VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Microsoft.UI.Xaml.Controls.Expander instance, XamlApplyHandler8 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler9(global::Windows.UI.Xaml.Controls.StackPanel instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.StackPanel VolunteerPortalPage_ae913e657cf52df1cf3d1adde57d8f50_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler9 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
