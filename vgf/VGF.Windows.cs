//############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//############################################################################
//
//----------------------------------------------------------------------------
// Programmer		:	Christian "Tipplin" Kurs
//----------------------------------------------------------------------------
// Part				:	Base Windows Function as Wrapper
//----------------------------------------------------------------------------
// Base Class		:	VGFWindows.cs
//----------------------------------------------------------------------------
// .NET             :   10.0
//----------------------------------------------------------------------------
// .NET Language    :   Visual C# Version 14
//----------------------------------------------------------------------------
// Copyright © 2017-2026, 
// by  Visual Galaxy Framework Community Kernel Developer Team.
//
// by Head-Author: Christian "Tipplin" Kurs - Visual C# Developer
// Portions Copyright © 1982-2026 by Microsoft Corporation GmbH.
//
// ---------------------------------------------------------------------------
// Same sourcecode by Microsoft, so we marked with Copyright !.
// © 1982-2026 - Copyrights by Microsoft: Images, Icons, Signs, Gadgets, 
// Copyright © and Tradewark by Microsoft Windows, Windows Logo, Visual Studio
// ---------------------------------------------------------------------------
//
// DON'T CHANGE OR DELETE ANYTHING IN SECTION !!!.
// 
//----------------------------------------------------------------------------
// VFGCore
// written by 		
//					Christian "Tipplin" Kurs
//					Asternweg 10
//				-G -51143 Köln Porz Zündorf
//					Germany - Allemagne - Duitsland
//---------------------------------------------------------------------------- 
//					international phone		:
//					Skype					:
//					e-mail					:	
//					community Website		:	https://www.github.com/tipplin
//										
//----------------------------------------------------------------------------
// This software is supplied as is. Use it at your own  RISK !!!!.
// Obviously I've tried to do the best job possible.
// If you find any problem with it, let me know.
//
// With any luck, Visual Galaxy Framework will make it obsolete anyway
//----------------------------------------------------------------------------
// License:	
//				NO fee for NON-Commercial use.
//				our Community Website:
// 
//						
//
//				Honest Business Users, to use our compiled Versions, 
//				please call us to send you our Business Licenses.
//				or our Business Website:
//----------------------------------------------------------------------------			
// Required information 
// To submit a product bug or enhancement request, please visit the page: 
// 
// Please read Unsolicited Idea Submission Policy 
// before you send us your feedback. 
// 
// Our Feedback Page is on GitHub with all Information
// about me and Repos and more:
// https://www.github.com/tipplin
//
// insert in Microsoft Bing search:
// github/tipplin
// 
// 
// 
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------
//-------------------------- Project History ---------------------------------
//----------------------------------------------------------------------------
// Release 0.0.0 - 2017/01/01 - TIPPLIN - KC - Project Founder - Initial
//----------------------------------------------------------------------------
// Commentary:
//
//----------------------------------------------------------------------------
// Breaking Changes: 
//
//
//
//
//
//
//######################## Other notable Changes #############################
//
// Other:
// [VGF.NET - 01] 
//
//----------------------------------------------------------------------------
// Bug:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Fixes:
//[VGF.NET - Bug 01]
//
//---------------------------------------------------------------------------- 
// Miscellous:
//
//=============================================================================
/* ============================================================================
 * ######################## Warning: ##########################################
 * ============================================================================
 * 
 * This product is licensed to you pursuant to the terms of the 
 * VGF license agreement included with the original software, and is
 * protected by copyright law and international treaties.
 * 
 * ----------------------------------------------------------------------------
 * Unauthorized reproduction or distribution may result in severe civil and 
 * criminal penalties, and 
 * will be prosecuted to the maximum extent possible under the law.
 * ----------------------------------------------------------------------------
 * You cannot distribute a compiled version of 
 * this code without prior registration.
 * ----------------------------------------------------------------------------
 * Please see the documentation supplied with 
 * the VGF Libraries for further details.
 * ============================================================================
 * Authored by Copyright © 2917-2023 by 
 * Visual Galaxy Framework Community Kernel Developer Team.
 * All rights reserved.
 * ============================================================================
 * May be redistributed for free, but may not be sold without 
 * the author's explicit permission.
 * ----------------------------------------------------------------------------
 * This software is Copyright © 2017-2024 by VGF-Technologies at VGF-KernelTeam
 * You may only use this software if you are an 
 * authorized licensee of an VGF developer tools product.
 * ----------------------------------------------------------------------------
 * This software is considered a Redistributable as defined under
 * the software license agreement that comes with the VGF Products
 * and is subject to that software license agreement.
 * ============================================================================
 */

/*-----------------------------------------------------------------------------
 * Copyright © 2017-2026 Christian 'Tipplin' Kurs. All Rights Reserved.
 *-----------------------------------------------------------------------------
 * you may not use this file except in compliance with the License.
 * See License Agreement in Class VGF.Core at Main Head.
 *-----------------------------------------------------------------------------
 * Unless required by applicable law or agreed to in writing, 
 * software distributed under the License is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
 * either express or implied.
 * See the License for the permissions and limitations under the License.
 */

//==============================================================================

