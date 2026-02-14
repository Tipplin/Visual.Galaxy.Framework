//############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//############################################################################
//
//----------------------------------------------------------------------------
// Programmer		:	Christian "Tipplin" Kurs
//----------------------------------------------------------------------------
// Part				:	Base Core
//----------------------------------------------------------------------------
// Base Class		:	VGFCore
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
// © 1982-2023 - Copyrights by Microsoft: Images, Icons, Signs, Gadgets, 
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
 * Authored by Copyright © 2917-2026 by 
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
 * © 1982-2026 Microsoft Corporation.All rights reserved.
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

//------------------------- Universal Info ------------------------------------
//------------------------- Windows Operation System --------------------------
// using following system dll's with functions:
//
// <shlobj.h>		is shell32.lib, shell32.dll
// <winuser.h>		is user32.lib, user32.dll
// <Winbase.h>		is kernel32.lib, kernel32.dll
// <wincrypt.h>	is crypt32.lib, crypt32.dll
// <Winreg.h>		is Advapi32.lib, Advapi32.dll
// <Shlwapi.h>		is Shlwapi.lib, shlwapi.dllu
// <winnt.h>		is Windows NT Visual C++ Header file
//
//
//
//
//------------------------- Visual C++ Pointer's to Visual C# Pointer's -------
// ! NOTE ! Different Languages, so pass on Pointer's.
// ! INFO ! In .NET NOT usefully Pointer's !!!!.
// ! USE ! Please take in a using unsafe block for Pointer's.
// unsafe
// {
//
// }
//--------------------------- Visual C++ ----------------- Visual C# ----------
// WORD = (single) word 16BIT - unsigned short				ushort
// DWORD = double word 32BIT - unsigned long				uint
// QWORD = 64BIT for registry
// BYTE = unsigned char										byte
// FLOAT = single - float									single
// ULONGLONG = unsigned longlong 64BIT (16 Exabyte scope)	ulong
// Pointer C++ to C# 
// ----------------------------------------------------------------------------
// PFLOAT = Pointer of FLOAT - *PFLOAT						Float*
// PBOOL = Pointer of BOOL	- *PBOOL						Bool*
// PBYTE = Pointer of BYTE - *PBYTE							Byte*
// PINT = Pointer of INTEGER - *PINT						PInt*
// PWORD = Pointer of WORD - *PWORD							PWord*
// LPINT = LongPointer of INTEGER - *LPINT					LPInt*
// ----------------------------------------------------------------------------
// New C# 128 BIT Datatypes:
// integer128
// unsigned integer128
// for long time vendors meeting for an 128 Bit Operation System:
// Microsoft, IBM, HP....
//
//----------- Windows Operation System Special --------------------------------
// ! ATTENTION ! BOOLEAN - BOOL is 1 Byte intern, for Visual C# use byte as
// datatype. (bool C/C++ 4 bytes, C# 2 bytes (hardcoded=true,false))
// Windows Functions: BOOLEAN SetComputerNameEx and BOOLEAN GetComputerNameEx 
// for Visual C#: byte SetComputerNameEx and byte GetComputerNameEx 
//-----------------------------------------------------------------------------
//
//		Base Class for all other Classes in Visual Galaxy Framework
//		First set here Windows Operation System Functions native,
//		unmanaged code in Visual C++.
//		In DLLImportAttribute: 
//		SetLastError ONLY for Visual C++ and Visual C#, BUt NOT for
//		Java and Visual Basic.NET !.
//		DON'T USE GetLastError pure, inside GetWin32LastErrorMessage() 
//				
//----------------------------- WINDOWS 10 ------------------------------------
// New native code written in Visual C++: 
// Have marked with NEW Windows 10
// RestoreLastError -
//-----------------------------------------------------------------------------
//
//
//
//#############################################################################

//----------------------------------------------------------------
// For Developers:
// ---------------------------------------------------------------
// String.Array
// for Array's in .NET with Extenstions:
// Array.Add, add a new member
// Array.Exists, exists the member in array ?
// Array.splitted, remove an member 
//----------------------------------------------------------------
//
//
// Standard Date Time Format Specifiers
// Formatting in .NET Framework with Visual C# and Two Letter ISO
// for Country Culture: en-US for USA, de-DE for Germany
//----------------------------------------------------------------
// € is sign for euro - Europe States and associated.
// $ is sign for dollar - USA
//
//-----------------------------------------------------------------------------
//
//----------------------------------------------------------------
// main(string[] args) returned Values for Program code by End:
// int main(string[] args),
// don't forget, set a try/catch/finally block with return a value
// (Message "must be return a value !") - return 1, or return 0,
//
//=============================================================================
// Visual C# allowed us change the datatype in main.
// void to integer - int - and allowed more than one main !, 
// but one be the First Main marked to Compiler /main:name.cs
//-----------------------------------------------------------------------------
// 1. void give anytime value: 0 / zero returned values
// 2. int returned internal program code at end of Program.
//-----------------------------------------------------------------------------
//=============================================================================
// Program Returned Values are:
//=============================================================================
//   0		- successfully	- End the Program without Error
//   1 		- failure		- End the Program with Error
//
//-----TIPPLIN UNCHECKED---------------------------------------------------------
//   2		- value of program parameters not allowed
//   3		- file not found
//   4		- searching (way) not found
//   5		- too many open files 
//   6		- file access violation 
//  12		- handle not defined/wrong
//  63		- not guilty access code
//  80		- program description
// 255		- unknown Error !
//
//=============================================================================