/* -----------------------------------------------------------------------------
 * Microsoft make Restrictions of Export for following Countries:
 * -----------------------------------------------------------------------------
 * This software is subject to the U.S. Export Administration Regulations and 
 * other U.S.law, and may not be exported or re-exported to certain countries
 * (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) 
 * or
 * to persons or entities prohibited from receiving U.S.exports
 * (including Denied Parties, Specially Designated Nationals,
 * and entities on the Bureau of Export Administration Entity List or
 * involved with missile technology or nuclear, chemical or biological weapons)
 * -----------------------------------------------------------------------------
 * © 1982-2024 Microsoft Corporation.All rights reserved.
 * -----------------------------------------------------------------------------
 *==============================================================================
*/

/*######################### Visual.Galaxy.Framework ###########################
 * #
 * # Start Date: 2022/11/29 - 12:00 - Ground Leaning -Initial
 * #
 * #---------------------------------------------------------------------------
 * #
 * #
 * #
 * #
 * ############################################################################
*/






/*
 * Use internal at .NET 7 release with Visual C# 11, see the new sets global
 * means all directives guilty in Project, 
 * no more write namespaces in other cs.files.
 * 
 */
global using System;

global using System.IO;

global using System.Text;

global using System.Windows;

global using System.Runtime.InteropServices;


/**************************************************
 * 
 * Use Assemblies from David Hall.
 * All Windows Libraries Function as Wrapper's
 * written in Visual C# for .NET
 * David Hall nice Project on GitHub, 
 * with many Windows Functions and more,
 * insert only your want!.
 * 
 * Define global using Vanara.PInvoke; in
 * VGF.Core.cs so you can use in all x.cs Files,
 * the Windows Functions written for .NET!
 **************************************************/


namespace VGF;

internal static class VGFWindows
{
    /// <summary>
    /// Set Window Position on Desk
    /// </summary>
    /// <returns></returns>
    public static bool VGFSetWindowPosition(IntPtr WindowHandle, IntPtr WindowInsertAfter, int XWindowPosition, int YWindowPosition, int CXWindowPosition, int CYWindowPosition, uint Flags)
    {
        // User32 wrappers by David Hall Project 'VANARA'
        // see Windows Library User32.dll and Function MessageBox, written for .NET
        return User32.SetWindowPos(WindowHandle, WindowInsertAfter, XWindowPosition, YWindowPosition, CXWindowPosition, CYWindowPosition, (User32.SetWindowPosFlags)Flags);
    } // END::OF::METHOD::VGFSleepThread

    /// <summary>
    /// Lock now the Windows Workstation
    /// </summary>
    /// <returns>
    /// 
    /// </returns>
    /// <remarks>
    /// Windows 10/11 Professional Edition is now an Workstation every Computerart.
    /// with many Network Libraries contact to Server, but you must have license Windows Server CAL
    /// internal check you have License.
    /// Call the Method, and he locked the Workstation, enlocked with new LogIn Window.
    /// </remarks>
    public static bool VGFLockWindowsWorkStation()
    {
        // User32 wrappers by David Hall Project 'VANARA'
        // see Windows Library User32.dll and Function MessageBox, written for .NET
        return User32.LockWorkStation();
    }

    /// <summary>
    /// Show MessageBox
    /// </summary>
    /// <param name="MessageText">set messagetext here</param>
    /// <param name="Messagetitle">set messagetitle here</param>
    /// <param name="MessageBoxFlags">set same flags for messagebox</param>
    /// <remarks>
    /// use flags so or with your flags | or!
    /// User32.MB_FLAGS.MB_OK | User32.MB_FLAGS.MB_ICONERROR | User32.MB_FLAGS.MB_SETFOREGROUND | User32.MB_FLAGS.MB_SYSTEMMODAL
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    public static uint VGFMessageBox(string MessageText, string Messagetitle, uint MessageBoxFlags)
    {
        // User32 wrappers by David Hall Project 'VANARA'
        // see Windows Library User32.dll and Function MessageBox, written for .NET
        return (uint)User32.MessageBox(nint.Zero, MessageText, Messagetitle, (User32.MB_FLAGS)MessageBoxFlags);

    }

    /// TIPPLIN ! next work
    /// TODO ! NOTE ! the method AdvApi32.RegOpenKeyEx must be change in correct parameters

    /// <summary>
    /// Open an Registry Key for Information
    /// </summary>
    /// <returns>
    /// 
    /// </returns>
    /// <remarks>
    /// Registry Function from Windows System.
    /// NOTE:
    /// For Arcyl Background on Desktop by LogIn we can set no Arcyl, 
    /// so Windows show everytime changes backgrounds with Images.
    /// We create following Registry Key:
    /// 
    /// </remarks>
    public static uint VGFOpenRegistryKey()
    {
        // User32 wrappers by David Hall Project 'VANARA'
        // see Windows Library AdvApi32.dll and Function RegOpenKeyEx, written for .NET
        //return AdvApi32.RegOpenKeyEx(HKEY.HKEY_LOCAL_MACHINE, "", AdvApi32.RegOpenOptions.REG_OPTION_OPEN_LINK, AdvApi32.REGSAM.KEY_ALL_ACCESS, Microsoft.Win32.SafeHandles.SafeRegistryHandle);
        return 1;
    
    }








}