/*************************************************************************
 ********************* LANGUAGES INFORMATION *****************************
 ********************* .NET FRAMEWORK ************************************
 *************************************************************************
 * Languages - native	- integer Value primary and secondary
 * -----------------------------------------------------------------------
 * Languages - .NET	- Two Letter ISO and Three Letter ISO
 * For more Information at 'German Umlauts' 
 * see Info File Dr. Knittel in German and English
 * -----------------------------------------------------------------------
 * 
 * de-BE for German Minority in Belgium, but 'tipplin' UNCHECKED.
 * de-DE for Germany--------- "German Umlauts" -
 * de-AT for Autriche-------- "German Umlauts" - 
 * de-CH for Switzerland----- "German Umlauts" - different to Germany,
 * de-LS for Liechtenstein---
 * de-LU for Luxembourg------
 * 
 * -------------------- Language Dialects ---------------------------------
 * ---Three Letter ISO for Germany Special-Language Dialect-.NET Framework 
 * ------------------------------------------------------------------------
 * ----------------- den-WEN - Sorbian Wendish ----------------------------
 * 
 * for the people of Spreewood by Berlin in Lausitz.
 * dobre ranje - witami nam
 *=========================================================================
 * 'Tipplin' myself:
 * ------------------------------------------------------------------------
 * In Germany for interest Humans give an Art of Highschool:
 * 'Volkshochschule' graduted Informatic with Test and Certification.
 * Windows Insider Program with many Feedback last time.
 * ------------------------------------------------------------------------
 * GitHub Member:
 * https://www.github.com/tipplin
 * 
 * ------------------------------------------------------------------------
 * GitHub Repositories:
 * 
 * 
 * 
 * 
 * ------------------------------------------------------------------------
 * NASA Community Member:
 * ISS Livechat, ISS Flight Map on Earth, 
 * ISS Live with Questions to Astronauts,
 * ISS Video's
 * NASA Videos with Music, ISS Flight on about Earth.
 * - Sound on Silence, 
 * - ISS Video Europe, all Cities, blend in the name of City.
 * ------------------------------------------------------------------------
 * Amazing Space Member: 
 * Great Video about our SUN ! in 8K Special Camera
 * ------------------------------------------------------------------------
 * I live in:
 * Köln Porz Zündorf
 * ------------------------------------------------------------------------
 * 2017: 
 * Cologne is the greathest City over 1 Million People -6. Place in Germany
 * ------------------------------------------------------------------------
 * United Nations in Bonn:
 * UN-Tower - (German Slang "Langer Eugen").
 * 'UN Bonn' Website for more Information what UN do in Bonn.
 * 2000 Workers
 * ------------------------------------------------------------------------
 * Three Cities in the World:
 * New York, Wien, Genf and Bonn. 
 * ------------------------------------------------------------------------
 * Investor: 
 * The New Cancellor Place in Bonn. (Website) with 3 Buildings.
 * now in Work - ca. 2023
 * 'URBAN SOUL' near Train Central Station, nice to see!
 * ------------------------------------------------------------------------
 * The best Hotels in Bonn, Germany:
 * ------------------------------------------------------------------------
 * The Mariott Hotel 4+ (5) Stars in Bonn, 17Floor see by clear Weather,
 * Cologne and the famous DOM !. Bistro over there of all People !
 * Nice for: 
 * Christmas Party, New Year with Fireworks, DJ Musics, Shilling!
 * and Hotel Chambers with very Prices.
 * 
 * MARIOTTT Greathest Worldwide Hotelgroup.
 * ------------------------------------------------------------------------
 * Hotel Kahema and Bavarian 'Biergarten'
 * Bavarian 'Almhütte' near Rhine with Orginal Bavarian Meats and Beer, more...
 * delivered from Bavaria.
 * 
 * Hotel Hilton (IS OVER!, new Name is Hotel Dorint !)
 * 
 * The Steigenberger Hotel on Petersberg are 5 Stars Hotel.
 * 
 * ------------------------------------------------------------------------
 * The World Conference Center - WCCB - Full UN-Conferences in Bonn
 * 
 * ========================================================================
 */

/* ------------------------------------------------------------------------
 * For Unicode Information see Unicode Organization -
 * ------------------------------------------------------------------------
 * www.unicode.org
 * 
 * Online Tool "ShapeCatcher" 
 * write/paint your Sign or other into Box, 
 * and ShapeCatcher look directly in Unicode Organization is or not !.
 * ------------------------------------------------------------------------
 * UO Return: Hexadecimal Value and Font...
 * UTF8	- 8 BIT	 - Signs, Music, Chemistry, and "German Umlauts"
 * UTF16 	- 16 BIT - Work into Common Language Runtime
 * UTF32 	- 32 BIT - only Algorithmic
 * ------------------------------------------------------------------------
 * For 'German Umlauts' have Specials from Dr. Knittel -CBM-:
 * Same German Umlauts in Germany, Autriche, Switzerland..
 * ä. ü, ß - sharp s - other see in Handbook.
 * 
 * ------------------------------------------------------------------------
*/

/* ------------------------------------------------------------------------
 * Console Window is Now the Operation System Window:
 * ========================================================================
 * programming your Console App with Class, Methods, Properties
 * and 1 Event.
 * Windows 10 - Console Window:
 * more colors, 
 * SimpleSample, create a Console Window to your App, 
 * the Console Window goes HIDE, can receive and send to other
 * Window's, create logfile, Message for Information, Warnings,
 * by Critical goes from HIDE in Show Modus to show current User
 * this Messages.
 * ------------------------------------------------------------------------
 * TIPPO's: 
 * Console Window App with Splash, at runtime goes in Resize and 
 * show Splash Image after Thread.Sleep goes another
 * Resize Normal and show all Messages.
 * Dependency with native Functions Library written in C.
 * Console Window App with Class ExternalNativeFunction 
 * MultiBeep, MessageBox(int TextID) - see fore defined Text,
 * set only TextID.
 * 
 * Avantage: Console Window have smaller Overhead as a Window.
 * Faster, directly to Operation System !.
 * ------------------------------------------------------------------------
 * at 2016 - German Umlauts allowed in Cryptografie and Internet/Web
 * ! NOTE - NEW ! - SHA1 is OUT !!!!.
 * ------------------------------------------------------------------------
 * ! TIPPO !: Set Language System Functions here to sure.
 * Some Functions intergrated in .NET Framework
 * 
 *************************************************************************/

/*
 * Use internal at .NET 7 release with Visual C# 11, see the new sets global
 * means all directives guilty in Project, 
 * no more write namespaces in other cs.files.
 * 
 * ATTENTION ! at new .NET8 have an file with auto-created 
 * usings global for all .cs Files,
 * so you must no again set this usings.
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
 * 
 * David Hall nice Project on GitHub, 
 * with many Windows Functions and more,
 * insert only your want!
 * 
 * use in this Project:
 * Vanara.Net
 * Vanara.PInvoke.Kernel32
 * Vanara.PInvoke.Shell32
 * Vanara.PInvoke.User32
 * Vanara.PInvoke.NetApi32
 * Vanara.PInvoke.Security
 * 
 * 
 **************************************************/
global using Vanara.PInvoke;





/*
 * namespace VGF
 * the parenthese {} are now in semicolon ;
 * that's new by .NET7 and Visual C# 11.
 */
namespace VGF;

/// <summary>
/// 
/// </summary>
internal static class VGFCore
{

    /// <summary>
    /// Create Logfile
    /// </summary>
    /// <param name="FileName"></param>
    /// <returns></returns>
    internal static bool VGFCreateLogFile(string FileName)
    {
        try
        {

            StringBuilder sb = new();
            StreamWriter sw = new StreamWriter(FileName);

            sw.Write("Username: ", Environment.UserName);
            sw.Write("Computername: ", Environment.MachineName);
            sw.Write("Operation System Version: ", Environment.OSVersion.ToString() );
            sw.Write("OS-64BIT: ", Environment.Is64BitOperatingSystem.ToString() );
            

            // NOTE: Flush() set before close the File, not the stream is null in File.
            sw.Flush();
            // Close the File and underlying Stream
            sw.Close();
            // NO Exception, return everytime beends the Method.
            return true;
        }
        catch(Exception ex)
        {
            // User32 wrappers by David Hall Project 'VANARA'
            // see Windows Library User32.dll and Function MessageBox, written for .NET
            User32.MessageBox(IntPtr.Zero, ex.Message, ex.Source, User32.MB_FLAGS.MB_OK | User32.MB_FLAGS.MB_ICONERROR | User32.MB_FLAGS.MB_SETFOREGROUND | User32.MB_FLAGS.MB_SYSTEMMODAL);
            return false;
        }
    } // END::OF::METHOD::VGFCreateLogFile

    

} // END::OF::CLASS::VGFCore

